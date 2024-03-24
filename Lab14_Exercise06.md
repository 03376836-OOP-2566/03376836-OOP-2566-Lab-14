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
<img width="451" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 47 11" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/a815be68-15f6-486c-92d1-98dc86671622">
### สามารถ Build ได้ เพราะ สร้าง Class ARL ที่เป็น Generic class
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="452" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 47 28" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/7f0d70fa-f906-47cc-b07f-cf48e86b797f">
### สามารถ Run ได้ เพราะ สร้างอ็อบเจ็กต์ nextStation และ fare ของคลาส ARL โดยกำหนดประเภทของข้อมูลเป็น string และ float และเรียกใช้ Method DisplayData เพื่อแสดงข้อมูล
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Next station : Ladkrabang
### Fare : ฿15
