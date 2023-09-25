int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

for(int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split().ToArray();

    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!studentGrades.ContainsKey(name))
    {
        studentGrades.Add(name, new List<decimal>());
    }
    studentGrades[name].Add(grade);
}
foreach(var item in studentGrades)
{
    string name = item.Key;
    List<decimal>grade = item.Value;
    decimal average = grade.Average();

    Console.WriteLine($"{name} -> {string.Join(" ", grade.Select(grade => $"{grade:F2}"))} (avg: {average:F2})");
}