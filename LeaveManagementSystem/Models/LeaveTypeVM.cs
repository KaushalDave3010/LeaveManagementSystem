using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagementSystem.Models
{
    public class DetailsLeaveTypeVM
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime DataCreated { get; set; }
    }

    public class CreateLeaveTypeVM
    {
        
        [Required]
        public string Name { get; set; }
    }
}
