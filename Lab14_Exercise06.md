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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/152ba644-1593-4b6b-9f5e-b8288a2b0c11)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/e04c0aa1-dfb8-4c3d-8ff2-48e41278c294)

7.อธิบายสิ่งที่พบในการทดลอง
- คลาส ARL<T> ที่เป็น Generic class ซึ่งมีเมทอดชื่อ DisplayData ที่รับข้อมูลชนิด T เข้ามาและคืนค่าข้อมูลชนิด T นั้นออกไป
- ผลลัพธ์ของโค้ดจะแสดงข้อมูลของสถานีถัดไปและค่าโดยสารที่ถูกแสดงตามประเภทข้อมูลที่ถูกใช้ใน Generic class
