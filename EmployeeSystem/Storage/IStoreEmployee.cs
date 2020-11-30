using System;
using System.Collections.Generic;
using EmployeeSystem.Models;  
namespace EmployeeSystem.Storage
{
    public interface IStoreEmployee
    {
        void Create(Employee newEmployee);
        List<Employee> GetByName(string employeename);
        List<Employee> GetAll();
        Employee GetById(Guid employeeid);
        void Update(Employee updateEmployee);

    }
}
