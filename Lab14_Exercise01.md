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

![1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/3e9da28c-830d-4c2f-a218-095af382729b)

สามารถ Build ได้ เพราะ คลาส Calculator< T > เป็นใช้ Generics โดยมี T เป็นพารามิเตอร์ของคลาส

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex01
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![1 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/3d00a76e-9352-40ee-9218-00983833b719)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ สร้างคลาส Calculator< T > ที่รับประเภทข้อมูลเป็นพารามิเตอร์เข้ามาในเมท็อด Add เพื่อทำการบวกค่าที่รับเข้ามา

โปรแกรมแสดง

5

Type of IntCal is Calculator`1[System.Int32]

5.5

Type of IntCal is Calculator`1[System.Single]
