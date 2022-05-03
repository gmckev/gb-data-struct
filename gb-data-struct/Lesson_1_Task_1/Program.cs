using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrimeNumber(13));
            Console.WriteLine(IsPrimeNumber(12));
            Console.ReadKey();
        }

        public static bool IsPrimeNumber(int number)
        {
            int d = 0;
            int i = 2;

            while(i<number)
            {
                if(number%i==0)
                {
                    d++;
                }
                i++;
            }

            if(d==0)
            {
                return true;
            }
            return false;
        } 
    }
}
