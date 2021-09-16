using System;

namespace alphabets
{
    class VowelsConsonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program to Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Enter an alphabet:");
            char alphabet = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("-------------------------------------");

            if ( alphabet=='a' || alphabet=='e'|| alphabet=='i'|| alphabet=='o'|| alphabet=='u'||
               alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U')
            {
                Console.WriteLine("An alphabet is a Vowel ");

            }
            else
            {
                Console.WriteLine("An alphabet is a Consonant ");

            }
        }
    }
}
