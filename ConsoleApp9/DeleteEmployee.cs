using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp9.Program;

namespace ConsoleApp9
{
    internal class DeleteEmployee :IInputChecker,INavigate
    {
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

        private List<INavigate> sections;
        
       public void Navigate(List<Employee> employeeMainList)
        { 
        
            
        } 
        public void deleteEmployee(List<Employee> EmployeeMainList)
        {
            Console.Clear();

            if (EmployeeMainList.Count == 0)
            {
                Console.WriteLine("\nСписок сотрудников пуст\n");
                return;
            }

            Console.WriteLine("Выберите сотрудника для удаления:");

            for (int i = 0; i < EmployeeMainList.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {EmployeeMainList[i].Name} {EmployeeMainList[i].Surname} {EmployeeMainList[i].MonthSalary} {EmployeeMainList[i].PhoneNumber}");
            }

            int index = int.Parse(Console.ReadLine());
            if (index > 0 && index <= EmployeeMainList.Count)
            {
                EmployeeMainList.RemoveAt(index - 1);
                Console.WriteLine("Сотрудник удален.");
            }
            else
            {
                Console.WriteLine("Неверный выбор.");


            }

            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey(true);
            Console.Clear();

        }
    }
}
