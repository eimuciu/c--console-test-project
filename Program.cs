using System.Text;
using System.Text.Json;
using c__console_test_project;

class MyTestClass
{
    static void Main(string[] args)
    {
        // UniqueCharacters Class
        Console.WriteLine(UniqueCharacters.Level2FirstUniqueChar("aabbccddkeeff"));
        // DateComparison Class
        Console.WriteLine(DateComparisons.Level1YearsBetween("1200-04-12", "1500-06-15"));
        // KeyValuePairCheck Class
        Console.WriteLine(KeyValuePairCheck.CheckIfKeyValuePairIsEmpty());
        // ReverseString Class
        Console.WriteLine(ReverseStringClass.ReverseString("abcdefg"));
        // Edabit
        var resultOfMultiples = Edabit.ArrayOfMultiples(5, 10);
        Console.WriteLine(JsonSerializer.Serialize(resultOfMultiples));
    }
}

