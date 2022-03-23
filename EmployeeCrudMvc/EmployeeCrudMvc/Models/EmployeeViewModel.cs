using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCrudMvc.Models
{
    public class EmployeeViewModel
    {
        public virtual int EmployeeId { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage ="Only Characters accept" )]
        public virtual string FirstName { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage = "Only Characters accept")]
        public virtual string LastName { get; set; }
        [Required]
        public virtual int Age { get; set; }
        public virtual bool MeritalStatus { get; set; }
        [Required]
        public virtual string Department { get; set; }
        public virtual string Gender { get; set; }
    }
}
