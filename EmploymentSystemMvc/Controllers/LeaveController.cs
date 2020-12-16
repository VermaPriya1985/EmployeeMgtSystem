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

        public IActionResult Edit(Guid id) 
        {
            // Get the holiday from the EmployeeManagement
            var leave = _employee.GetByLeaveId(id);
            
            // build the view model
            var leaveViewModel = new LeaveViewModel() 
            {
                FromDate = leave.FromDate,
                ToDate = leave.ToDate,
                LeaveType = leave.LeaveType,
                Reason = leave.Reason,
                LeaveStatus = leave.LeaveStatus,
                LeaveId = id 
            };


            // send the view model
            ViewBag.IsEditing = true;
            return View("Form", leaveViewModel);
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
               /*  var leaveToCreate = new Leave() 
                {
                    FromDate = newLeave.FromDate,
                    ToDate = newLeave.ToDate,
                    LeaveType = newLeave.LeaveType,
                    Reason = newLeave.Reason,
                    LeaveStatus = "Pending",
                    // LeaveStatus = newLeave.LeaveStatus,
                    LeaveId = Guid.NewGuid()
                     
                };
                _employee.Mark(leaveToCreate);
                */
                
                return RedirectToAction("Index");
            } 
            else 
            {
                return View("Form", newLeave);
            }
        }

        [HttpPost]
        public IActionResult Update(LeaveViewModel updatedLeave) 
        {
            if (ModelState.IsValid) 
            {
               /*  var leaveToUpdate = new Leave() 
                 {
                    FromDate = updatedLeave.FromDate,
                    ToDate = updatedLeave.ToDate,
                    LeaveType = updatedLeave.LeaveType,
                    Reason = updatedLeave.Reason,
                    LeaveStatus = "Pending",
                    LeaveId = updatedLeave.LeaveId.Value
                    
                 };
                
                _employee.UpdateLeave(leaveToUpdate);
                */
                
                return RedirectToAction("Index");
            } 
            else 
            {
                ViewBag.IsEditing = true;
                return View("Form", updatedLeave);
            }

        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
