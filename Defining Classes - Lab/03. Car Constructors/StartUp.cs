using CarManufacture;
using Microsoft.VisualBasic;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            Console.WriteLine("Hi");
            Car car1 = new Car();
            Car car2 = new Car("BMW","X3",2006);
            Car car3 = new Car("BMW", "X3", 2006,500,300);

            car3.Drive(5);
            Console.WriteLine(car3.WhoAmI());
        }
    }
}