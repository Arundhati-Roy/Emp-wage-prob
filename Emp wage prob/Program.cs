using System;

namespace Coding_prac
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Constraints
            int is_part_time = 1;
            int is_full_time = 2;
            int emp_rate = 20;

            ///Variables
            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == is_part_time)
            {
                emphrs = 4;
            }
            else if (empcheck == is_full_time)
            {
                emphrs = 8;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * emp_rate;
            Console.WriteLine("Empployee wage" + empwage);

        }
    }

}