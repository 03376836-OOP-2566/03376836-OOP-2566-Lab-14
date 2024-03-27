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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/d455f747-9298-4a52-8db2-cd1dc7a62d88)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/db215f3c-d007-450c-a5df-203ee3319612)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ Generic method Show<T> ซึ่งเป็นเมทอดที่ใช้ Generic type parameter T ในการรับพารามิเตอร์และการสร้างข้อความเอาไว้แสดงผลในคอนโซล (Console)
