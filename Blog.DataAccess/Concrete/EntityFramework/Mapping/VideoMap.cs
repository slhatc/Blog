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
    public class VideoMap : IEntityTypeConfiguration<Video>
    {
        public void Configure(EntityTypeBuilder<Video> builder)
        {
            builder.HasKey(a => a.VideoId);
            builder.Property(a => a.VideoId).ValueGeneratedOnAdd();
            builder.Property(a => a.Description).HasMaxLength(100);
            builder.Property(a => a.VideoText).HasColumnType("NVARHAR(MAX)");
            builder.Property(a => a.VideoUrl).HasMaxLength(500);
        }
    }
}
