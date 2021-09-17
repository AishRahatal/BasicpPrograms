using System;

namespace leap_year
{
    class leap
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap year program :");

            Console.WriteLine("Enter year :");
            int year= Convert.ToInt32(Console.ReadLine());
            if(year>0)
            float rm1 = year % 4;
            float rm2 = year % 400;
            if ( rm1== 0 || rm2==0)
            {
                Console.WriteLine(year + "\tis a Leap year");

            }
            else
            {
                Console.WriteLine(year + "\tis not a Leap year");
            }
        }
            else
            {
                Console.WriteLine("Entered value is invalid for year");

            }        
        }
    }
}
