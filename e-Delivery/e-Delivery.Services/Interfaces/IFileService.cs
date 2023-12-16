using e_Delivery.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IFileService
    {
        Task<Message> UploadImageAsMessageAsync(FileUploadVM fileUploadDto, CancellationToken cancellationToken);
        Task<Message> GetImagesByRestaurantAsMessageAsync(CancellationToken cancellationToken);
        Task<Message> GetImagesByRestaurantIdAsMessageAsync(int Id, CancellationToken cancellationToken);//difference between desktop and mobile user
        Task<Message> DeleteImageByRestaurantAsMessageAsync(int Id, CancellationToken cancellationToken);
        Task<Message> ChangeMyProfilePictureAsMessageAsync(FileUploadVM fileUploadDto, CancellationToken cancellationToken);
        Task<Message> GetProfilePictureAsMessageAsync(CancellationToken cancellationToken);
    }
}
