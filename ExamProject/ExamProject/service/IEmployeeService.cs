using ExamProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.service
{
 public   interface IEmployeeService
    {
        void Save(Employee employee);
        List<Employee> GetEmployees();
    }
}
