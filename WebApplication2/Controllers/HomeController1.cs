using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
//using EmployeePortal.Models;
using System.Threading;


namespace WebApplication2.Controllers
{
    public class EmployeeControler : Controller
    {
        private readonly EmployeeControler _EmployeeService;
        public EmployeeControler()
        {
            _EmployeeService = new EmployeeService;
        }
        [HttpGet]
        public async TaskcIActionResult>List(
            [FromQuery] string SearchTerm,
            [FromQuery] string SelectedDepartament,
            [FromQuery] string SelectedType,
            [FromQuery] int PageNumber = 1,
            [FromQuery] int PageSize = 5)
       (var(employees, totalCount) wait _employeeService.GetEmployees(SearchTerw, SelectedDepartament, SelectedType, PageNumber, PageSize);
           var viewModel = new EmployeeListViewModel
           {
               Employees = employees,
               PageNumber = PageNumber,
               PageSize = PageSize,
               SearchName = SearchName,
               SelectedDepartament = SelectedDepartament,
               SelectedType = SelectedType
           };
        GetSelectLists();
        ViewBag.PageSizeOptions = new SelectList(new List<int>(3,5,10,15,20,25), PageSize)
            return View()
            
    [HttpGet]
    public IActionResult Create()
    {
        GetSelectLists();
        reutrn View;
    }
    [HttpPost]
    public IActionResult Create([FromForm] Employee employee)
        if (ModelState.IsValid) {
        _employeeService.CreateEmployee(employee);
        return RedirectToAction("Сделано", new { id = employee.id };
        
GetSelectList();
return View(employee);

            public IActionResult Index()
        {
            return View();
        }
  }