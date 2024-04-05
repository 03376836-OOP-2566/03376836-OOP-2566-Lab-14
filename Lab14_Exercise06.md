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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/669474a5-bd29-4889-a567-dec0a7d50cfe)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/b3081226-a4bc-44be-a7db-420ad0a317b3)

7.อธิบายสิ่งที่พบในการทดลอง
