int n = int.Parse(Console.ReadLine());

List<string> list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

bool condition = true;

Func<List<string>, int, bool> func = Result;

func(list, n);

static bool Result(List<string> names, int input)
{
    for(int i = 0; i < names.Count; i++)
    {
        int sum = 0;
        foreach(int item in names[i])
        {
            sum += item;
            if(sum >= input)
            {
                Console.WriteLine(names[i]);
                return true;
            }
        }
    }
    return true;
}