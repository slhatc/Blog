﻿using Blog.DataAccess.Abstract;
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
    public class EfContactDal:EfRepositoryBase<Contact>,IContactDal
    {
        public EfContactDal(DbContext context):base (context)
        {

        }
    }
}
