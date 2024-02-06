using FutebolPrimeGestor.Domain.Entities;
using FutebolPrimeGestor.Domain.Interfaces;
using FutebolPrimeGestor.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FutebolPrimeGestor.Infra.Data.Repositories
{
    public class AluguelDeQuadraRepository : IAluguelDeQuadraRepository
    {
        private readonly FutebolPrimeGestorDbContext _dbContext;
        public AluguelDeQuadraRepository(FutebolPrimeGestorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<AluguelDeQuadra> AddAsync(AluguelDeQuadra aluguelDeQuadra)
        {
            await _dbContext.AddAsync(aluguelDeQuadra);
            return aluguelDeQuadra;
        }


        public async Task<List<AluguelDeQuadra>> AddRangeAsync(List<AluguelDeQuadra> alugueis)
        {
            await _dbContext.AddRangeAsync(alugueis);
            return alugueis;
        }

        public async Task DeleteAsync(Guid idCliente)
        {
            var aluguelDeQuadra = await GetByIdAsync(idCliente);
            _dbContext.Remove(aluguelDeQuadra);
        }

        public async Task<AluguelDeQuadra> EditAsync(AluguelDeQuadra aluguelDeQuadra)
        {
            _dbContext.Update(aluguelDeQuadra);
            return aluguelDeQuadra;
        }

        public async Task<List<AluguelDeQuadra>> GetAllAsync()
        {
            var alugueis = await _dbContext.AlugueisDeQuadras.ToListAsync();
            return alugueis;
        }

        public async Task<AluguelDeQuadra> GetByIdAsync(Guid idQuadra)
        {
            var aluguelDeQuadra = await _dbContext.AlugueisDeQuadras.FirstOrDefaultAsync(x => x.Id == idQuadra);
            return aluguelDeQuadra;
        }
    }
}
