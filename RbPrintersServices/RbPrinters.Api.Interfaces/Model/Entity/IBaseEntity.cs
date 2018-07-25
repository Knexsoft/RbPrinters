using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Interfaces.Model.Entity
{
    public interface IBaseEntity
    {
        Guid ID { get; set; }
    }
}
