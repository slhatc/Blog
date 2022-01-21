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
    public class AboutMap : IEntityTypeConfiguration<About>
    {
        public void Configure(EntityTypeBuilder<About> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(a => a.Title).HasMaxLength(50);
            builder.Property(a=>a.Detail).HasColumnType("NVARCHAR(MAX)");
            builder.Property(a => a.ImageUrl).HasMaxLength(100);
        }
    }
}
