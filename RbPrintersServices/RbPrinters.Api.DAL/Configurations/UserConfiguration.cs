using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RbPrinters.Api.Contracts.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RbPrinters.Api.DAL.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public UserConfiguration(EntityTypeBuilder<User> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(x => x.LastName).HasMaxLength(50);
            builder.HasIndex(x => x.Mobile).IsUnique();
            builder.Property(x => x.Mobile).HasMaxLength(10).IsRequired();
            builder.Property(x => x.MoblieAlt).HasMaxLength(10);
            builder.HasIndex(x => x.EmailID).IsUnique();
            builder.Property(x => x.EmailID).HasMaxLength(100);
            builder.Property(x => x.HashPassword).HasMaxLength(20).IsRequired();
            builder.Property(x => x.PasswordSalt).HasMaxLength(200).IsRequired();

            builder.HasMany(u => u.Permissions).WithOne(p => p.User);
        }
    }

    internal class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration(EntityTypeBuilder<UserRole> entityTypeBuilder)
        {
            Configure(entityTypeBuilder);
        }

        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasIndex(x => x.Role).IsUnique();
            builder.Property(x => x.Comment).HasMaxLength(300);
            builder.Property(x => x.Role).HasMaxLength(100).IsRequired();

            //builder.HasMany(x => x.Permissions).WithOne(x => x.UserRole);
        }
    }
}
