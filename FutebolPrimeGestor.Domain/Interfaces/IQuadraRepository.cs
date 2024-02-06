using FutebolPrimeGestor.Domain.Entities;

namespace FutebolPrimeGestor.Domain.Interfaces
{
    public interface IQuadraRepository
    {
        Task<Quadra> AddAsync(Quadra quadra);
        Task<List<Quadra>> AddRangeAsync(List<Quadra> quadra);
        Task DeleteAsync(Guid idQuadra);
        Task<Quadra> EditAsync(Quadra quadra);
        Task<List<Quadra>> GetAllAsync();
        Task<Quadra> GetByIdAsync(Guid idQuadra);
    }
}
