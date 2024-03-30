using System;
using System.Collections.Generic;

Stack<string> planets = new Stack<string>();

System.Console.WriteLine("Push planets (Mercury to Pluto) into stack");
planets.Push("Mercury");
planets.Push("Venus");
planets.Push("Earth");
planets.Push("Mars");
planets.Push("Jupiter");
planets.Push("Saturn");
planets.Push("Uranus");
planets.Push("Neptune");
planets.Push("Pluto");

System.Console.WriteLine("Items in stack:");
foreach (var item in planets)
{
    System.Console.WriteLine(item);
}

System.Console.Write("Remove first item in queue : ");
var popItem = planets.Pop();
System.Console.WriteLine(popItem);

System.Console.WriteLine("Remaining items in queue:");
foreach (var item in planets)
{
    System.Console.WriteLine(item);
}