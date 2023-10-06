using _06._SpeedRacing;
using System;

int n = int.Parse(Console.ReadLine());

List<Car> cars = new List<Car>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    string model = input[0];
    double fuelAmount = double.Parse(input[1]);
    double fuelConsumption = double.Parse(input[2]);

    Car car = new Car(model, fuelAmount, fuelConsumption, 0);

    cars.Add(car);
}

foreach(var item in cars)
{
    Console.WriteLine(string.Join(" ",item.Model));
}

while (true)
{
    string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

    if (input[0] == "End")
    {
        break;
    }
    string carModel = input[1];
    double amountOfKm = double.Parse(input[2]);

    foreach (var model in cars)
    {
        if (carModel == model.Model)
        {
            model.Drive(amountOfKm);
            break;
        }
    }
}

Console.WriteLine(string.Join(System.Environment.NewLine, cars));