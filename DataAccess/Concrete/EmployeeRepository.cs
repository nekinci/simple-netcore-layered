using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        private readonly Context _context;
        private readonly DbSet<Employee> _employees;
        public EmployeeRepository(Context context) : base(context)
        {
            _context = context;
            _employees = _context.Employees;
        }
        public Employee GetOneByName(string name)
        {
            return _employees.Where(x => x.Name == name).SingleOrDefault();
        }
    }
}
