using System;
namespace EmployeeSystem.Models  
{
    public class Employee
    {

        /* public Employee(long employeeid, string firstname,string lastname, 
        string gender, string employeecode, string address,string postalcode, 
        string qualification, string experience,string mobileno,
        string email, DateTime dateofbirth, DateTime dateofjoining, 
        string branchname,string designation,string employmenttype,
        string maritalstatus,int status)  
        {
            EmployeeId = employeeid;
            FirstName= firstname;
            LastName= lastname;
            Gender=gender;
            EmployeeCode=employeecode;
            Address=address;
            PostalCode=postalcode;
            Qualification=qualification;
            Experience=experience;
            MobileNo=mobileno;
            Email=email;
            DateOfBirth=dateofbirth;
            DateOfJoining=dateofjoining;
            BranchName=branchname;
            Designation=designation;
            EmploymentType=employmenttype;
            MaritalStatus=maritalstatus;
            Status=status;
        }
        
        // Data Members
        public long EmployeeId { get; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string FullName 
        {
            get 
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }
        // public int Age { get; private set; }
        public string Gender { get; private set; }
        public string EmployeeCode { get; private set; }
        public string Address { get; private set; }
        public string PostalCode { get; private set; }
        public string Qualification { get; private set; }
        public string Experience { get; private set; }
        public string MobileNo { get; private set; }
        public string Email { get; private set; }
        public DateTime DateOfBirth { get; private set; }
        public DateTime DateOfJoining { get; private set; }
        public string BranchName { get; private set; }
        public string Designation { get; private set; }
        public string EmploymentType { get; private set; }
        public string MaritalStatus { get; private set; }
        public int Status { get; private set; }
        */

        // Data Members
        public Guid EmployeeId { get;  set;}
        public string FirstName { get;  set; }
        public string LastName { get;  set; }
        public string FullName 
        {
            get 
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
        }
        
        public string Gender { get;  set; }
        public string EmployeeCode { get;  set; }
        public string Address { get;  set; }
        public string PostalCode { get;  set; }
        public string Qualification { get;  set; }
        public string Experience { get;  set; }
        public string MobileNo { get;  set; }
        public string Email { get;  set; }
        public DateTime DateOfBirth { get;  set; }
        public DateTime DateOfJoining { get;  set; }
        public string BranchName { get;  set; }
        public string Designation { get;  set; }
        public string EmploymentType { get;  set; }
        public string MaritalStatus { get;  set; }
        public int Status { get;  set; }
       
    }
}