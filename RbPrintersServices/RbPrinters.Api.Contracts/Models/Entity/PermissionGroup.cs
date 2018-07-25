using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class PermissionGroup : IBaseEntity
    {
        public Guid ID { get; set; }
        public string GroupName { get; set; }
    }
}
