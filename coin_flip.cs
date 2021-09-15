using System;

namespace coin_flip
{
    class coin_flip
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Coin flip program :");

            Console.WriteLine("Flipping coin...");

            Random random = new Random();

            int value = random.Next(0, 1);

            if(value==1)
            {
                Console.WriteLine("You got Heads!!");
            }
            else
            {
                Console.WriteLine("You got Tails!!");

            }

        }
    }
}
