///using com.sun.org.apache.bcel.@internal.generic;
using System;
using System.Collections.Generic;

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
            Console.WriteLine("Employee Wage Prob");
            Console.WriteLine("Comp Name");
            String compName1 = Console.ReadLine();
            int cw1 = CalEmpWage(compName1, 28, 8, 9);
            Console.WriteLine("Total wage for " + compName1 + " is " + cw1);
            Console.WriteLine("Comp Name");
            String compName2 = Console.ReadLine();
            int cw2 = CalEmpWage(compName2, 40, 5, 6);
            Console.WriteLine("Total wage for " + compName2 + " is " + cw2);

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
