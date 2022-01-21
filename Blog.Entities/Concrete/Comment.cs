using Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    public class Comment:IEntity
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public string AuthorEmail { get; set; }
        public string Description { get; set; }
        public DateTime PostedTime { get; set; } = DateTime.Now;

        public int? ParentCommentId { get; set; }
        public Comment ParentComment { get; set; }

        public List<Comment> SubComments { get; set; }
        public int ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
