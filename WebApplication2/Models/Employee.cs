using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Employee
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Полное имя не верно")]
        [StringLength(100, ErrorMessage = "Длина имени не может превышать 100 символов")]
        [Display(Name = "Полное имя")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Неверный адрес почты")]
        [EmailAddress(ErrorMessage = "Проверьте написания адреса почты")]
        [Display(Name = "Адрес почты")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Неверная должность")]
        [StringLength(50, ErrorMessage = "Должность не должна превышать 50 символов")]
        public string Position { get; set; }
        [Required(ErrorMessage = "Неверный отдел")]
        public Departament? Departament { get; set; }
        [Required(ErrorMessage = "Неверная дата приёма")]
        [Display(Name = "Дата принятия")]
        [DataType(DataType.Data, ErrorMessage = "Неверный формат даты")]
        public DataTime? HireData { get; set; }
        [Required(ErrorMessage = "Неверная дата рж")]
        [Display(Name = "Дата РЖ")]
        [DataType(DataType.Data, ErrorMessage = "Неверный формат даты")]
        public DataTime? DataOfBirthday { get; set; }
        [Required(ErrorMessage = "Неверный тип занятости")]
        [Display(Name = "Тип занятости")]
        public EmployeeType? Type { get; set; }
        [Required(ErrorMessage = "Неверный пол")]
        [StringLength(3, ErrorMessage =("Пол может быть м или ж"))]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Зарплата неправильная")]
        [Range(0,double.MaxValue, ErrorMessage = "Зарплата должна быть положительной")]
        [DataType(DataType.Currency)] 
        public decimal Salary { get; set; }
    } 
    

    
}
