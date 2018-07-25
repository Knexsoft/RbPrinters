using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class BranchConfiguration : IEntityTypeConfiguration<Branch>
    {
        public BranchConfiguration(EntityTypeBuilder<Branch> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }

        public void Configure(EntityTypeBuilder<Branch> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasIndex(x => x.BranchName).IsUnique();
            builder.Property(x => x.BranchName).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Location).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Address).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Mobile).HasMaxLength(10).IsRequired();
            builder.Property(x => x.MobileAlt).HasMaxLength(10);
            builder.Property(x => x.Phone).HasMaxLength(11);
            builder.Property(x => x.EmailID).HasMaxLength(100).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.IsActive).IsRequired();

            builder.HasMany(x => x.Permissions).WithOne(x => x.Branch);
        }
    }
}
