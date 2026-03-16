using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
    internal class Task
    {
        public void Fibonacci(int count)
        {
            int a = 0, b = 1;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < count; i++)
            {
                Console.Write(a + " ");
                int next = a + b;
                a = b;
                b = next;
            }

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Task obj = new Task();

            Console.Write("Enter how many Fibonacci numbers to print: ");
            int count = Convert.ToInt32(Console.ReadLine());

            obj.Fibonacci(count);
        }
    }
}
