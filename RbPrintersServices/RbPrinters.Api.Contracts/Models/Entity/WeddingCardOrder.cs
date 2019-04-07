using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class WeddingCardOrder : IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid OrderID { get; set; }
        public Guid OrderStatusID { get; set; }
        public Guid WeddingCardID { get; set; }
        public int TotalCards { get; set; }
        public int TotalPrint { get; set; }
        public int TotalColor { get; set; }
        public decimal Rate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Comment { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Order Order { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual WeddingCard WeddingCard { get; set; }
    }
}
