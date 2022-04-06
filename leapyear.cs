
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace BasicCorePrograms
    {
        class LeapYear
        {
        static public void Main(String[] args)
        {
                Console.WriteLine("Enter the year : ");
                
                int year = Convert.ToInt32(Console.ReadLine());

                
                if (year >= 1000 && year <= 9999)
                {
                    if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine("Year : {0} is leap.", year);
                    }
                    else
                    {
                        Console.WriteLine("Year : {0} is not leap.", year);
                    }

                }
                else
                {
                    Console.WriteLine("Invalid Number entered.");
                }

            }
        }
    }

        
    

