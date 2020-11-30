using System;
namespace EmployeeSystem.Models  
{
    public class Concern
    {

        /* public Concern(long concernid,long employeeid, 
        DateTime concerndate,string concerntype,string remarks,
        string concernstatus,int status)  
        {
            ConcernId = concernid;
            EmployeeId= employeeid;
            ConcernDate=concerndate;
            ConcernType=concerntype;
            Remarks=remarks;
            ConcernStatus=concernstatus;
            Status=status;
        }
        
        // Data Members
        public long ConcernId { get; }
        public long EmployeeId { get; }
        public DateTime ConcernDate { get; private set; }
        public string ConcernType { get; private set; }
        public string Remarks { get; private set; }
        public string ConcernStatus { get; private set; }
        public int Status { get; private set; }
        */

        // Data Members
        public Guid ConcernId { get; set;}
        public long EmployeeId { get;set; }
        public DateTime ConcernDate { get;  set; }
        public string ConcernType { get;  set; }
        public string Remarks { get;  set; }
        public string ConcernStatus { get;  set; }
        // public int Status { get; set; }


    }
}