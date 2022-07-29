using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    /// <summary>
    /// The Class defines Employee Check.
    /// </summary>
    public static class EmployeeCheck
    {
        //Constant
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS = 20;

        /// <summary>
        /// Checks the employee attendance.
        /// </summary>
        public static void CheckEmployeeAttendance()
        {         
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int day=0;day<NUM_OF_WORKING_DAYS;day++)
            {
               Random random = new Random();

               int empCheck  = random.Next(3);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
            Console.WriteLine("total Emp Wage  : " + totalEmpWage);
        }
            
    }
}
