namespace Bookify.Domain.Apartments.Interface
{
    public interface IApartmentRepository
    {
        Task<Apartment?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}