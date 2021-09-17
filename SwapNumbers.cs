using System;

namespace SwapNumbers
{
    class SwapNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Swap Two Numbers");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter first number:");
            int first_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int second_num = Convert.ToInt32(Console.ReadLine());
            int temp;
            Console.WriteLine("-------------------------------------");
             if (first_num > 0 || second_num > 0)
            {
            Console.WriteLine("Numbers before Swap : first number="+first_num +"\tsecond number=" +second_num);
            Console.WriteLine("---------------------------------------------------------------------------");

            temp = first_num;
            first_num = second_num;
            second_num = temp;
            
            Console.WriteLine("Numbers before Swap : first number=" + first_num +"\tsecond number=" + second_num);
            }
            else
            {
                Console.WriteLine("Input is invalid ");

            }

        }
    }
}
