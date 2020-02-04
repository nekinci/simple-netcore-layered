using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
namespace DataAccess.Abstract
{
    public interface IEmployeeRepository:IRepository<Employee>
    {
        public Employee GetOneByName(string name);
    }
}
