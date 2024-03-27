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
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/218bf411-61ac-4554-a396-2efd0186a829)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-14/assets/144195611/c9cbc4dc-235b-4c16-b683-25a25580b5ec)

7.อธิบายสิ่งที่พบในการทดลอง
- มีการทำงานเหมือนกับข้อ1 ใช้ Generic class DataStore<T> เพื่อสร้างคลาสที่เก็บข้อมูลในตัวแปร value โดย T เป็นพารามิเตอร์ประเภทที่จะกำหนดประเภทของข้อมูลที่เก็บไว้
