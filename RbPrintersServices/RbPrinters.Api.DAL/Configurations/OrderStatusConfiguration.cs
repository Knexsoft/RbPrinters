using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public OrderStatusConfiguration(EntityTypeBuilder<OrderStatus> builder)
        {
            Configure(builder);
        }
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasIndex(x => x.Status).IsUnique();
            builder.Property(x => x.Status).HasMaxLength(50).IsRequired();
            builder.HasIndex(x => x.Color).IsUnique();
            builder.Property(x => x.Color).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(300);

            builder.HasMany(x => x.WeddingCardOrders).WithOne(x => x.OrderStatus);
            builder.HasMany(x => x.Orders).WithOne(x => x.OrderStatus);
        }
    }
}
