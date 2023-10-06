namespace GenericArrayCreator
{

    public class StartUp
    {
        static void Main()
        {
            string[] list = ArrayCreator.Create(300, "Paco");

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
