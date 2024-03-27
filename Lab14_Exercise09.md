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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/96829703-3026-4119-b46d-62c79b6c3b58)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex09
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/6fd4533b-51a2-48d8-b0e9-ef2f205be3b4)
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/3648cf2e-0324-4bc5-bfc0-cdfc0cc6a54f)


7.อธิบายสิ่งที่พบในการทดลอง
- ใช้งาน Generic Queue เพื่อเก็บข้อมูลเกี่ยวกับดาวเคราะห์ 
- จัดเก็บข้อมูลเป็นลำดับตามลำดับที่เข้ามา หรือ FIFO (First-In-First-Out) โดยไม่ต้องกังวลเรื่องประสิทธิภาพของการเข้าถึงข้อมูลแต่ละตัวใน Queue นั้นๆ
