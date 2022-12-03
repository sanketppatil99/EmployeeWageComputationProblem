using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public class PartTimeWage
    {
        public static void partTimeWage()
        {
            int Is_Full_time = 1;
            int Is_Part_Time = 2;

            int Emp_Rate_per_hour = 20;
            
            int empHrs = 0;
            int empWage = 0;
            Random rand = new Random();
            int empCheck = rand.Next(3);
           
            if (empCheck == Is_Full_time)
            {
                Console.WriteLine("Employee is Full Time");
                empHrs = 8;
            }
            else if (empCheck == Is_Part_Time)
            {
                Console.WriteLine("Employee is Part Time");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is not Worked");
                empHrs = 0;
            }
            empWage = Emp_Rate_per_hour * empHrs;
            Console.WriteLine("Employee Wage =  " + empWage);

        }
    }
}