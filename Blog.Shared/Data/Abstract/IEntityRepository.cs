using Blog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<T> GetAsync(Expression<Func<T, bool>> filter);
        Task<T> GetByIdAsync(int id);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> filter);
        IQueryable<T> QueryGetList(Expression<Func<T, bool>> filter = null);

    }
}
