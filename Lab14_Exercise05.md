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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/9c4ec4c8-041c-4db3-8ae4-3e939a275ce9)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/d7b601c4-b261-4244-b628-bc37b22c53fa)

7.อธิบายสิ่งที่พบในการทดลอง
เป็นการสร้าง Generic Static Method ชื่อ Swap ที่ใช้สำหรับสลับค่าของตัวแปรที่ส่งเข้ามาในรูปแบบ reference กัน โดยใช้ ref keyword ในการรับค่าและส่งค่าของตัวแปรที่อ้างอิงกัน
