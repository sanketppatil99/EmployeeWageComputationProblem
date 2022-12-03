using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class DailyWageUsingSwitchCase
    {
        public static void dailyWageUsingSwitchCase()
        {
            const int Is_Full_time = 1;
            const int Is_Part_time = 2;
            const int Emp_Rate_per_hour = 20;
            
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(3);

           
            switch (empCheck)
            {
                case Is_Full_time:
                    Console.WriteLine("Employee is Full Time");
                    empHrs = 8;
                    break;

                case Is_Part_time:
                    Console.WriteLine("Employee is Part Time");
                    empHrs = 4;
                    break;

                default:
                    Console.WriteLine("Employee is not Worked");
                    empHrs = 0;
                    break;
            }
            empWage = Emp_Rate_per_hour * empHrs;
            Console.WriteLine("total employee wage is: " + empWage);
        }
    }
}
