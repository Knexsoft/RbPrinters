using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class User : IBaseEntity
    {
        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string MoblieAlt { get; set; }
        public string EmailID { get; set; }
        public string HashPassword { get; set; }
        public string PasswordSalt { get; set; }
        public DateTime CreateOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
         
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
