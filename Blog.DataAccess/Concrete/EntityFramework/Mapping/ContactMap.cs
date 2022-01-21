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
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(a => a.Adres).HasMaxLength(100);
            builder.Property(a => a.Email).HasMaxLength(50);
            builder.Property(a => a.Tel).HasMaxLength(11);
            builder.Property(a => a.InstagramUrl).HasMaxLength(500);
            builder.Property(a => a.LinkedinUrl).HasMaxLength(500);
            builder.Property(a => a.YoutubeUrl).HasMaxLength(500);
            builder.Property(a => a.TwitterUrl).HasMaxLength(500);
        }
    }
}
