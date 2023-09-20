Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

string command = Console.ReadLine();
while (command != "Revision")
{
    string[] parts = command.Split(", ");

    string shop = parts[0];
    string product = parts[1];
    double price = double.Parse(parts[2]);

    if (!shops.ContainsKey(shop))
    {
        shops.Add(shop, new Dictionary<string, double>());
    }
    shops[shop].Add(product, price);

    command = Console.ReadLine();
}

foreach(var item in shops.OrderBy(s => s.Key))
{
    Console.WriteLine(item.Key + "->");
    foreach(var product in item.Value)
    {
        Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
    }
}