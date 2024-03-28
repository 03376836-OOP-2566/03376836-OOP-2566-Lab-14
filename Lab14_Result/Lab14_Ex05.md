# 3 #

![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-14/assets/144195683/7892c720-2c19-4404-8531-7d7c582f8de7)
สามารถ Build ได้ เพราะ Method Swap ซึ่งเป็น Generic static method ที่รับ พารามิเตอร์ ref T a, ref T b
# 5 # 

![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-14/assets/144195683/bb6a0581-afed-4ac5-8f93-8aaaad2a1c91)
```
สามารถ Run ได้ เพราะ static method ซึ่งทำให้เราสามารถเรียกใช้งานเมท็อดนี้ได้โดยตรงจากคลาส Generic โดยไม่ต้องสร้างอ็อบเจ็กต์ของคลาส Generic ก่อน

Swap(ref a, ref b); // เรียกใช้ static method Swap โดยใช้ Generic type int
Swap(ref h, ref w); // เรียกใช้ static method Swap โดยใช้ Generic type string
```

# อธิบายสิ่งที่พบในการทดลอง #
```
Before Swap: a = 20, b = 30 
After Swap: a = 30, b = 20
Before Swap: h = Hello, w = World
After Swap: h = World, w = Hello
