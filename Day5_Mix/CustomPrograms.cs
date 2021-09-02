using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        List<int> num = new List<int>();
        public void greatestNumber()
        {
            Console.WriteLine("Vowels and Consonant");
            for(int i = 1; i <= 3; i++)
            {
                int number = int.Parse(Console.ReadLine());
                this.num.Add(number);
            }
            Console.WriteLine();
            if (num[0] > num[1] && num[0] > num[2])
            {
                Console.WriteLine($"{num[0]} Number is Greater.!");
            }
            else if (num[1] > num[2] && num[1] > num[0])
            {
                Console.WriteLine($"{num[1]} Number is Greater.!");
            }
            else
            {
                Console.WriteLine($"{num[2]} Number is Greater.!");
            }
        }
    }
}
