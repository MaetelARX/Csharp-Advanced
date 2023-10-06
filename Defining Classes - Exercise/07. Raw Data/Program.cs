﻿using RawData;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Car> cars = new List<Car>();
        List<Tire> tires = new();
        List<Engine> engines = new List<Engine>();
        List<Cargo> cargos = new List<Cargo>();

        int numOfCars = int.Parse(Console.ReadLine());
        for (int i = 0; i < numOfCars; i++)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string model = input[0];

            int engineSpeed = int.Parse(input[1]);
            int enginePower = int.Parse(input[2]);
            Engine engine = new Engine(engineSpeed, enginePower);
            engines.Add(engine);

            int cargoWeight = int.Parse(input[3]);
            string cargoType = input[4];
            Cargo cargo = new Cargo(cargoWeight, cargoType);
            cargos.Add(cargo);

            for (int k = 5; k <= 12; k += 2)
            {
                double pressure = double.Parse(input[k]);
                int age = int.Parse(input[k + 1]);
                var newTire = new Tire(age, pressure);
                tires.Add(newTire);
            }

            Car car = new Car(model, engine, cargo, tires.ToArray());
            cars.Add(car);
        }

        string typeOfCar = Console.ReadLine();
        Predicate<Tire[]> tiresPressure = tires =>
        {
            for (int i = 0; i < tires.Length; i++)
            {
                if (tires[i].Pressure < 1)
                {
                    return true;
                }
            }

            return false;
        };
        cars = cars.Where(c => c.Cargo.Type == typeOfCar).ToList();

        foreach (var car in cars)
        {
            if (tiresPressure(car.Tires) && typeOfCar == "fragile")
            {
                Console.WriteLine(car.Model);
            }
            else if (typeOfCar == "flammable" && car.Engine.Power > 250)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}