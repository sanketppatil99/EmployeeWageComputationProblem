using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class WageForMonth
    {
        public static void wageForMonth()
        {
            const int Is_Full_time = 1;
            const int Is_Part_time = 2;
            const int Emp_Rate_per_hour = 20;
            

            int Num_Of_Working_days = 20;
            int totalHrs = 0;
            int empHrs = 0;
            int empWage = 0;
            for (int i = 0; i < Num_Of_Working_days; i++)
            {
                Random rand = new Random();
                int empCheck = rand.Next(3);


                switch (empCheck)
                {
                    case Is_Full_time:
                        empHrs = 8;
                        break;

                    case Is_Part_time:
                        empHrs = 4;
                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalHrs += empHrs;
            }
            Console.WriteLine("total working hours: {0}", totalHrs);
            empWage = Emp_Rate_per_hour * totalHrs;
            Console.WriteLine("total employee wage is: " + empWage);

        }
    }
}
