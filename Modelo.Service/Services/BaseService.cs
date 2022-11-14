using FluentValidation;
using Modelo.Domain.Entity;
using Modelo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public void Delete(TEntity entity) => _baseRepository.Delete(entity);
        public IEnumerable<TEntity> GetAll() => _baseRepository.GetAll();
        public TEntity GetById(int id) => _baseRepository.GetById(id);
        public TEntity Insert<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Insert(entity);
            return entity;
        }
        public TEntity Update<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>
        {
            Validate(entity, Activator.CreateInstance<TValidator>());
            _baseRepository.Update(entity);
            return entity;
        }

        private void Validate(TEntity entity, AbstractValidator<TEntity> validator)
        {
            if (entity == null)
                throw new Exception("Registros não detectados!");

            validator.ValidateAndThrow(entity);
        }
    }
}
