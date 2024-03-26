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

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex01
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

<img width="453" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/64759bc7-5f9a-4832-b728-f5c8fca8cab9">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="458" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/5d8f4bc8-c556-43e7-a870-78b817679814">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

5

Type of IntCal is Calculator`1[System.Int32]

5.5

Type of IntCal is Calculator`1[System.Single]
