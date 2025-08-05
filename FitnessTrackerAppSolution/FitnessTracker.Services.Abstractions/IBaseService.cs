namespace FitnessTracker.Services.Abstractions
{
    public interface IBaseService<TDto> 
        where TDto : class
    {
        Task<TDto?> GetByIdAsync(int id);
        Task<IEnumerable<TDto>> GetAllAsync();
        Task<TDto> AddAsync(TDto dto);
        Task UpdateAsync(int entityId, TDto dto);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
