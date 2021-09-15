using System;

namespace harmonicseries
{
    class series
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Harmonic series Program");
            
            Console.WriteLine("Enter number to get harmonic series:");
            int n = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("H(n)= ");
            for ( int i=1; i<=n; i++)
            {
                Console.WriteLine("1/" + i);
                if (i != n)
                Console.WriteLine("+");


            }
        }

     
    }
}
