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
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();

            builder.Property(a => a.AuthorName).HasMaxLength(100).IsRequired();
            builder.Property(a => a.AuthorEmail).HasMaxLength(100).IsRequired();
            builder.Property(a => a.Description).HasMaxLength(400).IsRequired();

            builder.HasMany(a => a.SubComments).WithOne(a => a.ParentComment).HasForeignKey(a => a.ParentCommentId);
        }
    }
}
