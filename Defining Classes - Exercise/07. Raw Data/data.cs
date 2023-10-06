namespace RawData;
public class Car
{
    private string model;
    private Engine engine;
    private Cargo cargo;
    private Tire[] tires;
    public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
        Tires = tires;
    }

    public string Model { get { return model; } set { model = value; } }
    public Engine Engine { get { return engine; } set { engine = value; } }
    public Cargo Cargo { get { return cargo; } set { cargo = value; } }
    public Tire[] Tires { get { return tires; } set { tires = value; } }
}
public class Cargo
{
    public Cargo(int cargoWeight, string cargoType)
    {
        Type = cargoType;
        Weight = cargoWeight;
    }

    public string Type { get; set; }
    public int Weight { get; set; }
}
public class Engine
{
    public Engine(int engineSpeed, int enginePower)
    {
        Speed = engineSpeed;
        Power = enginePower;
    }

    public int Speed { get; set; }
    public int Power { get; set; }
}
public class Tire
{
    public Tire(int age, double pressure)
    {
        Age = age;
        Pressure = pressure;
    }

    public int Age { get; set; }
    public double Pressure { get; set; }
}