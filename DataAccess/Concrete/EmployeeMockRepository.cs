using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class EmployeeMockRepository : IEmployeeRepository
    {

        private readonly List<Employee> _employees;
        public EmployeeMockRepository()
        {
            _employees = new List<Employee>
            {
                new Employee
                {
                    Id=1,
                    Name="Niyazi"
                },
                new Employee
                {
                    Id=2,
                    Name="Ahmet"
                },
                new Employee
                {
                    Id=3,
                    Name="Kobe"
                },
                new Employee
                {
                    Id=4,
                    Name="Bryant"
                },
                new Employee
                {
                    Id=5,
                    Name="Halil"
                }
            };
        }

        public void Add(Employee entity)
        {
            _employees.Add(entity);
        }

        public Employee Get(int id)
        {
            return _employees.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }

        public Employee GetOneByName(string name)
        {
            return _employees.Where(x => x.Name == name).FirstOrDefault();
        }

        public void Update(Employee entity)
        {
           
        }
    }
}
