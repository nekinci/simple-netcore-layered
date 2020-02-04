using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        
    }
}
