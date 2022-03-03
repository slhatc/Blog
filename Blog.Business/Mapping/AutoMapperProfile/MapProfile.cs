using AutoMapper;
using Blog.Entities.Concrete;
using Blog.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AboutAddDto, About>();
            CreateMap<AboutUpdateDto, About>();
        }
    }
}
