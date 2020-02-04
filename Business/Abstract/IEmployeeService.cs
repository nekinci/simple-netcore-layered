using Core.Interface;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEmployeeService: IService
    {
        Employee GetOneByName(string name);
        Employee GetOneById(int id);
        List<Employee> GetAll();
    }
}
