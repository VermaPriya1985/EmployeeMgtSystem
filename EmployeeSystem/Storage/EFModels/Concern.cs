using System;
namespace EmployeeSystem.Storage.EFModels  
{
    public class Concern
    {

        
        // Data Members
        public Guid ConcernId { get; set;}
        // public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public DateTime ConcernDate { get;  set; }
        public string ConcernType { get;  set; }
        public string ConcernRemarks { get;  set; }
        public string ConcernStatus { get;  set; }
        


    }
}