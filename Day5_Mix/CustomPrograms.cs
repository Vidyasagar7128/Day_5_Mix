using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        List<int> quotient = new List<int>();
        int count=0;
        int result1 = 0;
        int result2 = 0;
        public void quotientReminder()
        {
            Console.WriteLine("Quotient and Reminder");
            Console.WriteLine();
            Console.WriteLine("Divisor");
            int divisor = int.Parse(Console.ReadLine());
            Console.WriteLine("Value");
            int value = int.Parse(Console.ReadLine());
            this.result1 = value % divisor;
            Console.WriteLine($"Reminder : {value%divisor}");
            Console.WriteLine($"Quotient : {value / divisor}");
        }
    }
}
