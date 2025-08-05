using AutoMapper;
using FitnessTracker.Domain.Interfaces.Repositories;
using FitnessTracker.Services.Abstractions;

namespace FitnessTracker.Services.Abstract
{
    internal abstract class BaseService<TEntity, TDto> : IBaseService<TDto>
    where TEntity : class
    where TDto : class
    {
        protected readonly IBaseRepository<TEntity> _repository;
        protected readonly IMapper _mapper;

        protected BaseService(IBaseRepository<TEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public virtual async Task<TDto?> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity != null ? _mapper.Map<TDto>(entity) : null;
        }

        public virtual async Task<IEnumerable<TDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TDto>>(entities);
        }

        public virtual async Task<TDto> AddAsync(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            await _repository.AddAsync(entity);
            return _mapper.Map<TDto>(entity);
        }

        public virtual async Task UpdateAsync(int entityId, TDto dto)
        {
            var oldEntity = await _repository.GetByIdAsync(entityId);
            _mapper.Map(dto, oldEntity);

            await _repository.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            if (entity != null)
            {
                await _repository.DeleteAsync(entity);
            }
        }

        public virtual async Task<bool> ExistsAsync(int id)
        {
            return await _repository.ExistsAsync(id);
        }
    }


}
