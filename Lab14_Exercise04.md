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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/e11b6fea-44ca-4cbe-99e1-4dc01d412ac4)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/6f54fc2f-d82b-44cd-9b71-553013e3e6d5)

7.อธิบายสิ่งที่พบในการทดลอง
