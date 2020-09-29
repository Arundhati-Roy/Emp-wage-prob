///using com.sun.org.apache.bcel.@internal.generic;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Coding_prac
{
    interface Company
    {
        public string compName { get; set; }
        public int emp_rate_perHr { get; set; }
        public int no_work_days { get; set; }
        public int max_hrs_in_mon { get; set; }
        public int cal_wage { get; set; }
        //string compName, int emp_rate_perHr, int no_work_days, int max_hrs_in_mon, int cal_wage
        public string CompanyDet()
        {
            return string.Format("{0} is an author of {1}. Price: ${2}",compName,emp_rate_perHr,no_work_days,max_hrs_in_mon,cal_wage);
        }
    }
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
            List<Company> Emp = new List<Company>();
            Console.WriteLine("Enter no of companies: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                List<String> b = new List<String>();
                Console.WriteLine("Comp Name");
                String compName1 = Console.ReadLine();
                //b.Add(compName1);
                Console.WriteLine("Emp Rate");
                String emp_rate_per_hr = Console.ReadLine();
                //b.Add(emp_rate_per_hr);
                Console.WriteLine("No. of working hrs");
                String no_of_work_days = Console.ReadLine();
                //b.Add(no_of_work_days);
                Console.WriteLine("Max work hrs in a month");
                String max_hrs_in_mon = Console.ReadLine();
                //b.Add(max_hrs_in_mon);
                int cw1 = CalEmpWage(compName1, Convert.ToInt32(emp_rate_per_hr),Convert.ToInt32(no_of_work_days),Convert.ToInt32(max_hrs_in_mon));
                Console.WriteLine("Total wage for " + compName1 + " is " + cw1);
                //b.Add(cw1.ToString());
                //new Company { Name = "Mahesh Chand", Book = "ADO.NET Programming", Price = 49.95 }; 
                Emp.Add( new Company { compName = compName1, emp_rate_perHr = Convert.ToInt32(emp_rate_per_hr), no_work_days = Convert.ToInt32(no_of_work_days), max_hrs_in_mon = Convert.ToInt32(max_hrs_in_mon), cal_wage = cw1 });
                //Emp.Add(new company);
                //Emp.AddRange(b);
            }
            foreach (Company i in Emp)
            {
                Console.WriteLine($"Company Details: {i.compName}:{i.emp_rate_perHr}:{i.no_work_days}:{i.max_hrs_in_mon}:{i.cal_wage}");
            }
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
