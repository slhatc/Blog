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
        Task<IDataResult<AboutDto>> Get();
        Task<IDataResult<AboutDto>> Add(AboutAddDto aboutAddDto);
    }
}
