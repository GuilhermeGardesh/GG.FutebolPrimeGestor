using FutebolPrimeGestor.Domain.Entities;
using FutebolPrimeGestor.Domain.Interfaces;
using FutebolPrimeGestor.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FutebolPrimeGestor.Infra.Data.Repositories
{
    internal class QuadraRepository : IQuadraRepository
    {
        private readonly FutebolPrimeGestorDbContext _dbContext;
        public QuadraRepository(FutebolPrimeGestorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Quadra> AddAsync(Quadra quadra)
        {
            await _dbContext.AddAsync(quadra);
            return quadra;
        }


        public async Task<List<Quadra>> AddRangeAsync(List<Quadra> quadras)
        {
            await _dbContext.AddRangeAsync(quadras);
            return quadras;
        }

        public async Task DeleteAsync(Guid idCliente)
        {
            var quadra = await GetByIdAsync(idCliente);
            _dbContext.Remove(quadra);
        }

        public async Task<Quadra> EditAsync(Quadra quadra)
        {
            _dbContext.Update(quadra);
            return quadra;
        }

        public async Task<List<Quadra>> GetAllAsync()
        {
            var quadras = await _dbContext.Quadras.ToListAsync();
            return quadras;
        }

        public async Task<Quadra> GetByIdAsync(Guid idQuadra)
        {
            var quadra = await _dbContext.Quadras.FirstOrDefaultAsync(x => x.Id == idQuadra);
            return quadra;
        }
    }
}
