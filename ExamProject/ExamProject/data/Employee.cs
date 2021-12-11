using ExamProject.helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.data
{[Table("Employees")]
    public class Employee
    {
        public int id { set; get; }
        [Required]
        [RegularExpression(@"(07(8|9|7))\d{7}")]
        public string phone { set; get; }
        [Required]

        public string Name { set; get; }
        [Required]
        [EmailAddress]
        public string Email { set; get; }
        [BDateValidation]
        public DateTime date { set; get; }
        public string path { set; get; }
        [ForeignKey("country")]
        public int country_id { set; get; }
        public Country country { set; get; }
        [ForeignKey("department")]
        public int department_id { set; get; }
        public Department department { set; get; }
    }
}
