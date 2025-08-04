using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services.Abstract
{
    internal abstract class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _repository;

        protected BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        public virtual async Task<T?> GetByIdAsync(int id) => await _repository.GetByIdAsync(id);

        public virtual async Task<IEnumerable<T>> GetAllAsync() => await _repository.GetAllAsync();

        public virtual async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            return entity;
        }

        public virtual async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }//TODO: Change Update logic

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                await _repository.DeleteAsync(entity);
            }
        }

        public virtual async Task<bool> ExistsAsync(int id) => await _repository.ExistsAsync(id);
    }

}
