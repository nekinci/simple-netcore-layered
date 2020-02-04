using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Interface;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    public class EmployeesController : Controller
    {

        private readonly IEmployeeService _employeeManager;
        public EmployeesController(IEmployeeService employeeManager)
        {
            _employeeManager = employeeManager;
        }

        public IEnumerable<Employee> Get()
        {
            return _employeeManager.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("{id}")]
        public Employee Get(int id)
        {
            return _employeeManager.GetOneById(id);
        }

    }
}
