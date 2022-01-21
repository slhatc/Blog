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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasKey(a => a.ImageId);
            builder.Property(a => a.ImageId).ValueGeneratedOnAdd();
            builder.Property(a => a.Description).HasMaxLength(100);
            builder.Property(a => a.ImageText).HasColumnType("NVARHAR(MAX)");
            builder.Property(a => a.ImageUrl).HasMaxLength(500);
        }
    }
}
