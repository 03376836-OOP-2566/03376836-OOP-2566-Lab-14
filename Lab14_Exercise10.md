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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/964a7685-020c-469c-a812-cb9a610002cc)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/210e7622-62c7-4f41-94ed-231f76c0e9b5)
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/8464ad46-5439-4e6a-9fec-69bce05a1f37)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้งาน Generic Stack เพื่อเก็บข้อมูลเกี่ยวกับดาวเคราะห์ 
สร้าง Stack โดยใช้ new Stack<string>() เพื่อสร้าง Stack ที่รองรับข้อมูลชนิด string
เพิ่มข้อมูลใน Stack ด้วยเมทอด Push()
แสดงผลลัพธ์ของข้อมูลใน Stack ด้วยลูป foreach
ใช้เมทอด Pop() เพื่อลบและเรียกค่าข้อมูลตัวบนสุดออกจาก Stack
แสดงผลลัพธ์ของข้อมูลที่เหลือใน Stack หลังจากการลบข้อมูลด้วยลูป foreach
- จัดเก็บข้อมูลเป็นลำดับที่ย้อนกลับจากลำดับที่เข้ามา หรือ LIFO (Last-In-First-Out) โดยไม่ต้องกังวลเรื่องประสิทธิภาพของการเข้าถึงข้อมูลแต่ละตัวใน Stack นั้นๆ
