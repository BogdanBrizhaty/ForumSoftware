using ForumSoftware.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSoftware.DAL.Abstract
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        IDataPortion<TEntity> Get(int page, int pageSize);
        TEntity GetById(TKey id);
        void Update(TEntity item);
        void Delete(TEntity entity);
        void Create(TEntity item);
    }
}
