using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp.Classes
{
    class EmployeeInheritance
    {
        public string _FirstName;
        public string _LastName;
        public string _Email;

        //public EmployeeInheritance(string FirstName, string LastName)
        //{
        //    this._FirstName = FirstName;
        //    this._LastName = LastName;
        //}
        public void PrintFullName()
        {
            Console.WriteLine($"Fullname : {_FirstName} {_LastName}");
        }

        public void PrintSalary(float Salary)
        {
            Console.WriteLine($"SalaryPerYear = {Salary}");
        }
    }

    class FullTimeEmployee : EmployeeInheritance
    {
        float _SalaryPerYear;
    }

    class PartTimeEmployee: EmployeeInheritance
    {
        float _SalaryPerHour;
    }
}
