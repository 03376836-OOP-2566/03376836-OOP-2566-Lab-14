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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/302ea8af-9a55-4982-ac69-4413eb63a638)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex10
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/e873327c-1850-4cd0-9d1f-c1d2fafab59e)

7.อธิบายสิ่งที่พบในการทดลอง

โค้ดนี้แสดงการใช้ Stack ในภาษา C# เพื่อจัดเก็บและจัดการข้อมูลแบบเข้าหลังออกก่อน (LIFO) โดยข้อมูลที่เข้าสู่ Stack ล่าสุดจะออกจาก Stack ก่อน

โค้ดสร้าง Stack ชื่อ planets เพื่อเก็บข้อมูลชื่อดาวเคราะห์
โค้ดใช้ Push เพิ่มชื่อดาวเคราะห์ 9 ดวง (พุธ ถึง พลูโต) เข้าไปใน Stack โดยดาวเคราะห์ที่เพิ่มล่าสุดจะอยู่บนสุดของ Stack
โค้ดใช้ foreach วนซ้ำเพื่อแสดงชื่อดาวเคราะห์ทั้งหมดที่มีอยู่ใน Stack แต่ลำดับอาจไม่ตรงกับลำดับที่เพิ่มเข้าไป เนื่องจาก Stack เรียงลำดับแบบ LIFO
โค้ดใช้ Pop ลบชื่อดาวเคราะห์ที่อยู่บนสุดของ Stack ออก ซึ่งก็คือดาวเคราะห์ที่เพิ่งเพิ่มเข้าไปล่าสุด
โค้ดใช้ foreach วนซ้ำเพื่อแสดงชื่อดาวเคราะห์ที่เหลืออยู่ใน Stack

ลำดับของดาวเคราะห์ที่แสดงผลอาจไม่ตรงกับลำดับที่เพิ่มเข้าไปใน Stack
Stack เรียงลำดับข้อมูลแบบ LIFO (เข้าหลังออกก่อน)
