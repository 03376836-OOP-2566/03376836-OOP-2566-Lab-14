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

![8](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/d7d44ef4-2c4f-4828-9758-35559a4a4419)

สามารถ Build ได้ เพราะ ใช้ System.Collections.Generic ในการทำ Queue< int > แบบ Generic

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![8 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/d980a02e-2b57-42e5-9b42-2ca8d044f218)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ แสดงข้อมูลทั้งหมดใน Queue โดยใช้ foreach เพื่อวนลูปผ่านข้อมูลทั้งหมดใน Queue

โปรแกรมแสดง

Add 3 elements (5, 10, 15)

Items in queue:

5

10

15

Remove first item in queue : 5

Remaining items in queue:

10

15
