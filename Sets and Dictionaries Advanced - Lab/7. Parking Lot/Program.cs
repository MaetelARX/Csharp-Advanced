string[] command = Console.ReadLine().Split(", ").ToArray();

int count = 0;

HashSet<string> car = new HashSet<string>();

while(command[0] != "END")
{
    string newcommand = command[0];
    string number = command[1];

    if (newcommand == "IN")
    {
        car.Add(number);
        count++;
    }
    else if (newcommand == "OUT")
    {
        car.Remove(number);
        count--;
    }
    command = Console.ReadLine().Split(", ").ToArray();
}
if (count <= 0)
{
    Console.WriteLine("Parking Lot is Empty");
    return;
}
foreach(var item in car)
{
    Console.WriteLine(item);
}