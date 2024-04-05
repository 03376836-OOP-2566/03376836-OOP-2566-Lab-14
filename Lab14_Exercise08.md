# Lab 14 Exercise 8

## Generic queue

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex08
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
using System;
using System.Collections.Generic;

Queue<int> numbers = new Queue<int>();

System.Console.WriteLine("Add 3 elements (5, 10, 15)");
numbers.Enqueue(5); 
numbers.Enqueue(10); 
numbers.Enqueue(15);

System.Console.WriteLine("Items in queue:");
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}

System.Console.Write("Remove first item in queue : ");
var removeItem = numbers.Dequeue();
System.Console.WriteLine(removeItem);

System.Console.WriteLine("Remaining items in queue:");
foreach (var item in numbers)
{
    System.Console.WriteLine(item);
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex08
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/49e6b0fb-f0e7-4dd0-a3d7-d4cae0edba02)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/249d89cf-2c0f-4f56-96da-e6dc7439c7fc)

7.อธิบายสิ่งที่พบในการทดลอง


โค้ดสร้าง Queue ชื่อ numbers เพื่อเก็บข้อมูลตัวเลข
โค้ดใช้ Enqueue เพิ่ม 5, 10, 15 ลงใน Queue
โค้ดใช้ foreach วนซ้ำแสดงข้อมูลใน Queue
โค้ดใช้ Dequeue ลบข้อมูลตัวแรกออกจาก Queue
โค้ดใช้ foreach วนซ้ำแสดงข้อมูลที่เหลือใน Queue
โค้ดนี้สาธิตการใช้ Queue เพื่อเก็บและจัดการข้อมูลแบบ First-In-First-Out (FIFO) ซึ่งข้อมูลตัวแรกที่เข้าจะออกจาก Queue เป็นลำดับแรก โดยใช้เมธอด Enqueue และ Dequeue เพื่อเพิ่มและลบข้อมูลตามลำดับ
