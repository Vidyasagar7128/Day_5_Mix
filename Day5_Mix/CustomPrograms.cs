using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        public void primeFactorization()
        {
            Console.WriteLine("Enter the number for Factorization : ");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
            {
                for (int i = 2; 1 < number; i++)
                {
                    while (number % i == 0)
                    {
                        Console.WriteLine(i);
                        number = number / i;
                    }
                }
            }
            else
            {
                Console.WriteLine($"There are no factors for : {number}");
            }
        }
    }
}
