using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class Customer : IBaseEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string ContactPerson { get; set; }
        public string Mobile { get; set; }
        public string Home { get; set; }
        public string Phone { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public string Pincode { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
