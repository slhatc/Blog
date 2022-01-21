using Blog.DataAccess.Abstract;
using Blog.Entities.Concrete;
using Blog.Shared.Data.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework.Repositories
{
    public class EfCategoryDal:EfRepositoryBase<Category>,ICategoryDal
    {
        public EfCategoryDal(DbContext context):base (context)
        {

        }
    }
}
