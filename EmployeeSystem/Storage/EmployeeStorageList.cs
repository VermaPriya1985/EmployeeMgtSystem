using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class EmployeeStorageList : IStoreEmployee
    {
        private readonly List<Employee> _employeeList;
        
        // Constructor
        public EmployeeStorageList()
        {
            _employeeList = new List<Employee>();
        }

        // Methods
        public void Create(Employee newEmployee)
        {
            _employeeList.Add(newEmployee);
        }
        
         public void Update(Employee updateEmployee) 
         {
            var employee = GetById(updateEmployee.EmployeeId);
            employee.FirstName = updateEmployee.FirstName;
            employee.LastName = updateEmployee.LastName;
            
        }
        
         public Employee GetById(Guid id) 
        {
            var employee = _employeeList.Find(x => x.EmployeeId == id);

            if (employee == null) 
            {
                throw new Exception($"Employee {id} does not exist!!");
            }

            return employee;
        }

        /* public School GetById(long id)
        {
            var school = _schoolList.Find(x => x.SchoolId == id);
            if(school == null)
            {
                throw new Exception($"School {id} does not exists");
            }
            return school;
        }*/

        public List<Employee> GetByName(string employeename)
        {
            return _employeeList.Where(x => x.FullName.ToLower() == employeename.ToLower()).ToList();
    
        }

        public List<Employee> GetAll()
        {
            return _employeeList;
        }
    }
}


