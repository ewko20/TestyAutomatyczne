using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationToLearnTest
{
    public class CalculatorClass
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }

        public int Add()
        {
            return Number1 + Number2;
        }

        public float Divide()
        {
            try
            {
                return Number1 / Number2;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Multiply()
        {
            return Number1 * Number2;
        }

        public int Substruct()
        {
            return Number1 - Number2;
        }
    }
}
