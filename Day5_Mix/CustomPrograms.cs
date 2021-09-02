using System;
using System.Collections.Generic;
using System.Text;

namespace Day5_Mix
{
    class CustomPrograms
    {
        public void alphabets()
        {
            Console.WriteLine("Vowels and Consonant");
            String letter = Console.ReadLine();
            if(letter == "a" || letter =="A" || letter == "e" || letter == "E" || letter == "i" || letter == "I" || letter == "o" || letter == "O" || letter == "u" || letter == "U")
            {
                Console.WriteLine($"::{letter} : Letter is Vowels..!");
            }
            else
            {
                Console.WriteLine($"::{letter} : Letter is Consonant..!");
            }
        }
    }
}
