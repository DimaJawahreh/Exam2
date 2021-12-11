using ExamProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.service
{
    public class EmployeeService:IEmployeeService
    {
        HRContext context;
        public EmployeeService(HRContext _context)
        {
            context = _context;
        }
        public void Save(Employee employee)
        {
            context.employees.Add(employee);
            context.SaveChanges();
        }
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = context.employees.ToList();
            return employees;

        }
    }
}
