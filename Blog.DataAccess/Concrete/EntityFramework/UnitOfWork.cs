using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete.EntityFramework.Context;
using Blog.DataAccess.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogContext _context;
        private EfAboutDal _aboutDal;
        private EfArticleDal _articleDal;
        private EfCategoryDal _categoryDal;
        private EfCommentDal _commentDal;
        private EfContactDal _contactDal;
        private EfImageDal _imageDal;
        private EfUserDal _userDal;
        private EfVideoDal _videoDal;

        public UnitOfWork(BlogContext context)
        {
            _context = context;
        }
        public IAboutDal Abouts => _aboutDal ?? new EfAboutDal(_context);

        public IArticleDal Articles => _articleDal ?? new EfArticleDal(_context);

        public ICategoryDal Categories => _categoryDal ?? new EfCategoryDal(_context);

        public ICommentDal Comments => _commentDal ?? new EfCommentDal(_context);

        public IContactDal Contacts => _contactDal ?? new EfContactDal(_context);

        public IImageDal Images => _imageDal ?? new EfImageDal(_context);

        public IUserDal Users => _userDal ?? new EfUserDal(_context);

        public IVideoDal Videos => _videoDal ?? new EfVideoDal(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
