using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    class CoffeeShop
    {
        public CoffeeShop()
        {
            ProcessOrder();
        }
       
        public static void ProcessOrder()
        {
            int TotalCoffeeCost = 0;

            SelectChoice:

            Console.WriteLine("Select 1 - Small, 2 - Medium, 3 - Large");

            int UserChoice = 0;
            
            if (int.TryParse(Console.ReadLine(), out UserChoice)){

                switch (UserChoice)
                {
                    case 1:
                        TotalCoffeeCost += 100;
                        break;
                    case 2:
                        TotalCoffeeCost += 200;
                        break;
                    case 3:
                        TotalCoffeeCost += 300;
                        break;
                    default:
                        Console.WriteLine("Choice is invalid. Try again");
                        goto SelectChoice;
                }

                Console.WriteLine("Do you want to purchase another coffee? Yes or No");

                string UserResponse = Console.ReadLine();

            ReProcessResponse:
                switch (UserResponse.ToLower())
                {
                    case "yes":
                        goto SelectChoice;
                    case "no":
                        break;
                    default:
                        Console.WriteLine("Invalid choice selected. Please try again");
                        goto ReProcessResponse;
                }

                Console.WriteLine("Thank you for shopping with us");
                Console.WriteLine($"Bill Amount: #{TotalCoffeeCost}. \n Good Bye");
            }
            else
            {
                Console.WriteLine("Invalid choice selected");
                goto SelectChoice;
            }


        }
    }
}
