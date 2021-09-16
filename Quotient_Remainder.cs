using System;

namespace Quotientandremainder
{
    class Quotient_Remainder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Compute Quotient and Remainder");
            Console.WriteLine("-------------------------------------");
            float quotient, remainder;
            Console.WriteLine("Enter divident:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
