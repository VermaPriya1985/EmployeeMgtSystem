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
    public class LeaveController : Controller
    {
        
        private EmployeeManagement _employee;
        public LeaveController(EmployeeManagement employee)
        {
            _employee = employee;
        }

        // Get Holiday/Index to get all leaves 
        public IActionResult Index()
        {
            List<Leave> leave = _employee.GetAllLeave();
            return View(leave);
        }

        
        public IActionResult Form() 
        {
            ViewBag.IsEditing = false;
            return View();
        }
        
        [HttpPost]
        public IActionResult Create(LeaveViewModel newLeave) 
        {
            if(ModelState.IsValid) 
            {
                var leaveToCreate = new Leave() 
                {
                    FromDate = newLeave.FromDate,
                    ToDate = newLeave.ToDate,
                    LeaveType = newLeave.LeaveType,
                    Reason = newLeave.Reason,
                    LeaveStatus = "Pending",
                    LeaveId = Guid.NewGuid()
                     
                };
                _employee.Mark(leaveToCreate);
                return RedirectToAction("Index");
            } 
            else 
            {
                return View("Form", newLeave);
            }
        }

        /*[HttpPost]
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

        } */


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
