using ExamProject.data;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.Models
{
    public class VMmodel
    {
        public List<Department> departments { set; get; }

        public List<Country> countries { set; get; }
        public Employee employee { set; get; }
        public IFormFile imgProfile { set; get; }
    }
}
