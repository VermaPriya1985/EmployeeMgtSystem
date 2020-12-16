using System;
using System.ComponentModel.DataAnnotations;
namespace EmploymentSystemMvc.Models
{
    public class ConcernViewModel
    {
        public Guid? ConcernId { get; set; }

        
        // public Guid EmployeeId { get; set; }

         // [Required]
        public DateTime ConcernDate { get;  set; }

        // [Required]
        public string ConcernType { get;  set; }

        [Required]
        [StringLength(30)]
        public string ConcernRemarks { get;  set; }

        [Required]
        public string ConcernStatus { get;  set; }

        
    }
}
