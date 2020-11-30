using System;
using System.ComponentModel.DataAnnotations;
namespace EmploymentSystemMvc.Models
{
    public class LeaveViewModel
    {
        public Guid? LeaveId { get; set; }

        [Required]
        public DateTime FromDate { get;  set; }

        [Required]
        public DateTime ToDate { get;  set; }

        public string LeaveType { get;  set; }

        [Required]
        [StringLength(30)]
        public string Reason { get;  set; }
        public string LeaveStatus { get;  set; }
        
    }
}
