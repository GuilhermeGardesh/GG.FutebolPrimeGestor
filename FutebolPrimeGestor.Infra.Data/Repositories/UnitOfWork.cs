using FutebolPrimeGestor.Domain.Interfaces;
using FutebolPrimeGestor.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FutebolPrimeGestorDbContext _dbContext;

        public UnitOfWork(FutebolPrimeGestorDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
