using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Common
{
    public interface IFizzBuzzIterator
    {
        List<FizzBuzzResult> GetFizzBuzzResult(int value1, int value2);
    }
}
