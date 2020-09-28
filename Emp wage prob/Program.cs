using System;

namespace Coding_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == p)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }
        }

    }
}