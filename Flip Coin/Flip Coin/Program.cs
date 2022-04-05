using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flip_Coin
{
    class Program
    {
        static void Main(string[] args)
        {
            int No_Of_Times, Counttail = 0, Counthead = 0;
            Console.WriteLine("Enter The No Of Times To Flip");
            No_Of_Times = int.Parse(Console.ReadLine());
            for (int start = 0; start < No_Of_Times; start++)
            {

                Random random = new Random();
                double flip = random.Next(0, 2);
                if (flip < 0.5)
                    Counttail++;
                else
                    Counthead ++;
            }
            int headTotalCount = Counthead;
            int tailTotalCount = Counttail;
            Console.WriteLine("Total no of Head : {0} ", headTotalCount);
            Console.WriteLine("Total no of Tail : {0}", tailTotalCount);

            double headPercent = (headTotalCount / No_Of_Times)*100;
            double tailPercent = (tailTotalCount / No_Of_Times)*100;


            Console.WriteLine("Head Percentage : {0}", headPercent);
            Console.WriteLine("Tail Percentage : {0}", tailPercent);




        }
    }
}
