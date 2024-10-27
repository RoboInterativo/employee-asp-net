namespace WebApplication2.Models

{
    public class EmployeeService
    {
        private static List<Employee> employees = new List<Employee>
        {

          // new Employee { Id = 1, FullName = "Александр Иванович Смирнов", Email = "john@example.com", Position = "Разработчик ПО", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-30), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 60000 },
          // new Employee { Id = 2, FullName = "Елена Сергеевна Кузнецова", Email = "jane@example.com", Position = "Менеджер по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-5), HireData = DateTime.Now.AddYears(-35), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 80000 },
          // new Employee { Id = 3, FullName = "Дмитрий Петрович Соколов", Email = "sam@example.com", Position = "Продажи", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 50000 },
          // new Employee { Id = 4, FullName = "Анна Васильевна Васильева", Email = "anna@example.com", Position = "Ассистент", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-25), Type = EmployeeType.Временно, Gender = "ЖЕН", Salary = 40000 },
          // new Employee { Id = 5, FullName = "Максим Алексеевич Петров", Email = "tom@example.com", Position = "Сетевой инженер", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-4), HireData = DateTime.Now.AddYears(-32), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 70000 },
          // new Employee { Id = 6, FullName = "Ольга Николаевна Козлова", Email = "emma@example.com", Position = "Специалист по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-6), HireData = DateTime.Now.AddYears(-34), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 75000 },
          // new Employee { Id = 7, FullName = "Сергей Владимирович Лебедев", Email = "luke@example.com", Position = "Менеджер продаж", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-31), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 85000 },
          // new Employee { Id = 8, FullName = "Татьяна Юрьевна Морозова", Email = "olivia@example.com", Position = "Офис менеджер", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 65000 },
          // new Employee { Id = 9, FullName = "Наталья Сергеевна Зайцева", Email = "mia@example.com", Position = "Системный администратор", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-26), Type = EmployeeType.Практикант, Gender = "ЖЕН", Salary = 30000 },
          // new Employee { Id = 10, FullName = "Павел Андреевич Павлов", Email = "chris@example.com", Position = "Аналитик подбора", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-5), HireData = DateTime.Now.AddYears(-33), Type = EmployeeType.Временно, Gender = "МУЖ", Salary = 55000 },
          // new Employee { Id = 11, FullName = "Светлана Владимировна Семёнова", Email = "sophia@example.com", Position = "Специалист по продажам", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-27), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 52000 },
          // new Employee { Id = 12, FullName = "Василий Петрович Васильев", Email = "liam@example.com", Position = "Служащий ресепшна", Departament = Departament.Администрация, HireDate = DateTime.Now.AddYears(-1), HireData = DateTime.Now.AddYears(-24), Type = EmployeeType.Временно, Gender = "МУЖ", Salary = 38000 },
          // new Employee { Id = 13, FullName = "Алексей Константинович Соловьёв", Email = "noah@example.com", Position = "Системный администратор", Departament = Departament.Отдел_ИТ, HireDate = DateTime.Now.AddYears(-3), HireData = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянно, Gender = "МУЖ", Salary = 65000 },
          // new Employee { Id = 14, FullName = "Ирина Николаевна Козлова", Email = "isabella@example.com", Position = "Специалист по персоналу", Departament = Departament.Управление_Персоналом, HireDate = DateTime.Now.AddYears(-4), HireData = DateTime.Now.AddYears(-30), Type = EmployeeType.Постоянно, Gender = "ЖЕН", Salary = 76000 },
          // new Employee { Id = 15, FullName = "Игорь Владимирович Лебедев", Email = "james@example.com", Position = "Торговый представитель", Departament = Departament.Продажи, HireDate = DateTime.Now.AddYears(-2), HireData = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender = "МУЖ", Salary = 62000 }

            new Employee { Id = 1, FullName = "Александр Иванович Смирнов", Email = "john@example.com", Position = "Разработчик", Department = Department.IT, HireDate = DateTime.Now.AddYears(-3), DateOfBirth = DateTime.Now.AddYears(-30), Type = EmployeeType.Временный, Gender = "Мужчина", Salary = 60000 },
            new Employee { Id = 2, FullName = "Елена Сергеевна Кузнецова", Email = "jane@example.com", Position = "Кадровик", Department = Department.Кадры, HireDate = DateTime.Now.AddYears(-5), DateOfBirth = DateTime.Now.AddYears(-35), Type = EmployeeType.Постоянный, Gender = "Женщина", Salary = 80000 },
            new Employee { Id = 3, FullName = "Дмитрий Петрович Соколов", Email = "sam@example.com", Position = "Ведущий продажник", Department = Department.Продажи, HireDate = DateTime.Now.AddYears(-2), DateOfBirth = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender ="Мужчина", Salary = 50000 },
            new Employee { Id = 4, FullName = "Анна Васильевна Васильева", Email = "anna@example.com", Position = "Помошник руковотеля", Department = Department.Администрация, HireDate = DateTime.Now.AddYears(-1), DateOfBirth = DateTime.Now.AddYears(-25), Type = EmployeeType.Временный, Gender = "Женщина", Salary = 40000 },
            new Employee { Id = 5, FullName = "Максим Алексеевич Петров", Email = "tom@example.com", Position = "Сетевой инженер", Department = Department.IT, HireDate = DateTime.Now.AddYears(-4), DateOfBirth = DateTime.Now.AddYears(-32), Type = EmployeeType.Постоянный, Gender = "Мужчина", Salary = 70000 },
            new Employee { Id = 6, FullName = "Ольга Николаевна Козлова", Email = "emma@example.com", Position = "Начальник кадров", Department = Department.Кадры, HireDate = DateTime.Now.AddYears(-6), DateOfBirth = DateTime.Now.AddYears(-34), Type = EmployeeType.Постоянный, Gender = "Женщина", Salary = 75000 },
            new Employee { Id = 7, FullName = "Сергей Владимирович Лебедев", Email = "luke@example.com", Position = "Продажник", Department = Department.Продажи, HireDate = DateTime.Now.AddYears(-3), DateOfBirth = DateTime.Now.AddYears(-31), Type = EmployeeType.Контракт, Gender = "Мужчина", Salary = 85000 },
            new Employee { Id = 8, FullName = "Татьяна Юрьевна Морозова", Email = "olivia@example.com", Position = "Руководитель", Department = Department.Администрация, HireDate = DateTime.Now.AddYears(-2), DateOfBirth = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянный, Gender = "Женщина", Salary = 65000 },
            new Employee { Id = 9, FullName = "Наталья Сергеевна Зайцева", Email = "mia@example.com", Position = "Сисадмин", Department = Department.IT, HireDate = DateTime.Now.AddYears(-1), DateOfBirth = DateTime.Now.AddYears(-26), Type = EmployeeType.Интерн, Gender = "Женщина", Salary = 30000 },
            new Employee { Id = 10, FullName = "Светлана Владимировна Семёнова", Email = "chris@example.com", Position = "Поиск талантов", Department = Department.Кадры, HireDate = DateTime.Now.AddYears(-5), DateOfBirth = DateTime.Now.AddYears(-33), Type = EmployeeType.Временный, Gender = "Other", Salary = 55000 },
            new Employee { Id = 11, FullName = "Светлана Владимировна Семёнова", Email = "sophia@example.com", Position = "Ведущий продажник", Department = Department.Продажи, HireDate = DateTime.Now.AddYears(-2), DateOfBirth = DateTime.Now.AddYears(-27), Type = EmployeeType.Постоянный, Gender = "Женщина", Salary = 52000 },
            new Employee { Id = 12, FullName = "Василий Петрович Васильев", Email = "liam@example.com", Position = "Ресепционист", Department = Department.Администрация, HireDate = DateTime.Now.AddYears(-1), DateOfBirth = DateTime.Now.AddYears(-24), Type = EmployeeType.Временный, Gender = "Мужчина", Salary = 38000 },
            new Employee { Id = 13, FullName = "Алексей Константинович Соловьёв", Email = "noah@example.com", Position = "Сисадмин", Department = Department.IT, HireDate = DateTime.Now.AddYears(-3), DateOfBirth = DateTime.Now.AddYears(-29), Type = EmployeeType.Постоянный, Gender = "Мужчина", Salary = 65000 },
            new Employee { Id = 14, FullName = "Ирина Николаевна Козлова", Email = "isabella@example.com", Position = "Кадровик", Department = Department.Кадры, HireDate = DateTime.Now.AddYears(-4), DateOfBirth = DateTime.Now.AddYears(-30), Type = EmployeeType.Постоянный, Gender = "Женщина", Salary = 76000 },
            new Employee { Id = 15, FullName = "Игорь Владимирович Лебедев", Email = "james@example.com", Position = "Главбух", Department = Department.Продажи, HireDate = DateTime.Now.AddYears(-2), DateOfBirth = DateTime.Now.AddYears(-28), Type = EmployeeType.Контракт, Gender = "Мужчина", Salary = 62000 }
        };

        public async Task<(List<Employee> Employees, int TotalCount)> GetEmployees(
               string SearchTerm, // The search term used to filter employees by name
               string SelectedDepartment, // The selected department used to filter employees by department
               string SelectedType, // The selected employment type used to filter employees by employee type
               int PageNumber, // The current page number for pagination
               int PageSize) // The number of employees to display per page
        {
            // Convert the list of employees to an IQueryable to enable filtering and pagination
            // IQueryable allow dynamic querying with filtering and pagination.
            var filteredEmployees = employees.AsQueryable();

            // If a search term is provided, filter the employees by their full name, ignoring case
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                filteredEmployees = filteredEmployees.Where(p => p.FullName.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase));
            }

            // If a department is selected, attempt to parse the department string to the Department enum
            if (!string.IsNullOrEmpty(SelectedDepartment))
            {
                if (Enum.TryParse(SelectedDepartment, out Department department))
                {
                    // Filter the employees by the selected department
                    filteredEmployees = filteredEmployees.Where(p => p.Department == department);
                }
            }

            // If an employment type is selected, attempt to parse the type string to the EmployeeType enum
            if (!string.IsNullOrEmpty(SelectedType))
            {
                if (Enum.TryParse(SelectedType, out EmployeeType type))
                {
                    // Filter the employees by the selected employment type
                    filteredEmployees = filteredEmployees.Where(p => p.Type == type);
                }
            }

            // Get the total count of employees after filtering, before pagination
            int totalCount = filteredEmployees.Count();

            // Apply pagination by skipping the previous pages and taking the current page's employees
            filteredEmployees = filteredEmployees.Skip((PageNumber - 1) * PageSize)
                               .Take(PageSize);

            // Return the filtered and paginated list of employees along with the total count
            return await Task.FromResult((filteredEmployees.ToList(), totalCount));
        }


        public Employee? GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }

        public void CreateEmployee(Employee employee)
        {
            employee.Id = employees.Max(e => e.Id) + 1;
            employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = GetEmployeeById(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.FullName = employee.FullName;
                existingEmployee.Email = employee.Email;
                existingEmployee.Position = employee.Position;
                existingEmployee.Department = employee.Department;
                existingEmployee.HireDate = employee.HireDate;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
                existingEmployee.Type = employee.Type;
                existingEmployee.Gender = employee.Gender;
                existingEmployee.Salary = employee.Salary;
            }
        }

        public void DeleteEmployee(int id)
        {
            var employee = GetEmployeeById(id);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}
