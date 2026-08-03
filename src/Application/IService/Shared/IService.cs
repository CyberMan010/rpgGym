using Application.Shared;

namespace Application.IService.Shared
{
    public interface IService<T> where T : class
    {
        Task<ResponseData<T>> GetByIdAsync(Guid id);
        Task<ResponseData<IEnumerable<T>>> GetAllAsync();
        Task<ResponseData<T>> AddAsync(T entity);
        Task<ResponseData<T>> UpdateAsync(T entity);
        Task<ResponseData<bool>> DeleteAsync(Guid id);
    }
}
