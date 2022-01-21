using Blog.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(a => a.UserId);
            builder.Property(a => a.UserId).ValueGeneratedOnAdd();
            builder.Property(a => a.Name).HasMaxLength(30);
            builder.Property(a => a.SurName).HasMaxLength(30);
            builder.Property(a => a.UserName).HasMaxLength(30).IsRequired();
            builder.Property(a => a.Password).HasMaxLength(30).IsRequired();
            builder.HasMany(a => a.Articles).WithOne(a => a.User).HasForeignKey(a => a.UserId);
        }
    }
}
