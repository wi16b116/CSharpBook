using System;
using System.Collections;

namespace CodePlayground
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine(Divide(5,0));
            Console.ReadLine();
        }

        static double Divide(Double a, Double b)
        {
            if (b == 0)
            {
                throw new InvalidArgumentException();
            }
            else
            {
                double divide = a / b;
                return divide;
            }
        }

    }
}
