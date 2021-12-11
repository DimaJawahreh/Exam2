using ExamProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.service
{
  public  interface IDepartmentService
    {
        List<Department> GetDepartments();
    }
}
