# Lab 14 Exercise 6

## Generic

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex06
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var nextStation = new ARL<string>();
System.Console.WriteLine("Next station : " + nextStation.DisplayData("Ladkrabang"));
var fare = new ARL<float>();
System.Console.WriteLine("Fare         : ฿" + fare.DisplayData(15.0f));

class ARL<T>
{
    public T DisplayData(T data)
    {
        return data;
    }
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex06
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![6](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/56c4a890-f638-473c-bd30-c20ae02b49b5)

สามารถ Build ได้ เพราะ สร้าง Class ARL ที่เป็น Generic class

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![6 1](https://github.com/Siriratda/03376836-OOP-2566-Lab-14/assets/144195995/e905204d-f351-47a0-b9c9-cea0325fb1d0)

7.อธิบายสิ่งที่พบในการทดลอง

สามารถ Run ได้ เพราะ สร้างอ็อบเจ็กต์ nextStation และ fare ของคลาส ARL โดยกำหนดประเภทของข้อมูลเป็น string และ float และเรียกใช้ Method DisplayData เพื่อแสดงข้อมูล

โปรแกรมแสดง

Next station : Ladkrabang

Fare : ฿15
