using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add two numbers \n");
            Console.WriteLine("Enter first Number :");
            int firstNumber = Int32.Parse(Console.ReadLine());


            Console.WriteLine("Enter second Number  :");
            int secondnumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Sum of two numbers is :"+(firstNumber+secondnumber-1).ToString());
            Console.ReadKey();
        }
    }
}
