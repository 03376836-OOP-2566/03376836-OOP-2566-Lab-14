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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/2cb1bf9a-67b3-41a7-afdd-6983f388bd65)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex04
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/09a0bdf6-e3c3-4c85-9f0f-4413bc5b808e)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ Generic method Print<T> เพื่อพิมพ์ค่าของประเภทต่าง ๆ ที่รับเข้ามา โดยไม่จำเป็นต้องระบุประเภทของข้อมูลในตอนที่เรียกใช้งาน
- ใช้ System.Console.WriteLine(value); เพื่อแสดงค่าของ value ที่รับเข้ามา

