using System;
namespace EmployeeSystem.Models  
{
    public class Holiday
    {

        /* public Holiday(long holidayid, DateTime fromdate,DateTime todate,string holidayname,string comments,int status)  
        {
            HolidayId = holidayid;
            FromDate=fromdate;
            ToDate=todate;
            HolidayName=holidayname;
            Comments=comments;
            Status=status;
        }
        */

        // Data Members
        /* public long HolidayId { get; }
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public string HolidayName { get; private set; }
        public string Comments { get; private set; }
        public int Status { get; private set; }
        */

        public Guid HolidayId { get;set; }
        public DateTime FromDate { get;  set; }
        public DateTime ToDate { get;  set; }
        public string HolidayName { get;  set; }
        public string Comments { get;  set; }
        
        // public int Status { get;  set; }
    
    }
}