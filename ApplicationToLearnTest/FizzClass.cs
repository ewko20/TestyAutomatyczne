using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationToLearnTest
{
    public class FizzClass
    {
        public int Number { get; set; }
        public FizzClass(int number)
        {
            Number = number;
        }
        public string CheckFizzBuzz()
        {
            if (Number % 3 == 0 && Number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (Number % 3 == 0)
            {
                return "Fizz";
            }
            else if (Number % 5 == 0)
            {
                return "Buzz";
            }

            throw new Exception();

        }
    }
}
