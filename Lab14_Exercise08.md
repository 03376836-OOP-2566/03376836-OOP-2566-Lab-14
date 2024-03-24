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
<img width="446" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 57 29" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/5fb36ab5-c092-4410-b766-5191c44f30ff">
### สามารถ Build ได้ เพราะ ใช้ System.Collections.Generic ในการทำ Queue< int > แบบ Generic
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="462" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 57 42" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/685c1835-679e-4d59-a04e-dd7350588b72">
### สามารถ Run ได้ เพราะ แสดงข้อมูลทั้งหมดใน Queue โดยใช้ foreach เพื่อวนลูปผ่านข้อมูลทั้งหมดใน Queue
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Add 3 elements (5, 10, 15)
### Items in queue:
### 5
### 10
### 15
### Remove first item in queue : 5
### Remaining items in queue:
### 10
### 15
