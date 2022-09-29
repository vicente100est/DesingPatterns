using Microsoft.EntityFrameworkCore;
using Repository.Interface;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Class
{
    public class CRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DesignPatternsContext _context;
        private DbSet<TEntity> _dbSet;

        public CRepository(DesignPatternsContext context)
        {
            this._context = context;
            this._dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity data) => _dbSet.Add(data);

        public void Delete(int id)
        {
            var dateToDelete = _dbSet.Find(id);
            _dbSet.Remove(dateToDelete);
        }

        public IEnumerable<TEntity> Get() => _dbSet.ToList();

        public TEntity Get(int id) => _dbSet.Find(id);

        public void Save() => _context.SaveChanges();

        public void Update(TEntity data)
        {
            _dbSet.Attach(data);
            _context.Entry(data).State = EntityState.Modified;
        }
    }
}
