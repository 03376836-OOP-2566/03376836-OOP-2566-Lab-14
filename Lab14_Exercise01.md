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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/96a86097-5ff7-4f75-a41d-c6a4f832a2a4)


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/b2c860af-7646-4c33-a651-69b6f659c48f)

7.อธิบายสิ่งที่พบในการทดลอง
- ใช้ Generic class Calculator<T> เพื่อสร้างเครื่องคำนวณ
- สามารถทำงานกับประเภทข้อมูลที่ต่างกันได้ โดยประกาศ T เป็นพารามิเตอร์ของคลาสเพื่อระบุประเภทข้อมูลที่จะใช้ในการคำนวณ
- มีการสร้างเครื่องคำนวณที่รองรับการบวกของจำนวนเต็มและจำนวนทศนิยม (int และ float) 
