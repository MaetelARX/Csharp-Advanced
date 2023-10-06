using System.ComponentModel;

namespace DefiningClasses;

public class Person
{
    public List<Person> list = new();
    private string name;
    private int age;

    public Person()
    {
        Name = "No name";
        Age = 1;
    }

    public Person(int age)
        : this()
    {
        Age = age;
    }

    public Person(string name, int age)
        : this(age)
    {
        Name = name;
    }
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public int Age { get { return age; } set { age = value; } }

    public void Add(Person member)
    {
        if (age > 30)
        {
            list.Add(member);
        }
    }
}