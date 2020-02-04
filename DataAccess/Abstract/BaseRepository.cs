using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public abstract class BaseRepository<T>:IRepository<T> where T: class
    {
        private readonly Context _context;
        private readonly DbSet<T> _table;
        public BaseRepository(Context context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _table.Add(entity);
        }

        public T Get(int id)
        {
            return _table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _table;
        }

        public void Update(T entity)
        {
            _table.Update(entity);
        }
    }
}
