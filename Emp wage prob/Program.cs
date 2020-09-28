///using com.sun.org.apache.bcel.@internal.generic;
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
        public const int max_hrs_in_mon = 100;

        static void Main(string[] args)
        {

            CalEmpWage("Walmart", 28, 8, 90);
            CalEmpWage("Facebook", 40, 5, 60);
        }

        public static int CalEmpWage(String compName, int emp_rate_per_hr, int no_work_days, int max_hrs_in_mon)
        {
            ///Variables
            int emphrs = 0;
            int totalemphrs = 0;
            int totalworkdays = 0;
            while (totalemphrs <= max_hrs_in_mon && totalworkdays < no_work_days)
            {
                totalworkdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);

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
            Console.WriteLine("Employee wage for company " +compName+" is "+ totalempwage);
            return totalempwage;
        }


    }

}
