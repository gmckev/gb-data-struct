using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciRecursive(0,1,1,10);
            Console.WriteLine();
            FibonacciIterative(10);
            Console.ReadKey();
        }

        public static void FibonacciIterative(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < len; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }

        public static void FibonacciRecursive(int firstnumber, int secondnumber, int counter, int length)
        {
            if (counter <= length)
            {
                Console.Write("{0} ", firstnumber);
                FibonacciRecursive(secondnumber, firstnumber + secondnumber, counter + 1, length);
            }
        }
    }
}
