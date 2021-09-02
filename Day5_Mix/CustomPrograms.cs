using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        int count = 1;
        int sum = 0;
        int headCount = 0;
        int tailCount = 0;
        public void randomNumber()
        {
            Console.WriteLine("How many times flip coint..");
            String number = Console.ReadLine();
            int n = int.Parse(number);

            while (this.count <= n)
            {
                int rand = new Random().Next(0, 2);
                if (rand == 0)
                {
                    Console.WriteLine("HEAD");
                    this.headCount = this.headCount + 1;
                }
                else
                {
                    Console.WriteLine("TAIL");
                    this.tailCount = this.tailCount + 1;
                }
                count++;
            }
            Console.WriteLine($"Head : {this.headCount}");
            Console.WriteLine($"Tail : {this.tailCount}");
            this.sum = this.headCount + this.tailCount;
            double avg = ((double)this.headCount / this.sum * 100);
            double otherAvg = 100 - avg;
            Console.WriteLine($"HEAD Percentage % ::::: {avg}");
            Console.WriteLine($"TAIL Percentage % ::::: {otherAvg}");
            Console.WriteLine($"SUM ::::: {this.sum}");
        }
    }
}
