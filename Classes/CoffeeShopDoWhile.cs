using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    class CoffeeShopDoWhile
    {
        public CoffeeShopDoWhile()
        {
            processOrder();
        }

        private void processOrder()
        {

            int TotalCoffeeCost = 0;
            string UserDecision = string.Empty;

            do
            {
                Console.WriteLine("1 - Small, 2 - Medium, 3 - Big");

                int UserChoice = 0;
                string UserInput = Console.ReadLine();

                if (int.TryParse(UserInput, out UserChoice))
                {
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
                            Console.WriteLine($"Invalid Input \"{UserInput}\". Please try again");
                            break;
                    }

                }

                do
                {
                    Console.WriteLine("Do you want to make another order? Yes or No");
                    UserDecision = Console.ReadLine();

                    if (UserDecision.ToLower() != "yes" && UserDecision.ToLower() != "no")
                        {
                            Console.WriteLine($"Invalid Input \"{UserDecision}\". Please try again");               
                        }
                }
                while (UserDecision.ToLower() != "yes" && UserDecision.ToLower() != "no");
            }
            while (UserDecision.ToLower() == "yes");

            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine($"Bill Amount: #{TotalCoffeeCost}");
        }

    }
}
