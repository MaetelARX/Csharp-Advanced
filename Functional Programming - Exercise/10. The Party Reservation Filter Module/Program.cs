List<Predicate<string>> predicates = new();                             
Dictionary<string, Predicate<string>> listOfPredicates = new();        
List<string> listOfPoeple = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;
string endCommand = "Print";
while ((command = Console.ReadLine()) != endCommand)
{
    string[] cmdArg = command.Split(";");
    string cmdType = cmdArg[0];
    string filter = cmdArg[1];
    string value = cmdArg[2];

    if (cmdType == "Add filter")
    {
        listOfPredicates.Add(filter + value, GetPredicate(filter, value));      
    }
    else if (cmdType == "Remove filter")
    {
        listOfPredicates.Remove(filter + value);                                
    }
}

foreach (var predicate in listOfPredicates)
{
    listOfPoeple.RemoveAll(predicate.Value);
}                       

Console.WriteLine(string.Join(" ", listOfPoeple));

Predicate<string> GetPredicate(string filter, string value)
{
    switch (filter)
    {
        case "Starts with":
            return p => p.StartsWith(value);
        case "Ends with":
            return p => p.EndsWith(value);
        case "Length":
            return p => p.Length == int.Parse(value);
        case "Contains":
            return p => p.Contains(value);
        default:
            return default;
    }
}