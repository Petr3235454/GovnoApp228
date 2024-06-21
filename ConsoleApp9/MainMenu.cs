using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp9.EmployeeServices;
using static ConsoleApp9.Program;

namespace ConsoleApp9
{
    internal class MainMenu : INavigate
    {

        public AddEmployee option2 = new AddEmployee();
        public DeleteEmployee option3 = new DeleteEmployee();
        public ShowEmployees option1 = new ShowEmployees();
        public List<Employee> employeeMainList = new List<Employee>();
       
        public void Navigate(List<Employee> employeeMainList)
        {
            bool app = false;

            while (!app)
            {
                Console.WriteLine("\n     ВЫБЕРИТЕ РАЗДЕЛ: \n");
                Console.WriteLine("\n [1] Список сотрудников");
                Console.WriteLine("\n [2] Добавить сотрудника");
                Console.WriteLine("\n [3] Удалить сотрудника");
                Console.WriteLine("\n [4] Выйти");

                ConsoleKey key = Console.ReadKey(true).Key;
                Console.WriteLine();
                Console.Clear();
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        option1.Navigate(employeeMainList);
                        break;
                    case ConsoleKey.NumPad2:
                        option2.Navigate(employeeMainList);
                        break;
                    case ConsoleKey.NumPad3:
                        option3.deleteEmployee(employeeMainList);
                        break;
                    case ConsoleKey.NumPad4:
                        app = true;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Неверный выбор. Повторите.");
                        break;
                }
            }
        }
    }
}


