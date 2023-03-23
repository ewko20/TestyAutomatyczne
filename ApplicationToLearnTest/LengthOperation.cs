using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationToLearnTest
{
    public class LengthOperation : ILengthOperation
    {
        public bool CompareLength(string text1, string text2)
        {
            if (text1 == null || text2 == null)
            {
                throw new Exception();
            }

            else if (text1.Length == text2.Length)
            {
                return true;
            }
            return false;
        }
    }
}
