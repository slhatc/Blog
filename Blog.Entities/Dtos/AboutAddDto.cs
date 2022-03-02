using Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Dtos
{
    public class AboutAddDto:IDto
    {
        public string Title { get; set; }
        public string Detail { get; set; }
        public string ImageUrl { get; set; }
    }
}
