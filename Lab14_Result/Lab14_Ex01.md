# 3 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-14/assets/144195683/b3bf2946-6b9a-42e7-8133-89811dd9b860)
สามารถ Build ได้ เพราะ คลาส Calculator< T > เป็นใช้ Generics โดยมี T เป็นพารามิเตอร์ของคลาส ทำให้เราสามารถใช้งานเมท็อด Add กับประเภทข้อมูลต่าง ๆ ได้โดยที่เราไม่ต้องระบุประเภทข้อมูล


# 5 #
![image](https://github.com/ThanaloekKaisai/03376836-OOP-2566-Lab-14/assets/144195683/dd5c4d68-554b-4f59-848d-3ae52cdfbe45)
สามารถ Run ได้ เพราะ สร้างคลาส Calculator< T > ที่รับประเภทข้อมูลเป็นพารามิเตอร์เข้ามาในเมท็อด Add เพื่อทำการบวกค่าที่รับเข้ามา เมื่อเรียกใช้งาน Add ในคลาส Calculator< T > ก็จะใช้งาน dynamic เพื่อให้รับค่าข้อมูลประเภทไหนก็ได้ และทำการบวกกัน

# อธิบายสิ่งที่พบในการทดลอง #
```
5
Type of IntCal is Calculator`1[System.Int32]
5.5
Type of IntCal is Calculator`1[System.Single]
