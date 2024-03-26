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

![10](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/9f2f382c-2d95-4fdb-bb0e-221bafba31ee)

สามารถ Build ได้ เพราะ เพราะ ใช้ System.Collections.Generic ในการทำ Stack< string > แบบ Generic เพื่อสร้าง Stack ที่รับข้อมูลประเภท string

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![10 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/b6a0ac6b-270e-4843-b6fa-28945f8e7bd2)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ ชื่อของดาวเคราะห์ทั้งหมดที่เพิ่มเข้าไปใน Stack โดยใช้ลูป foreach เพื่อวนลูปผ่านข้อมูลทั้งหมดใน Stack

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
