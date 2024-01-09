using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__console_test_project
{
    public class ReverseStringClass
    {
        public static string ReverseString(string inputString)
        {
            char[] charsArr = inputString.ToCharArray();
            Array.Reverse(charsArr);

            return new string(charsArr);
        }
    }
}