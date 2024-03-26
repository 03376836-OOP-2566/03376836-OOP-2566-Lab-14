# Lab 14 Exercise 10

## Generic stack

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex10
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
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
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex10
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="602" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/29d9d0d1-806d-40c5-aae6-43a27d92e778">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="516" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/b49cc90a-46b2-4f41-8852-32fe5c61703b">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Push planets (Mercury to Pluto) into stack

Items in stack:

Pluto

Neptune

Uranus

Saturn

Jupiter

Mars

Earth

Venus

Mercury

Remove first item in queue : Pluto

Remaining items in queue:

Neptune

Uranus

Saturn

Jupiter

Mars

Earth

Venus

Mercury
