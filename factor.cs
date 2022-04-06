using System;

namespace Day_5
{
    class Factor
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter positive number : ");
                int number = Convert.ToInt32(Console.ReadLine());

                int originalNumber = 1;

                if (number < 0)
                {
                    Console.WriteLine("Invalid Number!");
                    Console.ReadLine();
                }
                else
                {
                    for (int count = 2; number > 1; count++)
                    {
                        while (number % count == 0)
                        {
                            Console.Write("{0} ", count);
                            number /= count;
                            originalNumber *= count;
                        }
                    }
                    Console.WriteLine("\nOriginal Number after prime factorization : {0}", originalNumber);
                    Console.ReadLine();
                }
            }
        }
    }
    
}
