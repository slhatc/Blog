using AutoMapper;
using Blog.Business.Abstract;
using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;
using Blog.Shared.Utilities.Results.ComplexTypes;
using Blog.Shared.Utilities.Results.Concrete;
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
        private readonly IMapper _mapper;
        public AboutManager(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<About> AddAsync(AboutAddDto aboutAddDto)
        {
            var about =  _mapper.Map<About>(aboutAddDto);
            var result = await _unitOfWork.Abouts.AddAsync(about);
            await _unitOfWork.SaveAsync();
            return result;
        }

        public async Task<About> GetAsync(int id)
        {
            var result = await _unitOfWork.Abouts.GetAsync(x=>x.Id==id);
            return result;
        }

        public async Task<About> UpdateAsync(AboutUpdateDto aboutUpdateDto)
        {
            var about = _mapper.Map<About>(aboutUpdateDto);
            var result = await _unitOfWork.Abouts.UpdateAsync(about);
            await _unitOfWork.SaveAsync();
            return result;
        }
    }
}
