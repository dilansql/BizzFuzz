using FizzBuzz.Common;
using System;

namespace FizzBuzz.Logic
{
    internal class FizzBuzzLogic : IFizzBuzzLogic
    {
        public FizzBuzzLogic() { }

        public string ExecuteFizzBuzzValue(int input)
        {
            var divisibleByThree = (input % 3 == 0);
            var divisibleByFive = (input % 5 == 0);
            var divisibleByThreeAndFive = (input % 3 == 0) && (input % 5 == 0);

            if (input == 0)
            {
                return input.ToString();
            }
            else if (divisibleByThreeAndFive)
            {
                return "FizzBuzz";
            }
            else if (divisibleByThree)
            {
                return "Fizz";
            }
            else if (divisibleByFive)
            {
                return "Buzz";
            } 
            else
            {
                return input.ToString();
            }

        }
    }
}

