# Lab 14 Exercise 3

## Generic method

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex03
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Generic method
Generic.Show<int>("Integer", 123);
Generic.Show<float>("Floating point", 123.45f);
Generic.Show<decimal>("Decimal", 2345.67M);
Generic.Show<string>("String", "Hello World");


public static class Generic
{
    public static void Show <T> (string message, T value)
    {
        System.Console.WriteLine($"{message,-15} : {value}");
    }   
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex03
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="575" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/b46b69b7-0e7e-4b91-814e-a4bec94edc9d">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="453" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/8208c629-73a2-47e4-99b9-458de11eb2ec">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Interger : 123

Floating point : 123.45

Decimal : 2345.67

String : Hello World
