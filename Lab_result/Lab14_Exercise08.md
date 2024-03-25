## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3

![8](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-14/assets/144196695/21b22dee-548c-4d9f-b4e4-db04d7ef0785)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5

![8](https://github.com/Nitiphum7/03376836-OOP-2566-Lab-14/assets/144196695/ac3158a1-e36a-461e-b075-622a4e084d93)

## อธิบายสิ่งที่พบในการทดลอง
 โค้ดนี้มีการใช้ `Generic queue โดย Queue<int> numbers = new Queue<int>();` เป็นการส้ราง queue โดยใช้ Generic เพื่อให้เก็บข้อมูลประเภท int
 `foreach (var item in numbers)` อันแรกเป็นลูปแสดงข้อมูลใน queue 5 10 และ 15 ตามลำดับ
 `var removeItem = numbers.Dequeue();` คือการนำข้อมูลตัวแรกออกจาก queue ซึ่งในที่นี้คือเลข 5 และเก็บค่าในตัวแปร removeItem
 และเรียกใช้ `foreach (var item in numbers)` อีกรอบเพื่อแสดงข้อมูลที่เหลือ = 10 15
