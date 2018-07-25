using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class WeddingCardConfiguration : IEntityTypeConfiguration<WeddingCard>
    {
        public WeddingCardConfiguration(EntityTypeBuilder<WeddingCard> builder)
        {
            Configure(builder);
        }

        public void Configure(EntityTypeBuilder<WeddingCard> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.SupplierID).IsRequired();
            builder.HasIndex(x => x.CardNumber).IsUnique();
            builder.Property(x => x.CardNumber).HasMaxLength(15).IsRequired();
            builder.Property(x => x.TotalCards).IsRequired();
            builder.Property(x => x.Rate).IsRequired();
            builder.Property(x => x.PurchaseDate).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired();
            builder.Property(x => x.IsDeleted).IsRequired();

            builder.HasOne(x => x.Supplier).WithMany(x => x.WeddingCards).HasForeignKey(wc => wc.SupplierID);
            builder.HasMany(x => x.WeddingCardOrders).WithOne(x => x.WeddingCard);
        }
    }
}
