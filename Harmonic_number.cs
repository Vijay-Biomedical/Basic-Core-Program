using System;

namespace Harmonnic_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Nth number : ");

            int number = Convert.ToInt32(Console.ReadLine());
            double sumOfHarmonicNumber = 0.0;
            for (int i = 1; i <= number; i++)
            {
                sumOfHarmonicNumber = 1 + (1 / number);
                Console.Write("1/{0} ", i);
            }
        }
    }
}
