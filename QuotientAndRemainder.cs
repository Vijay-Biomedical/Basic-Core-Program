﻿using System;

namespace QoutientAndRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
             
        
                Console.Write("Enter the number : ");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter the divisor :");
                int divisor = Convert.ToInt32(Console.ReadLine());
                int remainder;
                int quotient;

                //Compute
                quotient = number / divisor;
                remainder = number % divisor;

                //Result
                Console.WriteLine("The quotient is {0}", quotient);
                Console.WriteLine("The remainder is {0}", remainder);

            
        }


    }
}

