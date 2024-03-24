# Lab 14 Exercise 4

## Generic method

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex04
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Generic method
Generic.Print(10);
Generic.Print("Hello World");
Generic.Print(12345.678);


public static class Generic
{
    public static void Print <T> (T value)
    {
        System.Console.WriteLine(value);
    }   
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex04
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="447" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 37 21" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/a1a140d1-db7f-410e-8f6f-f2d1824698a7">
### สามารถ Build ได้ เพราะ Method Print ใน Class Generic
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="455" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 37 36" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/f30950a2-5b29-4039-b711-ec8858f846c2">
### สามารถ Run ได้ เพราะ System.Console.WriteLine() โดยใช้ค่าของพารามิเตอร์ T ที่รับเข้ามาในเมท็อด
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### 10
### Hello World
### 12345.678
