using System;

namespace Day5_Mix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(args[0]);
            CustomPrograms obj = new CustomPrograms();
            obj.powerOfTwo(num);
        }
    }
}
