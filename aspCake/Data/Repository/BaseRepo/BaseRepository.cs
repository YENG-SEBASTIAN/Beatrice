using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aspCake.Models;

namespace aspCake.Data.Repository.BaseRepo
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        private readonly DbContext _dbContext;
        public BaseRepository(DbContext _db){
            _dbContext = _db;
        }

        public async Task InsertData(T entity){
            await _dbContext.Set<T>().AddAsync(entity);
        }

        public async Task<List<T>> GetAllDataAsync(){
            var entities = await _dbContext.Set<T>().ToListAsync();
            return entities;
        }

        public async Task<T> GetDataAsync(object id){
            var entity = await _dbContext.Set<T>().FindAsync(id);
            return entity;
        }

        public void UpdateData(T entity, object id){
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteData(T entity, int id){
            var entity =  await _dbContext.Set<T>().FindAsync(id);
            _dbContext.Set<T>().Remove(entity);
        }

        public async Task SaveDataAsync(){
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<T> QueryData(){
            var entity = _dbContext.Set<T>().AsQueryable();
            return entity;
        }

    }
}