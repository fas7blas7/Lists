List<int> numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

string input = Console.ReadLine();
while (input != "end")
{
    string[] cmndArg = input.Split(' ');

    string command = cmndArg[0];
    if (command == "Delete")
    {
        int elementToRemove = int.Parse(cmndArg[1]);

        for(int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] == elementToRemove)
            {
                numbers.RemoveAt(i);
                i--;
            }
        }
    }
    else if (command == "Insert")
    {
        int element = int.Parse(cmndArg[1]);
        int index = int.Parse(cmndArg[2]);

        numbers.Insert(index, element);
    }

    input = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", numbers));