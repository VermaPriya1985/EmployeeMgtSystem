using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeSystem.Models;
namespace EmployeeSystem.Storage
{
    public class LeaveStorageList : IStoreLeave
    {
        private readonly List<Leave> _leaveList;
        
        // Constructor
        public LeaveStorageList()
        {
            _leaveList = new List<Leave>();
        }

        // Methods
        public void Mark(Leave newLeave)
        {
            _leaveList.Add(newLeave);
        }
        
        public string Approve(Guid leaveid, string leavestatus)
        {
             return  "Leave has been " + leavestatus;
             // return  "Leave has been " + leavestatus + "with leave id: " + leaveid;
             // return _leaveList.Where(x => x.LeaveId ==  == employeename.ToLower()).ToList();
             

        }

         public Leave GetById(Guid leaveid) {
         var leave = _leaveList.Find(x => x.LeaveId == leaveid);

            if (leave == null) 
            {
                throw new Exception($"leave {leaveid} does not exist!!");
            }

            return leave;
        }
        public void Update(Leave updateLeave) 
         {
            var leave = GetById(updateLeave.LeaveId);
            leave.FromDate = updateLeave.FromDate;
            leave.ToDate = updateLeave.ToDate;
            leave.LeaveType = updateLeave.LeaveType;
            leave.Reason = updateLeave.Reason;
            leave.LeaveStatus = updateLeave.LeaveStatus;
        }

        public List<Leave> GetAll()
        {
            return _leaveList;
        }
    }
}


