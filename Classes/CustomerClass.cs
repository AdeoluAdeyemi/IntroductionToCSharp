using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp.Classes
{
    /// <summary>
    /// Customer Class to test and understand what classes are 
    /// in C#
    /// </summary>
    class CustomerClass
    {
        private readonly string firstName;
        private readonly string lastname;

        /// <summary>
        /// Constructor for the class Customer. The constructor initializes the class 
        /// with the customer's firstname and lastname
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="Lastname"></param>
        public CustomerClass(string FirstName, string Lastname)
        {
            this.firstName = FirstName;
            this.lastname = Lastname;
        }

        public void PrintCustomerName()
        {
            Console.WriteLine($"Welcome {firstName} {lastname} to C# Programming");
        }
    }
}
