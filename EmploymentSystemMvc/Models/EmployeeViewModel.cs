using System;
using System.ComponentModel.DataAnnotations;
namespace EmploymentSystemMvc.Models
{
    public class EmployeeViewModel
    {
        public Guid? EmployeeId { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get;  set; }
        
        [Required]
        [StringLength(30)]
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
        [Required]
        public string Address { get;  set; }
        [Required]
        public string Qualification { get;  set; }
        [Required]
        public string Experience { get;  set; }
        [Required]
        public string MobileNo { get;  set; }
        [Required]
        public DateTime DateofBirth { get;  set; }
        [Required]
        public DateTime DateofJoining { get;  set; }
        [Required]
        public string Designation { get;  set; }
        public string EmploymentType { get;  set; }
        
    }
}
