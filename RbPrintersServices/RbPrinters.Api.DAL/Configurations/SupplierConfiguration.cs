using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public SupplierConfiguration(EntityTypeBuilder<Supplier> builder)
        {
            Configure(builder);
        }
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(10).IsRequired();
            builder.Property(x => x.Home).HasMaxLength(10);
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.EmailID).HasMaxLength(100);
            builder.Property(x => x.EmailID).HasMaxLength(20);
            builder.Property(x => x.IFSCNumber).HasMaxLength(15);
            builder.Property(x => x.AccountName).HasMaxLength(100);
            builder.Property(x => x.Address).HasMaxLength(200);
            builder.Property(x => x.Pincode).HasMaxLength(6);
            builder.Property(x => x.Comment).HasMaxLength(300);
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasMany(x => x.WeddingCards).WithOne(x => x.Supplier);
        }
    }
}
