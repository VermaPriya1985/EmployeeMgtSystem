using System;
namespace EmployeeSystem.Storage.EFModels  
{
    public class Leave
    {

        
        // Data Members
        public Guid LeaveId { get;set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime FromDate { get;  set; }
        public DateTime ToDate { get;  set; }
        public string LeaveType { get;  set; }
        public string Reason { get;  set; }
        public string LeaveStatus { get;  set; }
        
        
    }
}