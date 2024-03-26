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


<img width="540" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/346dee28-d5b8-4522-958d-3a25a62636d3">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="518" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/f3a53d9c-6664-427c-bded-8bb5bb140917">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

10

Hello World

12345.678
