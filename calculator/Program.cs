using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 42;
            int b = 119;
            int c = a + b;
            Console.WriteLine(c);
            Console.ReadKey();
            int num1 = 0; int num2 = 0;
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Type a number, and then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("+a - Add");
            Console.WriteLine("-s - Subtract");
            Console.WriteLine("*m - Multiply");
            Console.WriteLine(":d - Divide");
            Console.Write("Your option? ");
            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;

            }
        }
    }
}
