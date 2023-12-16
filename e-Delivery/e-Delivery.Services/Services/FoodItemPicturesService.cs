using e_Delivery.Database;
using e_Delivery.Entities;
using e_Delivery.Entities.Enums;
using e_Delivery.Model.FoodItem;
using e_Delivery.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Services
{
    public class FoodItemPicturesService : IFoodItemPicturesService
    {
        private readonly eDeliveryDBContext _dbContext;
        public FoodItemPicturesService(eDeliveryDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Message> CreateAsMessageAsync(int id, FoodItemPictureAddVM vm)
        {
           if(vm.FoodItem_image== null)
            {
                return new Message
                {
                    IsValid = false,
                    Status= ExceptionCode.BadRequest,
                    Info="Slika nije uploadovana"
                };
            }
            if (vm.FoodItem_image.Length > 900 * 1000)
            {
                return new Message {

                    IsValid = false,
                    Info = "max velicina fajla je 900 KB",
                    Status = ExceptionCode.BadRequest,
                };
            }
            string extension = Path.GetExtension(vm.FoodItem_image.FileName);

            var filename= $"{Guid.NewGuid()}{extension}";

            vm.FoodItem_image.CopyTo(new FileStream(Helper.Config.SlikeFolder + filename, FileMode.Create));

            var slika = new FoodItemPictures
            {
                FileName =  Helper.Config.SlikeURL+filename,
                FileSize= (int)vm.FoodItem_image.Length,
                FoodItemId = id
            };

            _dbContext.AddAsync(slika);
            await _dbContext.SaveChangesAsync();

            return new Message
            {
                IsValid = true,
                Info = "Slika uspjesno dodana",
                Status = ExceptionCode.Success,
                Data = slika
            };
        }

        public async Task<Message> DeleteAsMessageAsync(int id)
        {
            FoodItemPictures? entity =  await _dbContext.FoodItemPictures.FindAsync(id);

            if(entity == null)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Entitet nije pronađen.",
                    Status = ExceptionCode.NotFound
                };
            }
            _dbContext.Remove(entity);
            await _dbContext.SaveChangesAsync();

            return new Message
            {
                IsValid = true,
                Info = $"Entitet obrisan.",
                Status = ExceptionCode.NotFound,
                Data = entity
            };
        }

        public async Task<Message> GetAllAsMessageAsync(int id)
        {
            var entity = _dbContext.FoodItemPictures.Where(x=> x.FoodItemId == id).ToListAsync();
            if (entity is null)
            {
                return new Message
                {
                    IsValid = false,
                    Info = "Entitet nije pronađen",
                    Status = ExceptionCode.NotFound,
                };
            }

            return new Message
            {
                IsValid = true,
                Info = "Entitet pronađen",
                Status = ExceptionCode.Success,
                Data = entity
            };
        }
    }
}
