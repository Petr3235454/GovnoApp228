using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp9.Program;

namespace ConsoleApp9
{
    internal class ShowEmployees:INavigate
    {
        public void Navigate(List<Employee> employeeMainList)
        {
            
            bool app = false;

            while (!app)
            {
                Console.WriteLine("\n     ВЫБЕРИТЕ РАЗДЕЛ: \n");
                Console.WriteLine("\n [1] Список сотрудников мужчин ");
                Console.WriteLine("\n [2] Список сотрудников женщин ");
                Console.WriteLine("\n [3] Посмотреть полный список сотрудников ");
                Console.WriteLine("\n [4] Назад");

                ConsoleKey key = Console.ReadKey(true).Key;
                Console.WriteLine();

                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        break;

                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        break;

                    case ConsoleKey.NumPad3:
                        showEmployees(employeeMainList);
                        
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
        public void showEmployees(List<Employee> employeeMainList)
        {
            Console.Clear();
            Console.WriteLine("\nСписок сотрудников:\n");

            for (int i = 0; i < employeeMainList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] Имя: {employeeMainList[i].Name} Фамилия: {employeeMainList[i].Surname} Зарплата: {employeeMainList[i].MonthSalary} Телефон: {employeeMainList[i].PhoneNumber}");
            }

            if (employeeMainList.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("Список пуст!");
            }


            Console.WriteLine("\n[4] Назад");
            Console.ReadKey(true);
            Console.Clear();
        }

    }
}
