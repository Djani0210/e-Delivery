using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.Images;
using e_Delivery.Model.Restaurant;
using e_Delivery.Model.Role;
using e_Delivery.Model.User;
using e_Delivery.Model.Verification;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class UserService : IUserService
    {
        private readonly eDeliveryDBContext _dbContext;
        private UserManager<User> UserManager { get; set; }
        
        public IMapper Mapper { get; set; }
        public IAuthContext _authContext { get; set; }
        public UserService(eDeliveryDBContext dbContext, UserManager<User> userManager, IMapper mapper, IAuthContext authContext)
        {
            _dbContext = dbContext;
            _authContext = authContext;
            Mapper = mapper;
            UserManager= userManager;
        }

        public async Task<Message> CheckCodeAsMessageAsync(VerificationCodeVM verificationCodeDto, CancellationToken cancellationToken)
        {
            try
            {
                var verification = await _dbContext.Verifications.Include(x => x.User).Where(x => x.Code == verificationCodeDto.Code && x.User.Email == verificationCodeDto.Email && !x.IsConfirmed).FirstOrDefaultAsync();
                if (verification == null)
                    return new Message { Info = "Greška", IsValid = false, Status = ExceptionCode.BadRequest };
                else
                {
                    verification.IsConfirmed = true;
                    await _dbContext.SaveChangesAsync(cancellationToken);
                    return new Message { Info = "Uspješno potvrđen kod", Data = verification.UserId, IsValid = true, Status = ExceptionCode.Success };
                }
            }
            catch (Exception ex)
            {
                return new Message { Info = "Greška", IsValid = false, Status = ExceptionCode.BadRequest };
            }
        }

        

        public async Task<Message> CreateUserAsMessageAsync(UserCreateVM userCreateVM, CancellationToken cancellationToken)
        {
            var status = ExceptionCode.Success;
            try
            {
                bool duplicateEmail = await ThrowOnCreateUserDuplicateEmailError(userCreateVM, cancellationToken);
                bool duplicateUserName = await ThrowOnCreateDuplicateUsernameError(userCreateVM, cancellationToken);
                if (duplicateEmail && duplicateUserName)
                {
                    status = ExceptionCode.BadRequest;
                    throw new Exception($"Korisnik sa e-mailom: '{userCreateVM.Email}' već postoji!" + Environment.NewLine + $"Korisnik sa username: '{userCreateVM.UserName}' već postoji!");
                }

                if (duplicateEmail)
                {
                    status = ExceptionCode.BadRequest;
                    throw new Exception($"Korisnik sa e-mailom: '{userCreateVM.Email}' već postoji!");
                }

                if (duplicateUserName)
                {
                    status = ExceptionCode.BadRequest;
                    throw new Exception($"Korisnik sa username: '{userCreateVM.UserName}' već postoji");
                }
                using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);
                try
                {

                    var user = new User();
                    user.Email = userCreateVM.Email;
                    user.UserName = userCreateVM.UserName;
                    user.PhoneNumber = userCreateVM.PhoneNumber;
                    user.LastName = userCreateVM.LastName;
                    user.FirstName = userCreateVM.FirstName;
                    user.Gender = userCreateVM.Gender;
                    user.CreatedDate = DateTime.Now;
                    user.IsDeleted = false;
                    user.CityId = userCreateVM.CityId;
                    user.RestaurantId= userCreateVM.RestaurantId;
                    user.IsAvailable = userCreateVM.IsAvailable;
                    user.WorkFrom = TimeSpan.ParseExact(userCreateVM.WorkFrom, "hh\\:mm", CultureInfo.InvariantCulture); 
                    user.WorkUntil= TimeSpan.ParseExact(userCreateVM.WorkUntil, "hh\\:mm", CultureInfo.InvariantCulture); 

                    await UserManager.CreateAsync(user, userCreateVM.Password);
                    var roles = await _dbContext.Roles
                           .Where(x => userCreateVM.UserRoles.Contains(x.Id))
                           .ToListAsync(cancellationToken);

                    await UserManager.AddToRolesAsync(user, roles.Select(x => x.NormalizedName));
                    var file = new ImageCreateVM
                    {
                        Path = "/Uploads/Images/00caa4b0-1903-41b5-a8d0-e7a293e48283.jpg",
                        IsDeleted = false,
                        CreatedDate = DateTime.Now,
                        CreatedByUserId = user.Id,
                        ModifiedByUserId = user.Id,
                        UserProfilePictureId = user.Id
                    };
                    var obj = Mapper.Map<Image>(file);
                    await _dbContext.Images.AddAsync(obj);

                    await _dbContext.SaveChangesAsync(cancellationToken);
                    
                    await transaction.CommitAsync(cancellationToken);


                    return new Message { Info = "Successfully created user", IsValid = true, Status = status };
                }
                catch (Exception ex)
                {
                    status = ExceptionCode.BadRequest;
                    await transaction.RollbackAsync(cancellationToken);
                    return new Message { Info = ex.Message, IsValid = false, Status = status };
                }
            }
            catch (Exception ex)
            {
                status = ExceptionCode.BadRequest;
                return new Message { Info = ex.Message, IsValid = false, Status = status };
            }
        }

        public async Task<Message> ForgotPasswordAsMessageAsync(VerificationCreateVM verificationCreateDto, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _dbContext.Users.Where(x => string.Compare(x.Email, verificationCreateDto.Email) == 0).FirstOrDefaultAsync(cancellationToken);
                if (user == null)
                    return new Message { Info = "Korisnik nije nađen!", Status = ExceptionCode.NotFound, IsValid = false };
                var guid = Guid.NewGuid().ToString();
                var code = guid.Substring(0, 6);
                Verification verification = new Verification()
                {
                    Id = Guid.NewGuid(),
                    Code = code,
                    ExpireDate = DateTime.Now.AddMinutes(30),
                    IsConfirmed = false,
                    UserId = user.Id,
                };
                await _dbContext.Verifications.AddAsync(verification);
                await _dbContext.SaveChangesAsync(cancellationToken);
                bool n = _SendMail(verificationCreateDto.Email, "Verifikacijski kod", code);
                if (n)
                {
                    Email Email = new Email { Content = "VERIFIKACIJSKI KOD", Title = code, UserId = user.Id };
                    await _dbContext.AddAsync(Email);
                    await _dbContext.SaveChangesAsync(cancellationToken);
                    return new Message { Info = "Uspješno vraćen kod", IsValid = true, Status = ExceptionCode.Success };
                }
                else return new Message { Info = "Greška", IsValid = false, Status = ExceptionCode.BadRequest };

            }
            catch (Exception ex)
            {
                return new Message { Info = "Greška", IsValid = false, Status = ExceptionCode.BadRequest };
            }
        }

        public async Task<Message> GetUsersAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await _authContext.GetLoggedUser();

                var users = await _dbContext.Users.Where(x => x.Id != loggedUser.Id).ToListAsync();

                var userRoles = await _dbContext.UserRoles.ToListAsync(cancellationToken);
                var list = new List<UserGetVM>();
                var roles = await _dbContext.Roles.ToListAsync(cancellationToken);
                foreach (var user in users)
                {
                    var x = new List<UserRoleGetVM>();

                    UserGetVM newUser = new UserGetVM
                    {
                        Email = user.Email,
                        FirstName = user.FirstName,
                        Gender = user.Gender,
                        Id = user.Id,
                        LastName = user.LastName,
                        PhoneNumber = user.PhoneNumber,
                        UserName = user.UserName
                    };

                    // can u try now
                    x = userRoles.
                        Where(x => x.UserId == user.Id)
                        .Select(x => new UserRoleGetVM
                        {
                            RoleId = x.RoleId,
                            RoleName = roles.Where(a => a.Id == x.RoleId).FirstOrDefault().Name
                        }).ToList();
                    newUser.Role = x;
                    list.Add(newUser);


                }
                return new Message
                {
                    IsValid = true,
                    Info = "Successfully got users",
                    Status = ExceptionCode.Success,
                    Data = list
                };

            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = ex.Message,
                    Status = ExceptionCode.BadRequest
                };
            }
        }
        public bool _SendMail(string To, string Subject, string Sadrzaj)
        {
            MailMessage message = new MailMessage("mverifikacija@gmail.com", To);
            message.Subject = Subject;
            message.Body = Sadrzaj;
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
            System.Net.NetworkCredential basicCredential1 = new
            System.Net.NetworkCredential("mverifikacija@gmail.com", "qhmjyeiyiuruotrc");
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = basicCredential1;

            try
            {
                client.Send(message);
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Message> NewPasswordAsMessageAsync(NewPasswordVM newPasswordDto, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _dbContext.Users.Where(x => x.Id == newPasswordDto.Id).FirstOrDefaultAsync(cancellationToken);
                await UserManager.RemovePasswordAsync(user);
                await UserManager.AddPasswordAsync(user, newPasswordDto.Password);
                return new Message { Info = "Uspješno izmjenjena šifra", IsValid = true, Status = ExceptionCode.Success };
            }
            catch (Exception ex)
            {
                return new Message { Info = "Greška", IsValid = false, Status = ExceptionCode.BadRequest };
            }
        }

        public async Task<Message> UpdateUserAsMessageAsync(Guid Id, UserUpdateVM user, CancellationToken cancellationToken)
        {
            try
            {
                var _user = await _dbContext.Users.Where(x => x.Id == Id && !x.IsDeleted).FirstOrDefaultAsync(cancellationToken);
                if (_user == null)
                {
                    return new Message { Info = "Greška, korisnik ne postoji", IsValid = false, Status = ExceptionCode.BadRequest };
                }
                
                Mapper.Map(user, _user);
               
               
               
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message { Info = "Uspješno ažuriran korisnik", Data = user, IsValid = true, Status = ExceptionCode.Success };

            }
            catch (Exception ex)
            {
                return new Message { Info = "Greška na serveru", IsValid = false, Status = ExceptionCode.BadRequest };
            }
        }

        private async Task<bool> ThrowOnCreateUserDuplicateEmailError(UserCreateVM userCreateVM, CancellationToken cancellationToken)
        {
            return await _dbContext.Users.
                AnyAsync(x => x.Email == userCreateVM.Email, cancellationToken);
        }

        private async Task<bool> ThrowOnCreateDuplicateUsernameError(UserCreateVM userCreateVM, CancellationToken cancellationToken)
        {
            return await _dbContext.Users.
                AnyAsync(x => x.UserName == userCreateVM.UserName, cancellationToken);
        }
    }
}
