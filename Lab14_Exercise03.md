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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/e5395790-2d43-4d4b-b9eb-d929e9234da5)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex03
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/f3a0e801-bc13-4df3-b736-570170d5c18b)

7.อธิบายสิ่งที่พบในการทดลอง
โค้ดนี้ใช้ Generic Method Show
Show แสดงข้อความและค่าตามประเภทข้อมูล
โค้ดแสดงตัวอย่าง Show กับ int, float, decimal และ string
Generic Method ช่วยให้โค้ดสั้นลงและใช้งานได้กับหลายประเภทข้อมูล
แสดงผลรวมของ 2 + 3 = 5
แสดงผลลัพธ์ของ 2.5 + 3.5 = 6
แสดงผลลัพธ์ของ "Hello" + "World" = "HelloWorld"
โค้ดนี้แสดงวิธีใช้ Operator Overloading กับ "+"
