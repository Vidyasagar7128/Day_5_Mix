using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        int one = 10;
        int two = 20;
        public void leapYear()
        {
            Console.WriteLine("Swap two Numbers..");
            Console.WriteLine($"Before Swaping One : {one}, Before Swaping Two : {two}");
            one = one + two;//30
            two = one - two;//10
            one = one - two;//20
            Console.WriteLine($"After Swaping One : {one}, After Swaping Two : {two}");
        }
    }
}
