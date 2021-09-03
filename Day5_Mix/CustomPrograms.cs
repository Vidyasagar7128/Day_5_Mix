using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        public void powerOfTwo(int number)
        {
            Console.WriteLine("Enter the number for Power of 2's : ");
            if(number <= 31)
            {
                Console.WriteLine();
                for (int i = 1;i <= number; i++)
                {
                    
                    Console.WriteLine($"{Math.Pow(2,i)}");
                }
            }
            else
            {
                Console.WriteLine("Enter Number below : 31");
            }
        }
    }
}
