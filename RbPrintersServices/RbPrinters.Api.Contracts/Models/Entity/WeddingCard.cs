using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models.Entity
{
    public class WeddingCard : IBaseEntity
    {
        public Guid ID { get; set; }
        public Guid SupplierID { get; set; }
        public string CardNumber { get; set; }
        public int TotalCards { get; set; }
        public decimal Rate { get; set; }
        public DateTime PurchaseDate { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedOn { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public Guid ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<WeddingCardOrder> WeddingCardOrders { get; set; }
    }
}
 