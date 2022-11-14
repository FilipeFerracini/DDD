using Modelo.Domain.Entity;

namespace Modelo.Domain.Interface
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert (TEntity entity);
        void Update (TEntity entity);
        void Delete (TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
