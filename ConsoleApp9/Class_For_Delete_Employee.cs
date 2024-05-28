using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Class_For_Delete_Employee
    {
        public void DeleteEmployee(List<Class_For_Add_Employee.Employee> EMPLOYEE_MAIN_LIST)
        {
            Console.Clear();

            if (EMPLOYEE_MAIN_LIST.Count == 0)
            {
                Console.WriteLine("\nСписок сотрудников пустОЙЙАААААА.\n");
                return;
            }

            Console.WriteLine("Выберите сотрудника для удаления:");

            for (int i = 0; i < EMPLOYEE_MAIN_LIST.Count; i++)
            {
                Console.WriteLine($"[{i + 1}] {EMPLOYEE_MAIN_LIST[i].Name} {EMPLOYEE_MAIN_LIST[i].Surname} {EMPLOYEE_MAIN_LIST[i].MonthSalary} {EMPLOYEE_MAIN_LIST[i].PhoneNumber}");
            }

            int index = int.Parse(Console.ReadLine());
            if (index > 0 && index <= EMPLOYEE_MAIN_LIST.Count)
            {
                EMPLOYEE_MAIN_LIST.RemoveAt(index - 1);
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