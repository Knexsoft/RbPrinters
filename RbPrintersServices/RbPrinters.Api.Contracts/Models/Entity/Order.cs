using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class Order : IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid CustomerID { get; set; }
        public Guid OrderStatusID { get; set; }
        public string OrderNumber { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
         
        public virtual Customer Customer { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<WeddingCardOrder> WeddingCardOrders { get; set; }

    }
}
