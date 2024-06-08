using AutoMapper;
using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model;
using e_Delivery.Model.Images;
using e_Delivery.Services.Helper;
using e_Delivery.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class FileService : IFileService
    {
        public readonly eDeliveryDBContext _dbContext;
        public IMapper Mapper { get; set; }
        private IAuthContext authContext { get; set; }
        public static IWebHostEnvironment _webHostEnvironment;

        public FileService(eDeliveryDBContext dbContext, IWebHostEnvironment webHostEnvironment, IMapper mapper, IAuthContext authContext)
        {
            _dbContext = dbContext;
            _webHostEnvironment = webHostEnvironment;
            Mapper = mapper;
            this.authContext = authContext;
        }
        public async Task<Message> UploadAndSetRestaurantLogoAsync(FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            try
            {
                if (fileUploadDto.ImageFile == null || fileUploadDto.ImageFile.Length == 0)
                {
                    return new Message { IsValid = false, Info = "No file uploaded.", Status = ExceptionCode.BadRequest };
                }

                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.FirstOrDefaultAsync(r => r.CreatedByUserId == loggedUser.Id, cancellationToken);

                if (restaurant == null)
                {
                    return new Message { IsValid = false, Info = "Restaurant not found.", Status = ExceptionCode.NotFound };
                }

                var imagePath = UploadImageHelper.UploadFile(fileUploadDto.ImageFile);
                var newLogo = new Image
                {
                    Path = imagePath,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = loggedUser.Id,
                    ModifiedByUserId = loggedUser.Id
                };

                await _dbContext.AddAsync(newLogo, cancellationToken);
                await _dbContext.SaveChangesAsync(cancellationToken);

                restaurant.LogoId = newLogo.Id;
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    Data = Mapper.Map<ImageGetVM>(newLogo),
                    IsValid = true,
                    Info = "Logo uploaded successfully.",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = $"An error occurred: {ex.Message}",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> DeleteRestaurantLogoAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var restaurant = await _dbContext.Restaurants.Include(r => r.Logo).FirstOrDefaultAsync(r => r.CreatedByUserId == loggedUser.Id, cancellationToken);

                if (restaurant?.Logo == null)
                {
                    return new Message { IsValid = false, Info = "No logo found to delete.", Status = ExceptionCode.NotFound };
                }

                restaurant.Logo.IsDeleted = true;
                await _dbContext.SaveChangesAsync(cancellationToken);

                return new Message
                {
                    IsValid = true,
                    Info = "Logo deleted successfully.",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = $"An error occurred: {ex.Message}",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> UpdateRestaurantLogoAsync(FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            // Delete the current logo
            var deleteMessage = await DeleteRestaurantLogoAsync(cancellationToken);
            if (!deleteMessage.IsValid)
            {
                return deleteMessage; // Return the message if deletion was unsuccessful
            }

            // Upload and set the new logo
            return await UploadAndSetRestaurantLogoAsync(fileUploadDto, cancellationToken);
        }

        public async Task<Message> UploadImageAsMessageAsync(FileUploadVM fileUploadVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var image = UploadImageHelper.UploadFile(fileUploadVM.ImageFile);
                var file = new ImageCreateVM
                {
                    Path = image,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = loggedUser.Id,
                    ModifiedByUserId = loggedUser.Id,
                    UserProfilePictureId = null
                };
                var obj = Mapper.Map<Image>(file);

                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    Data = Mapper.Map<ImageGetVM>(obj),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }
        public async Task<Message> ChangeMyProfilePictureAsMessageAsync(FileUploadVM fileUploadDto, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();

                if (fileUploadDto.ImageFile == null || fileUploadDto.ImageFile.Length == 0)
                {
                    return new Message { IsValid = false, Info = "No file uploaded.", Status = ExceptionCode.BadRequest };
                }

                var image = UploadImageHelper.UploadFile(fileUploadDto.ImageFile);
                var file = new ImageCreateVM
                {
                    Path = image,
                    IsDeleted = false,
                    CreatedDate = DateTime.Now,
                    CreatedByUserId = loggedUser.Id,
                    ModifiedByUserId = loggedUser.Id,
                    UserProfilePictureId = loggedUser.Id
                };
                var images = await _dbContext.Images.Where(x => x.UserProfilePictureId == loggedUser.Id && !x.IsDeleted).ToListAsync(cancellationToken);
                foreach (var im in images)
                {
                    im.IsDeleted = true;
                }

                var obj = Mapper.Map<Image>(file);
                await _dbContext.AddAsync(obj);
                await _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    Data = Mapper.Map<ImageGetVM>(obj),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString()); 
                return new Message
                {
                    IsValid = false,
                    Info = $"An error occurred: {ex.Message}",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> DeleteImageByRestaurantAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var logo = await _dbContext.Images.Where(x => x.Id == Id).FirstOrDefaultAsync(cancellationToken);
                logo.IsDeleted = true;

                _dbContext.SaveChangesAsync(cancellationToken);
                return new Message
                {
                    Data = Id,
                    IsValid = true,
                    Info = "Successfully deleted",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetImagesByRestaurantAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var logo = await _dbContext.Restaurants.Include(x => x.Logo).Where(x => x.Id == loggedUser.RestaurantId).FirstOrDefaultAsync(cancellationToken);
                var images = await _dbContext.Images.Include(x => x.CreatedByUser).Where(x => x.CreatedByUser.RestaurantId == loggedUser.RestaurantId && x.Id != logo.LogoId && !x.IsDeleted && x.UserProfilePicture == null).ToListAsync(cancellationToken);

                return new Message
                {
                    Data = Mapper.Map<List<ImageGetVM>>(images),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetImagesByRestaurantIdAsMessageAsync(int Id, CancellationToken cancellationToken)
        {
            try
            {
                var images = await _dbContext.Images.Include(x => x.CreatedByUser).Where(x => x.CreatedByUser.RestaurantId == Id && !x.IsDeleted && x.UserProfilePicture == null).ToListAsync(cancellationToken);

                return new Message
                {
                    Data = Mapper.Map<List<ImageGetVM>>(images),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetProfilePictureAsMessageAsync(CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await authContext.GetLoggedUser();
                var image = await _dbContext.Images.Where(x => x.UserProfilePictureId == loggedUser.Id && !x.IsDeleted).FirstOrDefaultAsync(cancellationToken);

                return new Message
                {
                    Data = Mapper.Map<ImageGetVM>(image),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }

        public async Task<Message> GetProfileImageByUserId(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var user = await _dbContext.Users.Where(u=>u.Id==id).FirstOrDefaultAsync();
                var image = await _dbContext.Images.Where(x => x.UserProfilePictureId == user.Id && !x.IsDeleted).FirstOrDefaultAsync(cancellationToken);

                return new Message
                {
                    Data = Mapper.Map<ImageGetVM>(image),
                    IsValid = true,
                    Info = "Success",
                    Status = ExceptionCode.Success
                };
            }
            catch (Exception ex)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Bad Request",
                    Status = ExceptionCode.BadRequest
                };
            }
        }
    }
}

