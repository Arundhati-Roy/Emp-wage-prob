using System;

namespace Coding_prac
{
    class Program
    {
        ///Constraints
        public const int is_part_time = 1;
        public const int is_full_time = 2;
        public const int emp_rate_per_hr = 20;
        public const int no_work_days = 2;
        public const int max_hrs_in_mon = 10;

        static void Main(string[] args)
        {

            ///Variables
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkdays = 0;
            while (totalemphrs <= max_hrs_in_mon && totalworkdays < no_work_days)
            {
                totalworkdays++;
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
                totalemphrs += emphrs;
                Console.WriteLine("Days:" + totalworkdays + "Emp Hrs:" + emphrs);
            }
            int totalempwage = totalemphrs * emp_rate_per_hr;
            Console.WriteLine("Empployee wage" + totalempwage);

        }
    }

}