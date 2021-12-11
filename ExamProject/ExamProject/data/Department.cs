using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.data
{
    [Table("Departments")]
    public class Department
    {
        public int id { set; get; }
        public string DepartmentName { set; get; }
        public int MinimumSalary { set; get; }
        public int MaximumSalary { set; get; }
        public List<Employee> employees { set; get; }


    }
}
