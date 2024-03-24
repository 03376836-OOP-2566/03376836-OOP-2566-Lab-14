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
<img width="439" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 12 02" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/e9677d2e-4fbe-4748-b856-e4b7deb01bef">
### สามารถ Build ได้ เพราะ คลาส Calculator< T > เป็นใช้ Generics โดยมี T เป็นพารามิเตอร์ของคลาส 
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="454" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 15 01" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/1d9dc747-bd9d-4f5d-b1c0-049b6a18eaf2">
### สามารถ Run ได้ เพราะ สร้างคลาส Calculator< T > ที่รับประเภทข้อมูลเป็นพารามิเตอร์เข้ามาในเมท็อด Add เพื่อทำการบวกค่าที่รับเข้ามา
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### 5
### Type of IntCal is Calculator`1[System.Int32]
### 5.5
### Type of IntCal is Calculator`1[System.Single]
