using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class PermissionLevel : IBaseEntity
    {
        public Guid ID { get; set; }
        public string Level { get; set; }
        public string PermissionTypes { get; set; }
    }
}
