using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class OrderStatus : IBaseEntity
    {
        public Guid ID { get; set; }
        public string Status { get; set; }
        public string Color { get; set; }
        public string Comment { get; set; }

        public virtual ICollection<WeddingCardOrder> WeddingCardOrders { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
