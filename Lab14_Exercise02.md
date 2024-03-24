# Lab 14 Exercise 2

## Generic

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex02
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var name  = new DataStore<string>();
name.value ="Name LName";
System.Console.WriteLine(name.value);

var id = new DataStore<int>();
id.value = 1234;
System.Console.WriteLine(id.value);

var gpa = new DataStore<float>();
gpa.value = 3.45f;
System.Console.WriteLine(gpa.value);  

public class DataStore <T>
{
    private T data;
    public T value
    {
        get { return this.data; }
        set { this.data = value;}
    }

}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex02
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
<img width="462" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 26 40" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/1ebb711f-249f-4aac-a9dd-2a9556b4e1bc">
### สามารถ Build ได้ เพราะ สร้างคลาส DataStore< T > เก็บข้อมูลประเภทต่าง ๆ โดย T คือพารามิเตอร์ของคลาสที่จะระบุประเภทของข้อมูลที่จะถูกเก็บไว้ใน DataStore


5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="464" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 26 57" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/5abaf3d6-8983-46e1-921d-e493221ab715">
### สามารถ Run ได้ เพราะ สร้างอ็อบเจ็กต์ของ DataStore และกำหนดค่าให้กับฟิลด์ value ซึ่งเป็นตัวแปรชนิด T 
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### Name LName
### 1234
### 3.45
