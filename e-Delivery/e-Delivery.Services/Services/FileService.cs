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
        public async Task<Message> UploadImageAsMessageAsync(FileUploadVM fileUploadVM, CancellationToken cancellationToken)
        {
            try
            {
                var loggedUser = await  authContext.GetLoggedUser();
                var image = UploadImageHelper.UploadFile(fileUploadVM.ImageURL);
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
                var image = UploadImageHelper.UploadFile(fileUploadDto.ImageURL);
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
                    im.IsDeleted = true;
               

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
                    Data = Mapper.Map < List < ImageGetVM>>(images),
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

    }
}
