using FizzBuzz.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Logic
{
   internal class OrderNumberListLogic : IOrderListOfNumber
    {
      
        List<int> IOrderListOfNumber.orderListOfNUmber(int hightestValue, int lowestValue)
        {
            var maxNumber = hightestValue;
            var minNumber = lowestValue;

            if (maxNumber < minNumber)
            {
                minNumber = hightestValue;
                maxNumber = lowestValue;
            }

            var response = new List<int>();

            for (int i = minNumber; i <= maxNumber; i++)
            {
                response.Add(i);
            }
            return response;
        }
    }
}
