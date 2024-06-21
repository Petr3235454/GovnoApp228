using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp9.Program;

namespace ConsoleApp9
{
   
    internal class AddEmployee:IInputChecker,INavigate
    {
        public void Navigate(List<Employee> employeeMainList)
        {
            bool app = false;

            while (!app)
            {
                Console.WriteLine("\n     ВЫБЕРИТЕ РАЗДЕЛ: \n");
                Console.WriteLine("\n [1] Добавить сотрудника мужчину ");
                Console.WriteLine("\n [2] Добавить сотрудника женщину ");
                Console.WriteLine("\n [4] Назад");
                ConsoleKey key = Console.ReadKey(true).Key;
                Console.WriteLine();

                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        addEmployee(employeeMainList);
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad2:
                        addEmployee(employeeMainList);
                        Console.Clear();
                        break;
                    case ConsoleKey.NumPad3:

                        break;

                    case ConsoleKey.NumPad4:
                        app = true;
                        Console.Clear();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор. Повторите.");
                        break;
                }
            }
        }
        public string InputCheck(string message)
        {
            string userInput;
            do
            {
                Console.Clear();
                Console.WriteLine(message);
                userInput = Console.ReadLine();

                if (string.IsNullOrEmpty(userInput))
                {

                    Console.WriteLine("Ошибка: Введите корректное значение!");
                    Console.WriteLine("Нажмите любую клавишу, чтобы продолжить...");
                    Console.ReadKey();
                }

            } while (string.IsNullOrEmpty(userInput));

            return userInput;
        }
        public void addEmployee(List<Employee> EmployeeMainList)
        {
            Console.Clear();

            string gender = InputCheck("Введите пол сотрудника (Ж - женский, М - мужской): ");
            
            string name = InputCheck("Введите имя сотрудника: ");
            string surname = InputCheck("Введите фамилию сотрудника: ");
            string monthSalary = InputCheck("Укажите ежемесячную зарплату сотрудника: ");
            string phoneNumber = InputCheck("Введите номер телефона сотрудника: ");



            Employee newEmployee = new Employee(gender, name, surname, monthSalary, phoneNumber);

            EmployeeMainList.Add(newEmployee);

            Console.Clear();
            Console.WriteLine("\nСотрудник успешно добавлен\n");
            Console.WriteLine($"{name} {surname} {monthSalary} {phoneNumber}\n");

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey(true);
            Console.Clear();
        }
    }
}
