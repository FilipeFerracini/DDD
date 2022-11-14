using Microsoft.EntityFrameworkCore;
using Modelo.Domain.Entity;
using Modelo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext _context;

        public BaseRepository(DbContext context)
        {
            _context = context;
        }


        public void Delete(TEntity entity) => _context.Remove<TEntity>(entity);

        public virtual IEnumerable<TEntity> GetAll()
        {
            var query = _context.Set<TEntity>();
            if (query.Any())
                return query.ToList();
            return new List<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            var query = _context.Set<TEntity>().Where(e => e.Id == id);
            if (query.Any())
                return query.FirstOrDefault();

            return null;
        }

        public void Insert(TEntity entity) => _context.Add<TEntity>(entity);

        public void Update(TEntity entity) => _context.Update<TEntity>(entity);
    }
}
