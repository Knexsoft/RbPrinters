using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public OrderConfiguration(EntityTypeBuilder<Order> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CustomerID).IsRequired();
            builder.Property(x => x.OrderStatusID).IsRequired();
            builder.HasIndex(x => x.OrderNumber).IsUnique();
            builder.Property(x => x.OrderNumber).HasMaxLength(7).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(300);
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.Customer).WithMany(x => x.Orders).HasForeignKey(o => o.CustomerID).IsRequired();
            builder.HasOne(x => x.OrderStatus).WithMany(x => x.Orders).HasForeignKey(o => o.OrderStatusID).IsRequired();
            builder.HasMany(x => x.WeddingCardOrders).WithOne(x => x.Order).IsRequired();
        }
    }
}
