﻿List<int> numbers = Console.ReadLine()
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