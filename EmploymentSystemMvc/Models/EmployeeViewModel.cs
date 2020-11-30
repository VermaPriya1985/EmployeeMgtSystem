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
        
        
    }
}
