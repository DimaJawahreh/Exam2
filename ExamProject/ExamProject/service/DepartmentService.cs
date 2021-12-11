using ExamProject.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.service
{
    public class DepartmentService:IDepartmentService
    {
        HRContext context;
        public DepartmentService(HRContext _context)
        {
            context = _context;
        }
        public  List<Department> GetDepartments()
        {
            List<Department> departments = context.departments.ToList();
            return departments;
        }
    }
}
