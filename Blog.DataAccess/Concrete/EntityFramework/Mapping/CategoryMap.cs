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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(a => a.CategoryId);
            builder.Property(a => a.CategoryId).ValueGeneratedOnAdd();
            builder.Property(a => a.CategoryName).HasMaxLength(50).IsRequired();
        }
    }
}
