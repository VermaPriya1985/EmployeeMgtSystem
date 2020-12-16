using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
using Microsoft.EntityFrameworkCore;
namespace EmployeeSystem.Storage
{
    public class LeaveStorageEF : IStoreLeave
    {
       
        private ApplicationContext _context;
        // Constructor
        public LeaveStorageEF(ApplicationContext context)
        {
            _context = context;
        }

        // Methods
        public void Mark(Leave newLeave)
        {
            var leaveModel = ConvertToDb(newLeave);
           _context.Leave.Add(leaveModel);
           _context.SaveChanges();
       
        }
        
        public string Approve(Guid leaveid, string leavestatus)
        {
             return  "Leave has been " + leavestatus;
             // return  "Leave has been " + leavestatus + "with leave id: " + leaveid;
             // return _leaveList.Where(x => x.LeaveId ==  == employeename.ToLower()).ToList();
             

        } 

         public Leave GetById(Guid id) 
         {
            var leaveFromDb = _context.Leave
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .First(x => x.LeaveId == id);
            var leave = ConvertFromDb(leaveFromDb);
            return leave;
        }

        public void Update(Leave holidayToUpdate) 
         {
             var leaveDb = ConvertToDb(holidayToUpdate);
            _context.Leave.Update(leaveDb);
            _context.SaveChanges();
       }

        public List<Leave> GetAll()
        {
            List<Leave> results = new List<Leave>();
            var leaveFromDb = _context.Leave
                .AsNoTracking()
                // .Where(x => x.IsDeleted == false)
                .ToList();

            foreach(var leave in leaveFromDb) 
            {
                var nextLeave= ConvertFromDb(leave);
                results.Add(nextLeave);
            }

            return results;
        }

        public static Leave ConvertFromDb(EFModels.Leave leaveFromDb) 
        {
            return new Leave(
                leaveFromDb.LeaveId,
                EmployeeStorageEF.ConvertFromDb(leaveFromDb.Employee),
                leaveFromDb.FromDate,
                leaveFromDb.ToDate,
                leaveFromDb.LeaveType,
                leaveFromDb.Reason,
                leaveFromDb.LeaveStatus);
        
        }

        public static EFModels.Leave ConvertToDb(Leave leave)
         {
            return new EFModels.Leave() 
            {
                LeaveId = leave.LeaveId,
                EmployeeId = leave.Employee.EmployeeId, 
                // EmployeeStorageEF.ConvertFromDb(leave.Employee), 
                FromDate = leave.FromDate,
                ToDate = leave.ToDate,
                LeaveType = leave.LeaveType,
                Reason = leave.Reason,
                LeaveStatus = leave.LeaveStatus,
            };
        }

        
    }
}


