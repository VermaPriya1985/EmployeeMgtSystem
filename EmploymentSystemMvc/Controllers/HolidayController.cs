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
    public class HolidayController : Controller
    {
        
        private EmployeeManagement _employee;
        public HolidayController(EmployeeManagement employee)
        {
            _employee = employee;
        }

        // Get Holiday/Index to get all holidays 
        public IActionResult Index()
        {
            List<Holiday> holiday = _employee.GetAllHoliday();
            return View(holiday);
        }

        public IActionResult Edit(Guid id) 
        {
            // Get the holiday from the EmployeeManagement
            var holiday = _employee.GetById(id);
            
            // build the view model
            var holidayViewModel = new HolidayViewModel() 
            {
                FromDate = holiday.FromDate,
                ToDate = holiday.ToDate,
                HolidayName = holiday.HolidayName,
                Comments = holiday.Comments,
                HolidayId = id 
            };


            // send the view model
            ViewBag.IsEditing = true;
            return View("Form", holidayViewModel);
        }

        public IActionResult Form() 
        {
            ViewBag.IsEditing = false;
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(HolidayViewModel newHoliday) 
        {
            if(ModelState.IsValid) 
            {
                var holidayToCreate = new Holiday() 
                {
                    FromDate = newHoliday.FromDate,
                    ToDate = newHoliday.ToDate,
                    HolidayName = newHoliday.HolidayName,
                    Comments = newHoliday.Comments,
                    HolidayId = Guid.NewGuid()
                     
                };
                _employee.AddNewHoliday(holidayToCreate);
                return RedirectToAction("Index");
            } 
            else 
            {
                return View("Form", newHoliday);
            }
        }

        [HttpPost]
        public IActionResult Update(HolidayViewModel updatedHoliday) 
        {
            if (ModelState.IsValid) 
            {
                var holidayToUpdate = new Holiday() 
                 {
                    FromDate = updatedHoliday.FromDate,
                    ToDate = updatedHoliday.ToDate,
                    HolidayName = updatedHoliday.HolidayName,
                    Comments = updatedHoliday.Comments,
                    HolidayId = updatedHoliday.HolidayId.Value
                    // HolidayId = updatedHoliday.HolidayId.Value
                 };
                // _employee.AddNewHoliday(holiday);
                _employee.UpdateHoliday(holidayToUpdate);
                return RedirectToAction("Index");
            } 
            else 
            {
                ViewBag.IsEditing = true;
                return View("Form", updatedHoliday);
            }

        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
