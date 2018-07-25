using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Abstract
{
    public interface IDbFactory : IDisposable
    {
        RbPrintersDbContext Init();
    }
}
