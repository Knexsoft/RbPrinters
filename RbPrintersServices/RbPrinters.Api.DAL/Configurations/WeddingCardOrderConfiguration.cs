using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class WeddingCardOrderConfiguration : IEntityTypeConfiguration<WeddingCardOrder>
    {
        public WeddingCardOrderConfiguration(EntityTypeBuilder<WeddingCardOrder> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<WeddingCardOrder> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.OrderID).IsRequired();
            builder.Property(x => x.OrderStatusID).IsRequired();
            builder.Property(x => x.WeddingCardID).IsRequired();
            builder.Property(x => x.TotalCards).IsRequired();
            builder.Property(x => x.TotalPrint).IsRequired();
            builder.Property(x => x.TotalColor).IsRequired();
            builder.Property(x => x.Rate).IsRequired();
            builder.Property(x => x.TotalAmount).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(300);
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.Order).WithMany(x => x.WeddingCardOrders).HasForeignKey(x => x.OrderID).IsRequired();
            builder.HasOne(x => x.OrderStatus).WithMany(x => x.WeddingCardOrders).HasForeignKey(x => x.OrderStatusID).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(x => x.WeddingCard).WithMany(x => x.WeddingCardOrders).HasForeignKey(x => x.WeddingCardID).IsRequired();
        }
    }
}
