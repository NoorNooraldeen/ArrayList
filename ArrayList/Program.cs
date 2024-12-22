// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//part1
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
ArrayList fruit = new ArrayList();

fruit.Add("apple");
fruit.Add("bnana");
fruit.Add("cherry");


Console.WriteLine("iteams");
foreach(var item in fruit)
{
    Console.WriteLine(item);
}
fruit.Insert(2, "orang");
fruit.RemoveAt(2);
string search = Console.ReadLine();
if (fruit.Contains(search)== true)
{
    Console.WriteLine($" avalible.{ search}");
}
else
{
    Console.WriteLine("ot avalible.");
}
{ 
Console.WriteLine("enter an elemnt ");
string elemnt = Console.ReadLine();
int index = fruit.IndexOf(elemnt);
Console.WriteLine($"index: {index}");
}

Console.WriteLine($" number of elemnt is  {fruit.Count}");


//bounes 
