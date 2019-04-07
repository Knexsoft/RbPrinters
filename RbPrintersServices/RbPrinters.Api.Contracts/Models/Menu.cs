using RbPrinters.Api.Interfaces.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.Contracts.Models
{
    public class Menu : IBaseEntity
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Notes { get; set; }
        public virtual Menu menu { get; set; }
    } 
}
