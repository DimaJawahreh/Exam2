using ExamProject.data;
using ExamProject.Models;
using ExamProject.service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ExamProject.Controllers
{
    public class EmployeeController : Controller
    {
        ICountryService countryService;
        IConfiguration configuration;
        IDepartmentService departmentService;
        IEmployeeService employeeService;
        public EmployeeController(IConfiguration _configuration, ICountryService _countryService, IDepartmentService _departmentService, IEmployeeService _employeeService)
        {
            configuration = _configuration;
            countryService = _countryService;
            departmentService = _departmentService;
            employeeService = _employeeService;
        }
        public IActionResult Index()
        {
            VMmodel vm = new VMmodel();
            vm.departments = departmentService.GetDepartments();
            vm.countries = countryService.GetCountries();
            return View("Index",vm);
        }
        public IActionResult SaveData(VMmodel vm)
        {
            vm.departments = departmentService.GetDepartments();
            vm.countries = countryService.GetCountries();
            string filepath = Path.Combine(Directory.GetCurrentDirectory(), configuration["FilePath"], vm.imgProfile.FileName);
            vm.imgProfile.CopyTo(new FileStream(filepath,  FileMode.Create));
            vm.employee.path = "http://localhost/ExamProject/" + "img" + "/" + vm.imgProfile.FileName;
            if (ModelState.IsValid == true)
            {
                employeeService.Save(vm.employee);
            }
            return View("Index", vm);
        }
        public IActionResult list()
        {
            List<Department>departments= departmentService.GetDepartments();

            return View("UserInterface",departments);
        }
        public IActionResult EmployeeList()
        {
            List<Department> departments = departmentService.GetDepartments();
            List<Employee> employees = employeeService.GetEmployees();
            ViewData["isfull"] = true;
            ViewData["employee"] = employees;
            return View("UserInterface",departments);
        }

    }
}
