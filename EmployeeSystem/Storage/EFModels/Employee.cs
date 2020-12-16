using System;
namespace EmployeeSystem.Storage.EFModels  
{
    public class Employee
    {

        
        // Data Members
        public Guid EmployeeId { get;  set;}
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string Gender { get;  set; }
        public string Address { get;  set; }
        public string Qualification { get;  set; }
        public string Experience { get;  set; }
        public string MobileNo { get;  set; }
        public DateTime DateofBirth { get;  set; }
        public DateTime DateofJoining { get;  set; }
        public string Designation { get;  set; }
        public string EmploymentType { get;  set; }
        
    }
}