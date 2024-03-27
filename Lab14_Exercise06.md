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
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/95c51a09-5bd8-4edc-9b8d-27e1e3da4b4e)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex06
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/ThanchiraCharakhon099/03376836-OOP-2566-Lab-14/assets/144195708/8fabc71a-bcd7-4fb0-b2eb-674f36377862)

7.อธิบายสิ่งที่พบในการทดลอง
คลาส ARL<T> ที่เป็น Generic Class ซึ่งมีเมทอดชื่อ DisplayData ที่รับข้อมูลจากประเภท T และคืนค่าข้อมูลที่ได้รับนั้นกลับออกมา 

จากการทดลองพบว่า Generic Class ARL<T> สามารถใช้งานได้กับประเภทข้อมูลต่าง ๆ โดยที่เมทอดภายในคลาสจะคืนค่าที่ได้รับมาโดยตรง 

ซึ่งทำให้เราสามารถ reuse โค้ดได้สะดวกและยืดหยุ่นได้ดี และมีความสามารถในการทำงานกับข้อมูลจากประเภทต่าง ๆ ได้อย่างง่าย
