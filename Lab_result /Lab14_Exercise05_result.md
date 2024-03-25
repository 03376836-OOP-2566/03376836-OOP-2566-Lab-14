## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-14/assets/144197367/bb031e08-0559-4e19-bb6a-b55795ffc339)


สามารถ Build ได้ เพราะ Method Swap ซึ่งเป็น Generic static method ที่รับ
พารามิเตอร์ ref T a, ref T b

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![image](https://github.com/Phetteepop/03376836-OOP-2566-Lab-14/assets/144197367/5e9cfb30-2e3f-4fc6-9ca8-8a8b929b0290)


สามารถ Run ได้ เพราะ  static method ซึ่งทำให้เราสามารถเรียกใช้งานเมท็อดนี้ได้โดยตรงจากคลาส Generic โดยไม่ต้องสร้างอ็อบเจ็กต์ของคลาส Generic ก่อน
- Swap<int>(ref a, ref b); // เรียกใช้ static method Swap<int> โดยใช้ Generic type int
- Swap<string>(ref h, ref w); // เรียกใช้ static method Swap<string> โดยใช้ Generic type string

## อธิบายสิ่งที่พบในการทดลอง
- Before Swap: a = 20, b = 30
- After Swap:  a = 30, b = 20
- Before Swap: h = Hello, w = World
- After Swap:  h = World, w = Hello
