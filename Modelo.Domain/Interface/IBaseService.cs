using FluentValidation;
using Modelo.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain.Interface
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Insert<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update<TValidator>(TEntity obj) where TValidator : AbstractValidator<TEntity>;
    }
}
