using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        int sum = 0;
        public void harmonicNumber()
        {
            Console.WriteLine("Enter Number for Harmonic Value");
            int number = int.Parse(Console.ReadLine());
            for(int i = 1; i <= number; i++)
            {
                Console.Write($"1/{i},");
                this.sum = this.sum + i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum of Harmonic Number : 1/{this.sum}");
        }
    }
}
