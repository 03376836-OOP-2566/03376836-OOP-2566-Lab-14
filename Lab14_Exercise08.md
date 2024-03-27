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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/b493d9e1-8723-4bd7-8326-70574c3ee39d)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/e65c9526-9580-4b41-86c7-eeb6f594bd2f)

7.อธิบายสิ่งที่พบในการทดลอง

การทดลองนี้เป็นการใช้งานคลาส Queue<T> ใน C# ซึ่งเป็นโครงสร้างข้อมูลแบบ First-In-First-Out (FIFO) โดยโค้ดที่ให้มาทำงาน

