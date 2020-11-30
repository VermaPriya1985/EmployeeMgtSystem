using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EmploymentSystemMvc.Models;
using EmployeeSystem.Models;
using EmployeeSystem;
namespace EmploymentSystemMvc.Controllers
{
    public class EmployeeController : Controller
    {
        
        private EmployeeManagement _employee;
        public EmployeeController(EmployeeManagement employee)
        {
            _employee = employee;
        }

        // Get Employee/Index to get all employees 
        public IActionResult Index()
        {
            List<Employee> employee = _employee.GetAllEmployee();
            return View(employee);
        }

        public IActionResult Details(Guid id) 
        {
            var employee = _employee.GetByEmployeeId(id);

            return View(employee);
        }

        public IActionResult Edit(Guid id) 
        {
            // Get the employee from the EmployeeManagement
            var employee = _employee.GetByEmployeeId(id);

            // build the view model
            var employeeViewModel = new EmployeeViewModel() 
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                //HolidayName = holiday.HolidayName,
                //Comments = holiday.Comments
            };


            // send the view model
            ViewBag.IsEditing = true;
            return View("Form", employeeViewModel);
        } 

        public IActionResult Form() 
        {
            ViewBag.IsEditing = false;
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(EmployeeViewModel newEmployee) 
        {
            if(ModelState.IsValid) 
            {
                var employeeToCreate = new Employee() 
                {
                    FirstName = newEmployee.FirstName,
                    LastName = newEmployee.LastName,
                    EmployeeId = Guid.NewGuid()
                     
                };
                _employee.AddNewEmployee(employeeToCreate);
                return RedirectToAction("Index");
            } 
            else 
            {
                return View("Form", newEmployee);
            }
        }

        [HttpPost]
        public IActionResult Update(EmployeeViewModel updatedEmployee) 
        {
            if (ModelState.IsValid) 
            {
                var employee = new Employee() 
                {
                    FirstName = updatedEmployee.FirstName,
                    LastName = updatedEmployee.LastName,
                    EmployeeId = updatedEmployee.EmployeeId.Value
                };
                // _employee.AddNewHoliday(holiday);
                _employee.UpdateEmployee(employee);
                return RedirectToAction("Index");
            } 
            else 
            {
                ViewBag.IsEditing = true;
                return View("Form", updatedEmployee);
            }

        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
