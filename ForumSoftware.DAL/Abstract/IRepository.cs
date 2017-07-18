using ForumSoftware.Crosscutting;
using System;

namespace ForumSoftware.DAL.Abstract
{
    public interface IRepository<TEntity, TKey> : IDisposable where TEntity : class
    {
        IDataPortion<TEntity> GetMany(int page, int pageSize, Ordering<TEntity> order);
        TEntity GetById(TKey id);
        void Update(TEntity item);
        void Delete(TEntity entity);
        void Create(TEntity item);
    }
}
