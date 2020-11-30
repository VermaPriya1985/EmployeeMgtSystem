using System;
namespace EmployeeSystem.Models  
{
    public class Leave
    {

        /* public Leave(long leaveid, long employeeid, 
        DateTime todate,DateTime fromdate,string reason,
        string leavestatus,int status)  
        {
            LeaveId = leaveid;
            EmployeeId = employeeid;
            ToDate=todate;
            FromDate=fromdate;
            Reason=reason;
            LeaveStatus=leavestatus;
            Status=status;
        }
        
        // Data Members
        public long LeaveId { get; }
        public long EmployeeId { get; }
        public DateTime ToDate { get; private set; }
        public DateTime FromDate { get; private set; }
        public string Reason { get; private set; }
        public string LeaveStatus { get; private set; }
        public int Status { get; private set; }
        */

       // Data Members
        public Guid LeaveId { get;set; }
        public long EmployeeId { get;set; }
        public DateTime FromDate { get;  set; }
        public DateTime ToDate { get;  set; }
        public string LeaveType { get;  set; }
        public string Reason { get;  set; }
        public string LeaveStatus { get;  set; }
        // public int Status { get;  set; }
        
    }
}