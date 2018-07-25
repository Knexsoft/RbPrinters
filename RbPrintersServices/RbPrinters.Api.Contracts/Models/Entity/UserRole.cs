using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class UserRole : IBaseEntity
    {
        public Guid ID { get; set; }
        public string Role { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
