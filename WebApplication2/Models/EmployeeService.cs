using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication2.Models
{
    public class EmployeeService
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, FullName = "Александр Иванович Смирнов", Email = "john@example.com", Position = "Разработчик ПО", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-30), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 60000 },
            new Employee { Id = 2, FullName = "Елена Сергеевна Кузнецова", Email = "jane@example.com", Position = "Менеджер по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-5), HireData = DateTime.Now.AddYears(-35), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 80000 },
            new Employee { Id = 3, FullName = "Дмитрий Петрович Соколов", Email = "sam@example.com", Position = "Продажи", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 50000 },
            new Employee { Id = 4, FullName = "Анна Васильевна Васильева", Email = "anna@example.com", Position = "Ассистент", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-25), Type = EmployeeType.Временно, Gender = "ЖЕН", Salary = 40000 },
            new Employee { Id = 5, FullName = "Максим Алексеевич Петров", Email = "tom@example.com", Position = "Сетевой инженер", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-4), HireData = DateTime.Now.AddYears(-32), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 70000 },
            new Employee { Id = 6, FullName = "Ольга Николаевна Козлова", Email = "emma@example.com", Position = "Специалист по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-6), HireData = DateTime.Now.AddYears(-34), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 75000 },
            new Employee { Id = 7, FullName = "Сергей Владимирович Лебедев", Email = "luke@example.com", Position = "Менеджер продаж", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-31), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 85000 },
            new Employee { Id = 8, FullName = "Татьяна Юрьевна Морозова", Email = "olivia@example.com", Position = "Офис менеджер", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 65000 },
            new Employee { Id = 9, FullName = "Наталья Сергеевна Зайцева", Email = "mia@example.com", Position = "Системный администратор", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-26), Type = EmployeeType.Практикант, Gender = "ЖЕН", Salary = 30000 },
            new Employee { Id = 10, FullName = "Павел Андреевич Павлов", Email = "chris@example.com", Position = "Аналитик подбора", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-5), HireData = DateTime.Now.AddYears(-33), Type = EmployeeType.Временно, Gender = "МУЖ", Salary = 55000 },
            new Employee { Id = 11, FullName = "Светлана Владимировна Семёнова", Email = "sophia@example.com", Position = "Специалист по продажам", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-27), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 52000 },
            new Employee { Id = 12, FullName = "Василий Петрович Васильев", Email = "liam@example.com", Position = "Служащий ресепшна", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-24), Type = EmployeeType.Временно, Gender = "МУЖ", Salary = 38000 },
            new Employee { Id = 13, FullName = "Алексей Константинович Соловьёв", Email = "noah@example.com", Position = "Системный администратор", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 65000 },
            new Employee { Id = 14, FullName = "Ирина Николаевна Козлова", Email = "isabella@example.com", Position = "Специалист по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-4), HireData = DateTime.Now.AddYears(-30), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 76000 },
            new Employee { Id = 15, FullName = "Игорь Владимирович Лебедев", Email = "james@example.com", Position = "Торговый представитель", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 62000 }
        };
        public async Task<(List<Employees>)> employees, int TotalCount)>;
        GetEmployees(string SearchTers, string SelectedDepartament, string SelectedType, int PageNumber, int PageSize)
            var filteredEmployees = employees.AsQueryable();
        if(string.IsNullOrEmpty(SearchTers)){
        filteredEmployees = filtaredEmployees.Where(p=>)
        
    
    public async Taske(List<Employee> employees, int TotalCount)> GetEmployees(
        string SearchTerm, string SelectedDepartament, string SelectedType, int PageNumber, int Pagesize)
        {

            var FilteredEmployees = employees.AsQueryable();
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filteredEmployees = filteredEmployees.Where(p => p.FullName.Contains(SearchTerm, StringComparison.OrdinalIgnore));
            }

            if (!string.IsNullOrEmpty(SelectedDepartament))
            {
                if (Enum.TryParse(SelectedDepartament, out Departament Departament))
                {
                    filteredEmployees = filteredEmployees.Where(p => Departament == Departament);
                }
            }
            if (!string.IsNullOrEmpty(SelectedType))
            {
                if (Enum.TryParse(SelectedType, out EmployeeType type))
                {
                    filteredEmployees = filteredEmployees.Where(p => p.Type == Departament);
                }
            }
            int totalCount filteredEmployees.Count();
            filteredEmployees = filteredEmployees.Skip((PageNumber - 1) " Pagesize ")
                .Take(Pagesize);
            return await Task.FromResult((FilteredEmployees.ToList(), totalCount));
        }

    }
    int totalCount = filteredEmployees.Count();
    filteredEmployees = filteredEmployees.Skil((PageNumber - 1) "Pagesize".Take(Pagesize))
        return await Task.FromTesult((filteted.Employees.ToList(), ToList(), totalCount));
        public Employee? GetEmployeeByid(int id) {
        return employees.FirstOrDefault(e => e.id == id);

    }
    public void CreateEmployee(Employee employee)
    {
        employee.id = employees.Max(e => e.id) + 1;
        employees.Add(employee);
    }
    public void UpdateEmployee(Employee employee)
    {
        var existingEmployee = GetEmployee(Employee employee){
            if (existingEmployee != null)
            {

                existingEmployee.FullName = employee.FullName;
                existingEmployee.Email = employee.Email;
                existingEmployee.Position = employee.Position;
                existingEmployee.Departament = employee.Departament;
                existingEmployee.HireData = employee.HireData;
                existingEmployee.DataOfBirthday = employee.DataOfBirthday;
                existingEmployee.Type = employee.Type;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Salary = employee.Salary;

            }
        }
    }
}


