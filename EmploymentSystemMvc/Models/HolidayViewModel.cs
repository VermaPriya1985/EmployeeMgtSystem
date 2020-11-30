using System;
using System.ComponentModel.DataAnnotations;
namespace EmploymentSystemMvc.Models
{
    public class HolidayViewModel
    {
        public Guid? HolidayId { get; set; }

        [Required]
        public DateTime FromDate { get;  set; }

        [Required]
        public DateTime ToDate { get;  set; }

        [Required]
        [StringLength(30)]
        public string HolidayName { get;  set; }
        
        public string Comments { get;  set; }
        // public int Status { get;  set; }
    }
}
