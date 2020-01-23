using IntroductionToCSharp.Classes;
using System;
using System.Collections.Generic;

namespace IntroductionToCSharp
{

    delegate bool IsPromotable(EmployeeDelegateTest empl);

    class Program
    {
        public static bool Promote(EmployeeDelegateTest employee)
        {
           return employee.Experience >= 4 ? true : false;
        }

        static void Main(string[] args)
        {
            //CoffeeShop coffee = new CoffeeShop();
            //EvenNumbers even = new EvenNumbers();
            //CoffeeShopDoWhile coffeeShop = new CoffeeShopDoWhile();
            //CustomerClass adeolu = new CustomerClass("Adeolu", "Adeyemi");
            //adeolu.PrintCustomerName();

            /*CircleStaticAndInstanceMembers C1 = new CircleStaticAndInstanceMembers(5);
            float Area1 = C1.CalculateCircleArea();
            Console.WriteLine($"Area of the circle = {Area1}");

            CircleStaticAndInstanceMembers C2 = new CircleStaticAndInstanceMembers(6);
            float Area2 = C2.CalculateCircleArea();
            Console.WriteLine($"Area of the circle = {Area2}");*/

            /*FullTimeEmployee FTE = new FullTimeEmployee();
            FTE._FirstName = "Adeolu";
            FTE._LastName = "Adeyemi";
            FTE.PrintFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE._FirstName = "Bukola";
            PTE._LastName = "Adeyemi";
            PTE.PrintFullName(); */

            /*EmployeePolyMorphism[] Emp = new EmployeePolyMorphism[4];

            Emp[0] = new EmployeePolyMorphism();
            Emp[1] = new FullTimePolEmployee();
            Emp[2] = new PartTimePolEmployee();
            Emp[3] = new TemporaryPolEmployee();


            foreach(EmployeePolyMorphism e in Emp)
            {
                e.PrintFullName();
            }

            FullTimePolEmployee FTE = new FullTimePolEmployee();
            FTE.PrintFullName();
            */

            List<EmployeeDelegateTest> empList = new List<EmployeeDelegateTest>();

            empList.Add(new EmployeeDelegateTest() { Id = 101, Name = "Adeolu Adeyemi", Experience = 7, Salary = 7000 });
            empList.Add(new EmployeeDelegateTest() { Id = 102, Name = "Bukola Adeyemi", Experience = 4, Salary = 4000 });
            empList.Add(new EmployeeDelegateTest() { Id = 103, Name = "Enitan Adeyemi", Experience = 1, Salary = 1000 });

            IsPromotable isPromotable = new IsPromotable(Promote); 

            EmployeeDelegateTest.PromoteEmployee(empList, isPromotable);
        }
    }
}
