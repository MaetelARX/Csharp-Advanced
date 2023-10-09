using System.Text;

namespace _06GenericCountMethodDouble
{
    public class StartUp
    {
        static void Main()
        {
            Box<double> box = new Box<double>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                box.Add(double.Parse(Console.ReadLine()));
            }
            double input = double.Parse(Console.ReadLine());

            Console.WriteLine(box.result(input));
        }
    }
}