using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp.Classes
{
    public class EmployeePolyMorphism
    {
        public string FirstName = "FN";
        public string LastName = "LN";

        public virtual void PrintFullName()
        {
            Console.WriteLine($"Name is {FirstName} {LastName}");
        }
    }

    public class FullTimePolEmployee : EmployeePolyMorphism
    {
        public new void PrintFullName()
        {
            Console.WriteLine($"Name is {FirstName} {LastName} - Full Time Employee");
        }

    }
    public class PartTimePolEmployee : EmployeePolyMorphism
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Name is {FirstName} {LastName} - Part Time Employee");
        }
    }
    public class TemporaryPolEmployee : EmployeePolyMorphism
    {
        public override void PrintFullName()
        {
            Console.WriteLine($"Name is {FirstName} {LastName} - Temporary Employee");
        }
    }
}
