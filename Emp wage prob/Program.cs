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
        public static int pacheck(int r)
        {
            int emphrs = 0;
            switch (r)
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
            return emphrs;
        }
        public static int WageCal()
        {
            ///Variables
            int emphr = 0;
            int totalemphrs = 0;
            int totalworkdays = 0;
            while (totalemphrs <= max_hrs_in_mon && totalworkdays < no_work_days)
            {
                totalworkdays++;
                Random random = new Random();
                int r = random.Next(0, 3);
                emphr = pacheck(r);
                
                totalemphrs += emphr;
                Console.WriteLine("Days:" + totalworkdays + "Emp Hrs:" + emphr);
            }
            int totalempwage = totalemphrs * emp_rate_per_hr;
            return totalempwage;

    }
        static void Main(string[] args)
        {
            Console.WriteLine("Empployee wage" + WageCal());

        }
    }

}