using Blog.Entity.Concrete;
using Blog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment> 
    {
    }
}
