using Blog.Entities.Concrete;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IAboutService
    {
        Task<About> GetAsync(int id);
        Task<About> AddAsync(AboutAddDto aboutAddDto);

        Task<About> UpdateAsync(AboutUpdateDto aboutUpdateDto);
    }
}
