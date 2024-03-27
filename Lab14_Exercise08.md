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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/cf3512e9-00cd-4417-9c8e-b27a6cc0e354)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex08
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/6eb44c4b-9804-4e7f-b413-79c32a0c474c)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้งาน Generic Queue Import namespace System.Collections.Generic เพื่อใช้งานคลาส Queue แบบ Generic 
- ประกาศ Queue ชื่อ numbers โดยกำหนดประเภทข้อมูลเป็น int
- เพิ่มข้อมูลเข้าไปใน Queue ด้วยเมทอด Enqueue() โดยใส่ค่าตัวเลข 5, 10, และ 15 ลูป foreach เพื่อแสดงผลลัพธ์ของข้อมูลใน Queue
- ใช้เมทอด Dequeue() เพื่อลบข้อมูลตัวแรก
- สดงผลลัพธ์ของข้อมูลที่เหลือใน Queue หลังจากที่ลบข้อมูลตัวแรกออกไปด้วยการใช้ลูป foreach
