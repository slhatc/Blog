using Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Blog.Entities.Concrete
{
    public class Video : IEntity 
    {
        public int VideoId { get; set; }
        public string VideoUrl { get; set; }
        public string VideoText { get; set; }
        public string Description { get; set; }
    }
}
