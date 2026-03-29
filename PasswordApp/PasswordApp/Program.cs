using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordLibrary;


namespace PasswordApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пароль: ");
            string s = Console.ReadLine();
            Password password = new Password(s);
            if (password.CheckPassword())
                Console.WriteLine("Пароль соответствует требованиям");
            else
                Console.WriteLine("Пароль не соответствует требованиям");
            Console.ReadKey();
        }
    }
}
