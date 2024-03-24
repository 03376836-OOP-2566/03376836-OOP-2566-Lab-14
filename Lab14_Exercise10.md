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
<img width="445" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 10 47" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/1e75566b-6573-412e-b7c5-4b220946c8e1">
### สามารถ Build ได้ เพราะ เพราะ ใช้ System.Collections.Generic ในการทำ Stack< string > แบบ Generic เพื่อสร้าง Stack ที่รับข้อมูลประเภท string
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="456" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 05 11 03" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/bf0128e0-434e-4a1e-ac9d-47187635647e">
### สามารถ Run ได้ เพราะ ชื่อของดาวเคราะห์ทั้งหมดที่เพิ่มเข้าไปใน Stack โดยใช้ลูป foreach เพื่อวนลูปผ่านข้อมูลทั้งหมดใน Stack
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Push planets (Mercury to Pluto) into stack
### Items in stack:
### Pluto
### Neptune
### Uranus
### Saturn
### Jupiter
### Mars
### Earth
### Venus
### Mercury
### Remove first item in queue : Pluto
### Remaining items in queue:
### Neptune
### Uranus
### Saturn
### Jupiter
### Mars
### Earth
### Venus
### Mercury
