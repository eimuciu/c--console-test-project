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

        Dictionary<int, string> Students = new() {
            {1, "Milan"},
            {2, "Stefan"},
            {3, "Pavle"}
        };

        KeyValuePair<int, string> SingleStudent = new KeyValuePair<int, string>(1, "Suzzy");
        // Checks if SingleStudent is empty
        // SingleStudent.Equals(default(KeyValuePair<int, string>));
    }
}

