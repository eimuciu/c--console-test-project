using System.Text;
using c__console_test_project;

class MyTestClass
{



    static void Main(string[] args)

    {
        // UniqueCharacters Class
        Console.WriteLine(UniqueCharacters.Level2FirstUniqueChar("aabbccddkeeff"));
        // DateComparison Class
        Console.WriteLine(DateComparisons.Level1YearsBetween("1200-04-12", "1500-06-15"));
        string one = "one";
        string two = "two";
        string three = one + "," + two;

StringBuilder sbTemp = new StringBuilder("Hi", 50);
sbTemp.Append("Hej!");
sbTemp.AppendLine("Hello!!");
sbTemp.AppendLine("I am here for you!");
Console.WriteLine(sbTemp);

    }
}

