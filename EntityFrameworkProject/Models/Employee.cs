using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkProject.Models
{
    public class Employee : BaseEntity
    {
        [Required(ErrorMessage = "Fullname can't be empty")]
        
        public string FullName { get; set; }
        [Required(ErrorMessage = "Age can't be empty")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Position can't be empty")]
        public string Position { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
