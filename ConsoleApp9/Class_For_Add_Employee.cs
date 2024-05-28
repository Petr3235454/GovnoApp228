using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Class_For_Add_Employee
    {
        
        public class Employee
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public string MonthSalary { get; set; }
            public string PhoneNumber { get; set; }

            public Employee(string name, string surname, string monthSalary, string phoneNumber)
            {
                Name = name;
                Surname = surname;
                MonthSalary = monthSalary;
                PhoneNumber = phoneNumber;
            }
        }

        public void Add_Employee(List<Employee> EMPLOYEE_MAIN_LIST)
        {
            Console.Clear();

            Console.WriteLine("Введите имя сотрудника: ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.Clear();
                Console.WriteLine("Неверный ввод имени, повторите еще раз: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Введите фамилию сотрудника: ");
            string surname = Console.ReadLine();
            while (string.IsNullOrEmpty(surname))
            {
                Console.Clear();
                Console.WriteLine("Неверный ввод фамилии, повторите еще раз: ");
                surname = Console.ReadLine();
            }

            Console.WriteLine("Укажите ежемесячную зарплату сотрудника: ");
            string monthSalary = Console.ReadLine();
            while (string.IsNullOrEmpty(monthSalary))
            {
                Console.Clear();
                Console.WriteLine("Неверный ввод зарплаты, повторите еще раз: ");
                monthSalary = Console.ReadLine();
            }

            Console.WriteLine("Введите номер телефона сотрудника: ");
            string phoneNumber = Console.ReadLine();
            while (string.IsNullOrEmpty(phoneNumber))
            {
                Console.Clear();
                Console.WriteLine("Неверный ввод номера телефона, повторите еще раз: ");
                phoneNumber = Console.ReadLine();
            }

            Employee newEmployee = new Employee(name, surname, monthSalary, phoneNumber);
            EMPLOYEE_MAIN_LIST.Add(newEmployee);

            Console.Clear();
            Console.WriteLine("\nСотрудник успешно добавлен\n");
            Console.WriteLine($"{name}  {surname}  {monthSalary}  {phoneNumber}\n");

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey(true);
            Console.Clear();
        }


    }
}

