using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTesting
{
    internal class RegexandDataannotation
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, ErrorMessage = "letters must be 10")]
        public string Name { get; set; }

        [Range(21, 100, ErrorMessage = "age must be between 21 to 100")]
        public int Age { get; set; }

        [EmailAddress(ErrorMessage ="invalid email format")]
        public string Email { get; set; }




    }
}
