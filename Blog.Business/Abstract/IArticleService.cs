using Blog.Entities.Dtos;
using Blog.Shared.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IArticleService
    {
        Task<IDataResult<ArticleListDto>> GetAll(); 
    }
}
