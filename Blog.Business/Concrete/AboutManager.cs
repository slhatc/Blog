using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IUnitOfWork _unitOfWork;
        public AboutManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<IDataResult<AboutDto>> Add(AboutAddDto aboutAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<AboutDto>> Get()
        {
            throw new NotImplementedException();
        }
    }
}
