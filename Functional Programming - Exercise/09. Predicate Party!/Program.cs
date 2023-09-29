List<Predicate<string>> predicates = new();            //creating a list of predicates

List<string> listOfPeople = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .ToList();

string command;
string endCommand = "Party!";
while ((command = Console.ReadLine()) != endCommand)
{
    string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string cmdType = cmdArg[0];
    string filter = cmdArg[1];
    string value = cmdArg[2];

    if (cmdType == "Remove")
    {
        listOfPeople.RemoveAll(CheckRequirements(filter, value));          
    }
    else if (cmdType == "Double")
    {
        List<string> peopleToDouble = listOfPeople.FindAll(CheckRequirements(filter, value));      

        foreach (string person in peopleToDouble)
        {
            int index = listOfPeople.IndexOf(person);           

            listOfPeople.Insert(index, person);                
        }
    }
}

if (listOfPeople.Any())
{
    Console.WriteLine($"{string.Join(", ", listOfPeople)} are going to the party!");
}
else
{
    Console.WriteLine("Nobody is going to the party!");
}

static Predicate<string> CheckRequirements(string filter, string value)
{
    switch (filter)
    {
        case "StartsWith":
            return p => p.StartsWith(value);                
        case "EndsWith":
            return p => p.EndsWith(value);                  
        case "Length":
            return p => p.Length == int.Parse(value);      
        default:
            return default;
    }
}