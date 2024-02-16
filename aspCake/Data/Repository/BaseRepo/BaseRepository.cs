using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aspCake.Models;

namespace aspCake.Data.Repository.BaseRepo
{
    public class BaseRepository<ClassInstance> : IBaseRepository<ClassInstance> where ClassInstance : class, new()
    {
        private readonly BcakesContext _dbContext;
        public BaseRepository(BcakesContext _db){
            _dbContext = _db;
        }

        public async Task InsertData(ClassInstance entity){
            await _dbContext.Set<ClassInstance>().AddAsync(entity);
        }

        public async Task<List<ClassInstance>> GetAllDataAsync(){
            var entities = await _dbContext.Set<ClassInstance>().ToListAsync();
            return entities;
        }

        public async Task<ClassInstance> GetDataAsync(object id){
            var entity = await _dbContext.Set<ClassInstance>().FindAsync(id);
            return entity;
        }

        public void UpdateData(ClassInstance entity){
            _dbContext.Entry(entity).State = EntityState.Modified;
        }

        public void DeleteData(ClassInstance entity){
            _dbContext.Set<ClassInstance>().Remove(entity);
        }

        public async Task SaveDataAsync(){
            await _dbContext.SaveChangesAsync();
        }

        public IQueryable<ClassInstance> QueryData(){
            var entity = _dbContext.Set<ClassInstance>().AsQueryable();
            return entity;
        }

    }
}