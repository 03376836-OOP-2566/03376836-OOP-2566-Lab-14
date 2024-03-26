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

<img width="705" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/a68b2b22-9da2-4737-8c85-3c55db3054f3">

5.Run project โดยการใช้คำสั่ง

```cmd
dotnet run --project Lab14_Ex02
```

6.บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

<img width="438" alt="image" src="https://github.com/chatladawongkanyon/03376836-OOP-2566-Lab-14/assets/144195963/a5d19b36-87c6-4cd5-876a-af476530c588">

7.อธิบายสิ่งที่พบในการทดลอง

โปรแกรมแสดง

Name LName

1234

3.45
