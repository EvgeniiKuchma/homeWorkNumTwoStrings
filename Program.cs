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
            string Name;
            int Age;
            string ZodiacSign;
            string Profession;

            Console.Write("Укажите ваше имя: ");
            Name = Console.ReadLine();
            Console.Write("Укажите свой возраст: ");
            Age = Convert.ToInt32( Console.ReadLine() );
            Console.Write("Укажите свой знак зодиака: ");
            ZodiacSign = Console.ReadLine();
            Console.Write("Укажите вашу профессию: ");
            Profession = Console.ReadLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Вас зовут {Name}, вам {Age} лет, " +
                $"вы {ZodiacSign}, ваша профессия {Profession}, " +
                $"благодарим что прошли опрос (-:");

        }
    }
}
