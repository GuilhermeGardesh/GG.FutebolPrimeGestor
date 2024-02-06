using FutebolPrimeGestor.Domain.Entities;
using FutebolPrimeGestor.Domain.Interfaces;
using FutebolPrimeGestor.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FutebolPrimeGestor.Infra.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly FutebolPrimeGestorDbContext _dbContext;
        public ClienteRepository(FutebolPrimeGestorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Cliente> AddAsync(Cliente cliente)
        {
            await _dbContext.AddAsync(cliente);
            return cliente;
        }

        public async Task<List<Cliente>> AddRangeAsync(List<Cliente> clientes)
        {
            await _dbContext.AddRangeAsync(clientes);
            return clientes;
        }

        public async Task DeleteAsync(Guid idCliente)
        {
            var cliente = await GetByIdAsync(idCliente);
            _dbContext.Remove(cliente);
        }

        public async Task<Cliente> EditAsync(Cliente cliente)
        {
            _dbContext.Update(cliente);
            return cliente;
        }

        public async Task<List<Cliente>> GetAllAsync()
        {
            var clientes = await _dbContext.Clientes.ToListAsync();
            return clientes;
        }

        public async Task<Cliente> GetByCpfAsync(string cpf)
        {
            var cliente = await _dbContext.Clientes.FirstOrDefaultAsync(x => x.CPF == cpf);
            return cliente;
        }

        public async Task<Cliente> GetByIdAsync(Guid idCliente)
        {
            var cliente = await _dbContext.Clientes.FirstOrDefaultAsync(x => x.Id == idCliente);
            return cliente;
        }
    }
}
