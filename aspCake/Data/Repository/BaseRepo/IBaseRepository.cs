using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspCake.Data.Repository.BaseRepo
{
    public interface IBaseRepository<ClassInstance>
    {
        Task InsertData(ClassInstance entity);
        void UpdateData(ClassInstance entity);
        Task<List<ClassInstance>> GetAllDataAsync();
        Task<ClassInstance> GetDataAsync(object id);
        void DeleteData(ClassInstance entity);
        IQueryable<ClassInstance> QueryData();
        Task SaveDataAsync();
    }
}