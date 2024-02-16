using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCake.Data.Repository.BaseRepo
{
    public interface IBaseRepository<T>
    {
        Task InsertData(T entity);
        void UpdateData(T entity);
        Task<List<T>> GetAllDataAsync();
        Task<T> GetDataAsync(object id);
        void DeleteData(T entity);
        IQueryable<T> QueryData();
        Task SaveDataAsync();
    }
}