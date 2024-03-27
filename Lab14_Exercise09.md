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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/4d737f2c-03c6-4e60-9028-0098abfa3413)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/23e0e23f-8ed2-49bf-b6e7-8747c2a84d2c)

7.อธิบายสิ่งที่พบในการทดลอง
การทดลองนี้เป็นการใช้งาน Queue<T> ใน C# ซึ่งเป็นโครงสร้างข้อมูลแบบ FIFO (First-In-First-Out) ที่ใช้สำหรับจัดเก็บข้อมูลในลำดับที่เข้ามาก่อนถูกนำออกก่อนด้วยคำสั่ง Enqueue และ Dequeue
