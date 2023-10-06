using DefiningClasses;

internal class StartUp
{
    private static void Main(string[] args)
    {
        int countOfPeople = int.Parse(Console.ReadLine());

        Person person = new Person();
        for (int i = 0; i < countOfPeople; i++)
        {

            string[] cmdArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string name = cmdArg[0];
            int age = int.Parse(cmdArg[1]);

            person.Name = name;
            person.Age = age;

            var member = new Person(cmdArg[0], int.Parse(cmdArg[1]));

            if (age > 30)
            {
                person.Add(member);
            }
        }
        var ordered = person.list.OrderBy(x => x.Name);
        foreach (var item in ordered)
        {
            Console.WriteLine($"{item.Name} - {item.Age}");
        }
    }
}