﻿int n = int.Parse(Console.ReadLine());

List<string> list = new List<string>();

for (int i = 0; i < n; i++)
{
    string product = Console.ReadLine();
    list.Add(product);
}

list.Sort();

for (int i = 0; i < list.Count; i++)
{
    Console.WriteLine($"{i+1}.{list[i]}");
}