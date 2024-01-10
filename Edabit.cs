using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace c__console_test_project
{
    public class Edabit
    {
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = num * (i + 1);
            };
            return result;
        }
    }
}