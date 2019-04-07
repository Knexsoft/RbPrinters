using RbPrinters.Api.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        RbPrintersDbContext _dbContext;
        public DbFactory(RbPrintersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public RbPrintersDbContext Init()
        {
            return _dbContext;
        }

        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}
