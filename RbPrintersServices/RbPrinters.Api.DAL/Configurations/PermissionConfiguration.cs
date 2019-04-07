using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public PermissionConfiguration(EntityTypeBuilder<Permission> builder)
        {
            Configure(builder);
        }
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.UserID).IsRequired();
            builder.Property(x => x.BranchID).IsRequired();
            builder.Property(x => x.UserRoleID).IsRequired();
            builder.Property(x => x.Comments).HasMaxLength(300);

            builder.HasOne(x => x.User).WithMany(x => x.Permissions).HasForeignKey(x => x.UserID).IsRequired();
            builder.HasOne(x => x.Branch).WithMany(x => x.Permissions).HasForeignKey(x => x.BranchID).IsRequired();
            builder.HasOne(x => x.UserRole).WithMany(x => x.Permissions).HasForeignKey(x => x.UserRoleID).IsRequired();
        }
    }
}
