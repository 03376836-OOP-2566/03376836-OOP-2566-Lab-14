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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/bdb79210-9081-43df-be17-bfcb69efde0b)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/fe1b7846-8b9a-45df-871c-6e86cbd89637)

7.อธิบายสิ่งที่พบในการทดลอง
โค้ดเป็นการสร้าง Generic Method ที่ชื่อ Print ซึ่งสามารถรับค่าของประเภทใดๆ

ก็ได้และแสดงผลลัพธ์ใน Console ออกมา ตัวอย่างโค้ดที่ให้มาใช้งาน Generic.Print โดยส่งค่าต่างๆ เข้าไปแสดงผลลัพธ์


ผลลัพธ์

10

Hello World

12345.678
