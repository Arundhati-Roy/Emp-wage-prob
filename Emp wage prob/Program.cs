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
        //public const int emp_rate_per_hr = 20;
        //public const int no_work_days = 2;
        //public const int max_hrs_in_mon = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Employee Wage Prob");
            List<String> Emp = new List<String>();
            Console.WriteLine("Enter no of companies: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                List<String> b = new List<String>();
                Console.WriteLine("Comp Name");
                String compName1 = Console.ReadLine();
                b.Add(compName1);
                Console.WriteLine("Emp Rate");
                String emp_rate_per_hr = Console.ReadLine();
                b.Add(emp_rate_per_hr);
                Console.WriteLine("No. of working hrs");
                String no_of_work_days = Console.ReadLine();
                b.Add(no_of_work_days);
                Console.WriteLine("Max work hrs in a month");
                String max_hrs_in_mon = Console.ReadLine();
                b.Add(max_hrs_in_mon);
                int cw1 = CalEmpWage(compName1, Convert.ToInt32(emp_rate_per_hr),Convert.ToInt32(no_of_work_days),Convert.ToInt32(max_hrs_in_mon));
                Console.WriteLine("Total wage for " + compName1 + " is " + cw1);
                b.Add(cw1.ToString());
                Emp.AddRange(b);
            }
            Emp.ForEach(Console.WriteLine);
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
