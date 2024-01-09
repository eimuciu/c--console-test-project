using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__console_test_project
{
    public class UniqueCharacters
    {

        public static string Level1FirstNonRepeatedChar(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[i + 1])
                {
                    i++;
                }
                else
                {
                    return text[i].ToString();
                }
            }
            return "";
        }

        public static string Level2FirstUniqueChar(string text)
        {
            int occurences;
            foreach (char c in text)
            {
                occurences = 0;
                foreach (char b in text)
                {
                    if (c == b)
                    {
                        occurences++;
                    }
                }
                if (occurences == 1)
                {
                    return c.ToString();
                }
            }

            return "";
        }

    }
}