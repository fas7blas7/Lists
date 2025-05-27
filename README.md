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
📅 Commit Progress Update:

📅 Current Progress: 432 commits
📊 Progress Bar:
███████████████████████████████████████▍86.4% (432/500)

📌 Milestones:
✅ 100 commits
✅ 200 commits
✅ 300 commits
✅ 400 commits
🔲 500 commits (🎉)

🎯 Commit Progress Tracker
🚀 Goal: 500 commits in 2025
