using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkNumTwoStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName;
            int userAge;
            string userZodiacSign;
            string userProfession;

            Console.Write("Укажите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            userAge = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Укажите свой знак зодиака: ");
            userZodiacSign = Console.ReadLine();
            Console.Write("Укажите вашу профессию: ");
            userProfession = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Вас зовут {userName}, вам {userAge} лет, " +
                $"вы {userZodiacSign}, ваша профессия {userProfession}, " +
                $"благодарим что прошли опрос (-:");

        }
    }
}
