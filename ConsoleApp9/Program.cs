using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp9
{
    internal class Program
    {

        public static List<Class_For_Add_Employee.Employee> EMPLOYEE_MAIN_LIST = new List<Class_For_Add_Employee.Employee>();


        static void Main(string[] args)
        {
           Class_For_The_Employee_Display_Method Option_1 = new ();
           Class_For_Add_Employee Option_2 = new ();
           Class_For_Delete_Employee Option_3 = new ();
            
            
            bool end_of_the_cycle = false;
            
            
            while (!end_of_the_cycle)
            {
                 
                Console.WriteLine("\n     ВЫБЕРИТЕ РАЗДЕЛ: \n");
                Console.WriteLine("\n [1] Список сотрудников");
                Console.WriteLine("\n [2] Добавить сотрудника");
                Console.WriteLine("\n [3] Удалить сотрудника");
                Console.WriteLine("\n [4] Выйти");
                
                
                char choiceoption = Console.ReadKey(true).KeyChar;

                Console.WriteLine();
                
               
                switch (choiceoption)
                {
                    case '1':
                        Option_1.ShowEmployees(EMPLOYEE_MAIN_LIST); 
                        break;
                    case '2':
                        Option_2.Add_Employee(EMPLOYEE_MAIN_LIST); 
                        break;
                    case '3':
                        Option_3.DeleteEmployee(EMPLOYEE_MAIN_LIST); 
                        break;
                    case '4':
                        end_of_the_cycle = true; 
                        break;
                    default:
                        Console.WriteLine("Неверный выбор. Повторите.");
                        break;
                }
            }
        }
    }
}