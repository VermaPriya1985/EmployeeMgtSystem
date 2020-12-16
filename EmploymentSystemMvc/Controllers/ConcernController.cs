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
    public class ConcernController : Controller
    {
        
        private EmployeeManagement _employee;
        public ConcernController(EmployeeManagement employee)
        {
            _employee = employee;
        }

        // Get Holiday/Index to get all holidays 
        public IActionResult Index()
        {
            List<Concern> concern = _employee.GetAllConcern();
            return View(concern);
        }

        public IActionResult Edit(Guid id) 
        {
            // Get the concern from the EmployeeManagement
            var concern = _employee.GetByConcernId(id);

            // build the view model
            var concernViewModel = new ConcernViewModel() 
            {
                // ConcernDate = concern.ConcernDate,
                ConcernType = concern.ConcernType,
                ConcernRemarks = concern.ConcernRemarks,
                ConcernStatus = concern.ConcernStatus,
                ConcernId = id
            };

            // send the view model
            ViewBag.IsEditing = true;
            return View("Form", concernViewModel);
        } 

        public IActionResult Form() 
        {
            ViewBag.IsEditing = false;
            return View();
        }
        
          /* _employee.AddNewConcern(Guid.NewGuid(),newConcern.EmployeeId,
                newConcern.ConcernDate, newConcern.ConcernType,newConcern.ConcernRemarks,newConcern.ConcernStatus);
                return RedirectToAction("Index", "Book");
                */

        [HttpPost]
        public IActionResult Create(ConcernViewModel newConcern) 
        {
            if(ModelState.IsValid) 
            {
              

                var concernToCreate = new Concern() 
                {
                    ConcernId = Guid.NewGuid(),
                    // EmployeeId = newConcern.EmployeeId, 
                    // Guid.NewGuid(),
                    // newConcern.EmployeeId,
                    ConcernDate = DateTime.Now,
                    // newConcern.ConcernDate, 
                    ConcernType = newConcern.ConcernType,
                    ConcernRemarks = newConcern.ConcernRemarks,
                    ConcernStatus = newConcern.ConcernStatus
                    
                     
                };
                _employee.AddNewConcern(concernToCreate); 
                
                return RedirectToAction("Index");
            } 
            else 
            {
                return View("Form", newConcern);
            }
        }

        [HttpPost]
        public IActionResult Update(ConcernViewModel updatedConcern) 
        {
            if (ModelState.IsValid) 
            {
                var concernToUpdate = new Concern() 
                 {
                    ConcernId = updatedConcern.ConcernId.Value,
                    ConcernDate = DateTime.Now,
                    ConcernType = updatedConcern.ConcernType,
                    ConcernRemarks = updatedConcern.ConcernRemarks,
                    ConcernStatus = updatedConcern.ConcernStatus
                    
                    
                 };
                _employee.UpdateConcern(concernToUpdate);
                 return RedirectToAction("Index");
            } 
            else 
            {
                ViewBag.IsEditing = true;
                return View("Form", updatedConcern);
            }

        } 


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
