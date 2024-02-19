
namespace aspCake.Data.Repository.BaseRepo
{
    public interface IBaseRepository<T>
    {
        Task InsertData(T entity);
        void UpdateData(T entity, object id);
        Task<List<T>> GetAllDataAsync();
        Task<T> GetDataAsync(object id);
        Task DeleteData(object id);
        IQueryable<T> QueryData();
        Task SaveDataAsync();
    }
}