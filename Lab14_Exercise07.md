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
<img width="443" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 49 45" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/a557a300-ab01-4e4d-92bd-0c32e287d8a0">
### สามารถ Build ได้ เพราะ สร้าง List string สำหรับเก็บชื่อคอร์สและ List int สำหรับเก็บรหัสคอร์ส
5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex07
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
<img width="450" alt="ภาพถ่ายหน้าจอ 2567-03-25 เวลา 04 50 00" src="https://github.com/VisawaPRO/03376836-OOP-2566-Lab-14/assets/144195555/28bec6ce-3c1e-460d-89f9-c8085f8d1a4c">
### สามารถ Run ได้ เพราะ ใช้การวนซ้ำ foreach และ for เพื่อแสดงผลข้อมูลทั้งสอง List
7.อธิบายสิ่งที่พบในการทดลอง
### โปรแกรมแสดง
### OOP
### Network
### Electronics
### Web programming
### 3687
### 3785
### 3781
### 3722
### 3687 OOP
### 3785 Network
### 3781 Electronics
### 3722 Web programming
