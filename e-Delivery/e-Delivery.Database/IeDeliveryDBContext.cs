namespace e_Delivery.Database
{
    public interface IeDeliveryDBContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}