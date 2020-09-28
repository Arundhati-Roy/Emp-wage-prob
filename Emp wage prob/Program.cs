using System;

namespace Coding_prac
{
    class Program
    {
        public const int is_part_time = 1;
        public const int is_full_time = 2;

        static void Main(string[] args)
        {
            ///Constraints

            int emp_rate = 20;

            ///Variables
            int emphrs = 0;
            int empwage = 0;

            Random random = new Random();
            int empcheck = random.Next(0, 2);

            switch (empcheck)
            {
                case is_part_time:
                    emphrs = 4;
                    break;
                case is_full_time:
                    emphrs = 8;
                    break;
                default:
                    emphrs = 0;
                    break;
            }
            empwage = emphrs * emp_rate;
            Console.WriteLine("Empployee wage" + empwage);

        }
    }

}