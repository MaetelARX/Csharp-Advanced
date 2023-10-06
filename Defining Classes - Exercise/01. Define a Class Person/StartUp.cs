using DefiningClasses;
public class StartUp
{
    private static void Main(string[] args)
    {
        Person person1 = new Person();

        person1.Name = "Peter";
        person1.Age = 20;

        Console.WriteLine($"{person1.Name} is {person1.Age} years old");

        Person person2 = new Person();

        person2.Name = "Vasil";
        person2.Age = 40;

        Console.WriteLine($"{person2.Name} is {person2.Age} years old");

        Person person3 = new Person();

        person3.Name = "Tostera";
        person3.Age = 60;

        Console.WriteLine($"{person3.Name} is {person3.Age} years old");
    }
}