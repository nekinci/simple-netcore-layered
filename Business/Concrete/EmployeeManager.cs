using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _db;

        public EmployeeManager(IEmployeeRepository db)
        {
            _db = db;
        }

        public List<Employee> GetAll()
        {
            return new List<Employee>(_db.GetAll());
        }

        public Employee GetOneById(int id)
        {
            return _db.Get(id);
        }

        public Employee GetOneByName(string name)
        {
            return _db.GetOneByName(name);
        }

    }
}
