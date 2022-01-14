using Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blog.Entities.Concrete
{
    public class Image : IEntity
    {
        public int ImageId { get; set; }
        public string ImageUrl { get; set; }
        public string ImageText { get; set; }
        public string Description { get; set; }
    }
}
