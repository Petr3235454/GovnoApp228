using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Class_For_The_Employee_Display_Method
    {
        public void ShowEmployees(List<Class_For_Add_Employee.Employee> EMPLOYEE_MAIN_LIST)
        {
            Console.Clear();
            Console.WriteLine("\nСписок сотрудников:\n");

            foreach (var employee in EMPLOYEE_MAIN_LIST)
            {
                Console.WriteLine($"Имя: {employee.Name}, Фамилия: {employee.Surname}, Зарплата: {employee.MonthSalary}, Телефон: {employee.PhoneNumber}");
            }

           if (EMPLOYEE_MAIN_LIST.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Список пуст!");
            }
            

            Console.WriteLine("\n [Назад] Нажмите любую клавишу для продолжения...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
