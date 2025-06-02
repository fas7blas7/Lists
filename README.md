1️⃣ SortProducts 🛍️  
Namespace: _01.SortProducts  
📌 Description:  
Reads a number `n`, then reads `n` product names into a list. Sorts them alphabetically and prints them with a numbered index.

📝 Code:

```csharp
namespace _01.SortProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> list = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                list.Add(product);
            }

            list.Sort();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{list[i]}");
            }
        }
    }
}
```
2️⃣ ChangeList 🧾
Namespace: _02.ChangeList
📌 Description:
Reads a list of integers and processes commands:

Delete X: removes all occurrences of X

Insert X Y: inserts X at position Y
Ends with the command "end".

📝 Code:

```csharp

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
```
3️⃣ RemoveNegativesAndReverse 🔄
Namespace: _03.RemoveNegativesAndReverse
📌 Description:
Reads a list of integers, removes all negative numbers, reverses the remaining list, and prints it. If the list is empty after filtering, prints "empty".

📝 Code:

```csharp

List<int> numbers = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToList();

for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] < 0)
    {
        numbers.RemoveAt(i);
        i--;
    }
}
numbers.Reverse();
if (numbers.Count == 0)
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine(string.Join(" ", numbers));
}

```
📅 Commit Progress Update:

📅 Current Progress: 438 commits
📊 Progress Bar:
█████████████████████████████████████████▉87.6% (438/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
✅ 400 commits
🔲 500 commits (🎉)

🎯 Commit Progress Tracker
🚀 Goal: 500 commits in 2025
