using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c__console_test_project
{
    public class DateComparisons
    {
        public static int Level1YearsBetween(string date1, string date2)
        {
            TimeSpan difference;

            DateTime first = DateTime.Parse(date1);
            DateTime second = DateTime.Parse(date2);

            if (first > second)
            {
                difference = first.Subtract(second);
            }
            else
            {
                difference = second.Subtract(first);
            }

            DateTime finalDate = new DateTime().Add(difference);
            return finalDate.Year - 1;
        }

        public static int Level2DaysBetween(string date1, string date2)
        {
            TimeSpan difference;

            DateTime first = DateTime.Parse(date1);
            DateTime second = DateTime.Parse(date2);

            if (first > second)
            {
                difference = first.Subtract(second);
            }
            else
            {
                difference = second.Subtract(first);
            }
            return difference.Days;
        }
    }
}