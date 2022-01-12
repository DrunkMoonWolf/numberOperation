using System;

namespace MathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Какую операцию выполнить? ('+', '-', '*', '/')");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":

                    break;
                case "-":

                    break;
                case "*":

                    break;
                case "/":
                    Console.WriteLine(a/b);
                    break;
                default:
                    Console.WriteLine("Такого варианта нет!");
                    break;
            }
        }
    }
}
