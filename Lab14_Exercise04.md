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

![4](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/dd7a48c5-f634-484a-acda-b5fa546a5df6)

สามารถ Build ได้ เพราะ Method Print ใน Class Generic

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![4 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/8ce8a7be-de34-4580-9a41-93d9930d2112)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ System.Console.WriteLine() โดยใช้ค่าของพารามิเตอร์ T ที่รับเข้ามาในเมท็อด

โปรแกรมแสดง

10

Hello World

12345.678
