using FutebolPrimeGestor.Domain.Entities;

namespace FutebolPrimeGestor.Domain.Interfaces
{
    public interface IAluguelDeQuadraRepository
    {
        Task<AluguelDeQuadra> AddAsync(AluguelDeQuadra aluguelDeQuadra);
        Task<List<AluguelDeQuadra>> AddRangeAsync(List<AluguelDeQuadra> aluguelDeQuadra);
        Task DeleteAsync(Guid idAluguelDeQuadra);
        Task<AluguelDeQuadra> EditAsync(AluguelDeQuadra aluguelDeQuadra);
        Task<List<AluguelDeQuadra>> GetAllAsync();
        Task<AluguelDeQuadra> GetByIdAsync(Guid idAluguelDeQuadra);
    }
}
