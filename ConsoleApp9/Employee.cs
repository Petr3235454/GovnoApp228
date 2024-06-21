using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp9
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Surname { get; set; }
        string MonthSalary { get; set; }
        string PhoneNumber { get; set; }
        string Gender { get; set; }
    }


    internal class Employee:IEmployee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MonthSalary { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }


        public Employee(string name, string surname, string monthSalary, string phoneNumber, string gender)
        {
            Name = name;
            Surname = surname;
            MonthSalary = monthSalary;
            PhoneNumber = phoneNumber;
            Gender = gender;
        }

        
    }
     

    
 }

