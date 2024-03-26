# Lab 14 Exercise 9

## Generic queue

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex09
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
using System;
using System.Collections.Generic;

Queue<string> planets = new Queue<string>();

System.Console.WriteLine("Add planets (Mercury to Pluto)");
planets.Enqueue("Mercury");
planets.Enqueue("Venus");
planets.Enqueue("Earth");
planets.Enqueue("Mars");
planets.Enqueue("Jupiter");
planets.Enqueue("Saturn");
planets.Enqueue("Uranus");
planets.Enqueue("Neptune");
planets.Enqueue("Pluto");

System.Console.WriteLine("Items in queue:");
foreach (var item in planets)
{
    System.Console.WriteLine(item);
}

System.Console.Write("Remove first item in queue : ");
var removeItem = planets.Dequeue();
System.Console.WriteLine(removeItem);

System.Console.WriteLine("Remaining items in queue:");
foreach (var item in planets)
{
    System.Console.WriteLine(item);
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex09
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="521" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/49b6b30c-d8e0-4c74-b073-cdde8988932f">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="457" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/0981914d-f9bf-4865-bbb3-263f6a45ad5f">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Add planets (Mercury to Pluto) -Items in queue:

Mercury

Venus

Earth

Mars

Jupiter

Saturn

Uranus

Neptune

Pluto

Remove first item in queue : Mercury

Remaining items in queue:

Venus

Earth

Mars

Jupiter

Saturn

Uranus

Neptune

Pluto
