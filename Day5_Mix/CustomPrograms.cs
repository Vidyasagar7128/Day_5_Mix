using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        public void leapYear()
        {
            Console.WriteLine("Enter Year in Four Digits..");
            String number = Console.ReadLine();
            int year = int.Parse(number);
            if (year % 400 == 0 && year % 100 != 0 || year % 4 == 0)
            {
                Console.WriteLine($"{year} : is Leap Year..!");
            }
            else
            {
                Console.WriteLine($"{year} : is Not Leap Year..!");
            }
        }
    }
}
