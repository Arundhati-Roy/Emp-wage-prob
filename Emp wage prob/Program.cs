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
                Console.WriteLine("Daily wage: " + 8 * 20);
            }
            else
            {
                Console.WriteLine("Absent");
                Console.WriteLine("Daily wage: " + 0);

            }
        }

    }
}