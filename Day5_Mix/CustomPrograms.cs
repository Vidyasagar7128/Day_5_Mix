using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        public void oddEven()
        {
            Console.WriteLine("Odd Even Numbers..");
            int number = int.Parse(Console.ReadLine());
            if(number % 2 == 0)
            {
                Console.WriteLine($"{number} : Number is Even..!");
            }
            else
            {
                Console.WriteLine($"{number} : Number is Odd..!");
            }
        }
    }
}
