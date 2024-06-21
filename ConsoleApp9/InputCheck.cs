using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public interface IInputChecker
    {
        string InputCheck(string message);
    }
    internal class InputChecked:IInputChecker
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
    }
}
