using System;
namespace EmployeeSystem.Storage.EFModels  
{
    public class Holiday
    {

        
        public Guid HolidayId { get;set; }
        public DateTime FromDate { get;  set; }
        public DateTime ToDate { get;  set; }
        public string HolidayName { get;  set; }
        public string Comments { get;  set; }
        
    
    }
}