using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type your birthday. (EX 00/00/00): ");
            string UserBirthday = Console.ReadLine();
            DateTime MyBirthday = DateTime.Parse(UserBirthday);
            TimeSpan myAge = DateTime.Now.Subtract(MyBirthday);
            Console.WriteLine("You have been alive for " + (int)myAge.TotalDays + " days!");
            Console.ReadLine();
        }
    }
}
