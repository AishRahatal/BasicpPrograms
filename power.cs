using System;

namespace powerof2
{
    class power
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate power of 2 program");

            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
          

            if(n<32)
            {

                Console.WriteLine(n.ToString() +"to power of 2" + "=" + Math.Pow(2, n));
            }


        }
    }
}
