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
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/c5d1ed35-d464-431e-8e7c-a1daea3c0df3)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/541ad6f5-4d1c-4d35-b396-cac1f6288607)

7.อธิบายสิ่งที่พบในการทดลอง

คลาส DataStore ทำงานได้กับชนิดข้อมูล string int และ float
โค้ดสามารถเก็บและดึงข้อมูล string int และ float ผ่าน property value
โค้ดแสดงผลลัพธ์ของ property value
โค้ดนี้เป็นตัวอย่างง่ายๆ ของการใช้ Generic Class
แสดงชื่อ "Name LName" (ชนิด string)
แสดง ID "1234" (ชนิด int)
แสดงค่า GPA "3.45" (ชนิด float)
