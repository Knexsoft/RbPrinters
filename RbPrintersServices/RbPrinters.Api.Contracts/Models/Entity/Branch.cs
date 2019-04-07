using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class Branch : IBaseEntity
    {
        public Guid ID { get; set; }
        public string BranchName { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string MobileAlt { get; set; }
        public string Phone { get; set; }
        public string EmailID { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
