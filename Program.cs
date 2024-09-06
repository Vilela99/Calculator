using System;
using System.Diagnostics;
using System.Reflection;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Division");
            Console.WriteLine("4 - Multiplication");
            Console.WriteLine("5 - Exit"); 

            Console.WriteLine("Choose an option: ");
            short choice = short.Parse(Console.ReadLine());

            switch(choice){
                case 1: Sum(); break;
                case 2: Subtraction(); break;
                case 3: Division(); break;
                case 4: Multiplication(); break;
                case 5: System.Environment.Exit(0); break; 
                default: Menu(); break;
            }
        }
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("===SUM===");
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Next value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 + v2;
            Console.WriteLine($"Sum result: {result}");
            Console.ReadKey();
            Menu(); 
        }

        static void Subtraction()
        {
            Console.Clear();
            Console.WriteLine("===SUBTRACTION===");
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Next value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"Subtraction result: {result}");
            Console.ReadKey();
            Menu(); 
        }

        static void Division()
        {
            Console.Clear();
            Console.WriteLine("===DIVISION===");
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Next value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"Division result: {result}");
            Console.ReadKey();
            Menu(); 
        }

        static void Multiplication()
        {
            Console.Clear();
            Console.WriteLine("===MULTIPLICATION===");
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Next value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"Multiplication result: {result}");
            Console.ReadKey();
            Menu(); 
        }
    }

}
