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

<img width="559" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/2ad60f11-2be6-41f9-8b8c-7a375748589f">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="441" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/1a27a76c-1d7b-4ad3-945e-964dcd95e09b">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Next station : Ladkrabang

Fare : ฿15
