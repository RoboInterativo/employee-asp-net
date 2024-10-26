using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class EmployeeListViewModel
    {
        public List<Employee> Employees { get; set; }
        public int TotalPages { get; set; }
        public string SearchTerm { get; set; }
        public string SelecteddDepartament { get; set; }
        public string SelectedType { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }

    }
}
