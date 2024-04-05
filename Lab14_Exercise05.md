# Lab 14 Exercise 5

## Generic static method

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex05
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
// Generic static method

int a = 20, b = 30;
System.Console.WriteLine($"Before Swap: a = {a}, b = {b}");
Swap<int>(ref a, ref b);
System.Console.WriteLine($"After Swap:  a = {a}, b = {b}");

string h = "Hello", w = "World";
System.Console.WriteLine($"Before Swap: h = {h}, w = {w}");
Swap<string>(ref h, ref w);
System.Console.WriteLine($"After Swap:  h = {h}, w = {w}");

static void Swap<T>(ref T a, ref T b)
{
    T temp;
    temp = a;
    a = b;
    b = temp;
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex05
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/012e73a8-0700-46bb-8bb2-e0b55a5d9cd2)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/6e5b981d-b2c4-400e-be46-2e3b697ede76)

7.อธิบายสิ่งที่พบในการทดลอง

โค้ดนี้ใช้ Generic Method Swap เพื่อสลับค่าของตัวแปรสองตัว
โค้ดแสดงตัวอย่างการ swap กับตัวแปรชนิด int และ string
ผลลัพธ์ยืนยันว่าการ swap สำเร็จถูกต้อง
Generic Method Swap ช่วยให้สลับค่าของตัวแปรได้หลายชนิดข้อมูล
รายละเอียดผลลัพธ์

Before Swap: a = 20, b = 30
After Swap: a = 30, b = 20
Before Swap: h = Hello, w = World
After Swap: h = World, w = Hello


