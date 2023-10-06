namespace DefiningClasses;
public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Person()
    {
        this.name = "No name";
        this.age = 1;
    }
    public Person(int age) :this()
    {
        this.name = "No name";
        this.age = age;
    }
    public Person(string name, int age) : this(age)
    {
        this.name = name;
        this.age = age;
    }
}