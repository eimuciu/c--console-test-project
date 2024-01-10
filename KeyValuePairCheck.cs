using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__console_test_project
{
    public class KeyValuePairCheck
    {

        public static bool CheckIfKeyValuePairIsEmpty()
        {
            KeyValuePair<int, string> SingleStudent = new KeyValuePair<int, string>(1, "Suzzy");

            if (SingleStudent.Equals(default(KeyValuePair<int, string>)))
            {
                return true;
            }
            ;
            return false;
        }


    }
}