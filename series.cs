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
           if (n > 0)
            {
            Console.Write("{0} ","H(n)= ");
            for ( int i=1; i<=n; i++)
            {
               Console.Write("{0} ","1/"+ i);
                if (i != n)
                 Console.Write("{0}","+");;


            }
            }
            else
              {
                Console.WriteLine("Input is invalid ");

              }
        }

     
    }
}
