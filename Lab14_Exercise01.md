# Lab 14 Exercise 1

## Generic

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex01
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var IntCal  = new Calculator<int>();
var IntResult = IntCal.Add(2,3);
System.Console.WriteLine(IntResult);
System.Console.WriteLine("Type of IntCal is "+ IntCal.GetType());

var FloatCal  = new Calculator<float>();
var FloatResult = FloatCal.Add(2.5f, 3f);
System.Console.WriteLine(FloatResult);
System.Console.WriteLine("Type of IntCal is "+ FloatCal.GetType());

class Calculator<T>
{
    public T Add(T a, T b)
    {
        dynamic? number1 = a;
        dynamic? number2 = b;
        return number1 + number2;
    }
}
```
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/dd2a8b45-6921-4ab6-a514-14e266a0ea12)

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/0a2ed955-04ff-4526-9617-a95763c8f062)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/08e94483-d5c3-4585-94a0-580990a6ab6c)

7.อธิบายสิ่งที่พบในการทดลอง

คลาส Calculator ทำงานได้กับชนิดข้อมูล int และ float
เมธอด Add ของคลาส Calculator สามารถบวกตัวเลขสองตัวที่มีชนิดข้อมูล T เดียวกัน
โค้ดแสดงผลลัพธ์การบวกและชนิดข้อมูลของ IntCal และ FloatCal
โค้ดนี้เป็นตัวอย่างง่ายๆ ของการใช้ Generic Class

