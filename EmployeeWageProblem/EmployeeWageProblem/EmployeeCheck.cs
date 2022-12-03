using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem
{
    public static class EmployeeCheck
    {
        public static void EmployeeAttendance()
        {
            int Is_Full_time = 1;

            Random rand = new Random();
            int empCheck = rand.Next(2);
            if (empCheck == Is_Full_time)
            {
                Console.WriteLine("Employee is present");

            }

            else
            {
                Console.WriteLine("Employee is absent");

            }


        }
    }
}