using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp.Classes
{
    class EmployeeDelegateTest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<EmployeeDelegateTest> employee, IsPromotable IsEligibleForPromotion)
        {
            foreach (EmployeeDelegateTest emp in employee)
            {
                if (IsEligibleForPromotion(emp))
                {
                    Console.WriteLine($"{emp.Name} is promoted");
                }
            }
        }

    }
}
