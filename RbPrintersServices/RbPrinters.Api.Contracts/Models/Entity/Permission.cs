using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class Permission : IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid BranchID { get; set; }
        public Guid UserRoleID { get; set; }
        public string Comments { get; set; }
          
        public virtual User User { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual UserRole UserRole { get; set; }
        //public virtual ICollection<PermissionGroup> PermissionGroups { get; set; }
    }
}
