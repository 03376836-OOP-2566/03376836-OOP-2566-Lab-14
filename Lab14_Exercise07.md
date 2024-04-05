# Lab 14 Exercise 7

## Generic list

1.สร้าง console application project

```cmd
dotnet new console --name Lab14_Ex07
```

2.เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
using System.Collections;

List<string> CourseName = new List<string>();
CourseName.Add("OOP");
CourseName.Add("Network");
CourseName.Add("Electronics");
CourseName.Add("Web programming");

foreach (var item in CourseName)
{
    System.Console.WriteLine(item);
}

List<int> CourseID = new List<int>();
CourseID.Add(3687);
CourseID.Add(3785);
CourseID.Add(3781);
CourseID.Add(3722);

foreach (var item in CourseID)
{
    System.Console.WriteLine(item);
}

int count = CourseID.Count < CourseName.Count ? CourseID.Count : CourseName.Count;


for (int i = 0; i < count; i++)
{
    Console.WriteLine(CourseID[i] + " " + CourseName[i]);
}
```

3.Build project โดยการใช้คำสั่ง

```cmd
dotnet build  Lab14_Ex07
```

ถ้ามีที่ผิดพลาดในโปรแกรม ให้แก้ไขให้ถูกต้อง

4.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/b7cd494f-a000-43cd-a7b5-80aa28f1849f)

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/AnchisaPhetnoi/03376836-OOP-2566-Lab-14/assets/144197034/e2704685-fe60-4590-a70d-76d4905f3d0d)

7.อธิบายสิ่งที่พบในการทดลอง
