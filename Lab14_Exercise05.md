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

<img width="493" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/5c64d406-f728-4a5a-b672-bc00f37ecc5b">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex05
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="446" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/c485f5ad-adc7-437f-9352-d7df55925a9f">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Before Swap: a = 20, b = 30

After Swap: a = 30, b = 20

Before Swap: h = Hello, w = World

After Swap: h = World, w = Hello
