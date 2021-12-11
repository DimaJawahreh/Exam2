using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.data
{[Table("Countries")]
    public class Country

    {
        public int id { set; get; }
        public string Name { set; get; }
        public List<Employee> employees { set; get; }
    }
}
