using FizzBuzz.Common;
using System;
using System.Collections.Generic;

namespace FizzBuzz.Logic
{
    public class FizzBuzzIterator : IFizzBuzzIterator
    {
        private readonly IFizzBuzzLogic _fizzBuzzLogic;
        private readonly IOrderListOfNumber _orderListOfNumber;

        public FizzBuzzIterator(IFizzBuzzLogic fizzBuzzLogic, IOrderListOfNumber orderListOfNumber)
        {
            _fizzBuzzLogic = fizzBuzzLogic ?? throw new ArgumentNullException(nameof(fizzBuzzLogic));
            _orderListOfNumber = orderListOfNumber ?? throw new ArgumentNullException(nameof(orderListOfNumber));

        }

        public List<FizzBuzzResult> GetFizzBuzzResult(int value1, int value2)
        {
            var listOfNum = _orderListOfNumber.orderListOfNUmber(value1, value2);
            var response = new List<FizzBuzzResult>();

            foreach (var num in listOfNum)
            {
                var fizzBUzzRecord = new FizzBuzzResult
                {
                    Result = _fizzBuzzLogic.ExecuteFizzBuzzValue(num),
                    Number = num
                };

                response.Add(fizzBUzzRecord);
            }

            return response;
        }
    }
}
