using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class EmployeeStorageEF : IStoreEmployee
    {
        private ApplicationContext _context;

        public EmployeeStorageEF(ApplicationContext context) 
        {
            _context = context;
        }

        public void Create(Employee newEmployee) 
        {
            var employeeModel = ConvertToDb(newEmployee);
            _context.Employee.Add(employeeModel);
            _context.SaveChanges();
        }

        
        public void Update(Employee employeeToUpdate) 
        {
            var employeeDb = ConvertToDb(employeeToUpdate);
            _context.Employee.Update(employeeDb);
            _context.SaveChanges();
        }
        
        public Employee GetById(Guid id) 
        {
            var employeeFromDb = _context.Employee
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .First(x => x.EmployeeId == id);
            var employee = ConvertFromDb(employeeFromDb);
            return employee;
        }

        public List<Employee> GetByName(string employeename)
        {
            // return _employeeList.Where(x => x.FullName.ToLower() == employeename.ToLower()).ToList();
            var _employeeList = new List<Employee>();
            return _employeeList;
        }

        public List<Employee> GetAll() 
        {
            List<Employee> results = new List<Employee>();
            var employeeFromDb = _context.Employee
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .ToList();

            foreach(var employee in employeeFromDb) 
            {
                var nextEmployee = ConvertFromDb(employee);
                results.Add(nextEmployee);
            }

            return results;
        }

        /* public void Delete(Guid id) {
            var bookFromDb = _context.Books
                .AsNoTracking()
                .First(x => x.BookId == id);
            bookFromDb.IsDeleted = true;
            _context.Books.Update(bookFromDb);
            _context.SaveChanges();
        }*/ 

        public static Employee ConvertFromDb(EFModels.Employee employeeFromDb) 
        {
            return new Employee() 
            {
                EmployeeId = employeeFromDb.EmployeeId,
                FirstName = employeeFromDb.FirstName,
                LastName = employeeFromDb.LastName,
                Gender = employeeFromDb.Gender,
                Address = employeeFromDb.Address,
                Qualification = employeeFromDb.Qualification,
                Experience = employeeFromDb.Experience,
                MobileNo = employeeFromDb.MobileNo,
                DateofBirth = employeeFromDb.DateofBirth,
                DateofJoining = employeeFromDb.DateofJoining,
                Designation = employeeFromDb.Designation,
                EmploymentType = employeeFromDb.EmploymentType,
            };
        }

        public static EFModels.Employee ConvertToDb(Employee employee)
         {
            return new EFModels.Employee() 
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Gender = employee.Gender,
                Address = employee.Address,
                Qualification = employee.Qualification,
                Experience = employee.Experience,
                MobileNo = employee.MobileNo,
                DateofBirth = employee.DateofBirth,
                DateofJoining = employee.DateofJoining,
                Designation = employee.Designation,
                EmploymentType = employee.EmploymentType
                
            };
        }
    }
}