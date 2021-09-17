using System;

namespace primefactors
{
    class Prime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime factors program");
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
            Console.WriteLine("Prime factors of :" + n + "\tare :");
                for (int i = 2; i <= n; i++)
                {
                    while (n % i == 0)
                    {
                        Console.WriteLine(i);

                        n = n / i;
                    }
                }
            }
            else
            {
                Console.WriteLine("Input is invalid ");

            }

        }

    }
}
