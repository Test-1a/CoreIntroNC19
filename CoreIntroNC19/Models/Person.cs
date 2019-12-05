using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntroNC19.Models
{
    public class Person
    {
        public int Id { get; set; }

        [StringLength(30, ErrorMessage ="Max 30 tecken")]
        [Display(Name ="Namn")]
        [Required]
        public string Name { get; set; }

        [Range(0,100000)]
        public int Salary { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
