using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static ConsoleApp9.EmployeeServices;

namespace ConsoleApp9
{
    internal class Program
    {
       
        public interface INavigate
        {
            void Navigate(List<Employee> employeeMainList);
        }
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Navigate(mainMenu.employeeMainList);
        }
    }
}

        