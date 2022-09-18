using NewsProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewsProject.Core.DAL
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter);
        IList<T> GetList(Expression<Func<T, bool>> filter = null); // filtre gönderilmezse tümünü listelesin
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
