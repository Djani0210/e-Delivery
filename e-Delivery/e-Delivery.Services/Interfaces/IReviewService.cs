using e_Delivery.Model.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Services.Interfaces
{
    public interface IReviewService
    {
        Task<Message> CreateOrUpdateReviewAsMessageAsync(CreateOrUpdateReviewVM createOrUpdateReviewVM, CancellationToken cancellationToken);

        Task<Message> DeleteReviewAsMessageAsync(int id, CancellationToken cancellationToken);
        Task<double?> GetReviewScoreForRestaurantAsync(CancellationToken cancellationToken);

        
    }
}
