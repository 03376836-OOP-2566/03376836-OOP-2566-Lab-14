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

![9](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/22adf58e-1298-4518-9a0c-11fac42744e2)

สามารถ Build ได้ เพราะ ใช้ System.Collections.Generic ในการทำ Queue< string > แบบ Generic

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![9 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/6a0d8370-3346-4abd-abf3-b1e9f2e7d519)

7.อธิบายสิ่งที่พบในการทดลอง
สามารถ Run ได้ เพราะ ชื่อของดาวเคราะห์ทั้งหมดที่เพิ่มเข้าไปใน Queue โดยใช้ลูป foreach เพื่อวนลูปผ่านข้อมูลทั้งหมดใน Queue

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
