using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstract
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        IAboutDal Abouts { get; }
        IArticleDal Articles { get; }
        ICategoryDal Categories { get; }
        ICommentDal Comments { get; }
        IContactDal Contacts { get; }
        IImageDal Images { get; }
        IUserDal Users { get; }
        IVideoDal Videos { get; }

        Task<int> SaveAsync();

    }
}
