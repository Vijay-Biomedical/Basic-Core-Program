﻿using System;

namespace OddAndEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is even number.", number);
            }
            else
            {
                Console.WriteLine("{0} is odd number.", number);
            }
        }
    }
}
        
