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
    public class EfAboutDal : EfRepositoryBase<About>,IAboutDal
    {
        public EfAboutDal(DbContext context):base (context)
        {

        }
    }
}
