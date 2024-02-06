using FutebolPrimeGestor.Domain.Entities;

namespace FutebolPrimeGestor.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Task<Cliente> AddAsync(Cliente cliente);
        Task<List<Cliente>> AddRangeAsync(List<Cliente> cliente);
        Task DeleteAsync(Guid idCliente);
        Task<Cliente> EditAsync(Cliente cliente);
        Task<List<Cliente>> GetAllAsync();
        Task<Cliente> GetByIdAsync(Guid idCliente);
        Task<Cliente> GetByCpfAsync(string cpf);
    }
}
