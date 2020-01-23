using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductionToCSharp
{
    class EvenNumbers
    {
        public EvenNumbers()
        {
            CalculateEvenNumbers();
        }

        private void CalculateEvenNumbers()
        {
            int Number = 0;
            string Result = "";

            Console.WriteLine("Please enter your target?");

            int UserNumber = 0;

            if (int.TryParse(Console.ReadLine(), out UserNumber))
            {
                while (Number <= UserNumber)
                {
                    if (Number % 2 == 0)
                    {
                        Result += Number + " ";
                    }
                    Number++;
                }

                Console.WriteLine(Result);
            }
            else
            {
                Console.WriteLine("Invalid Number. Please enter a valid number");
            }
        }
    }
}
