## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-14/assets/144196505/f1136c31-3763-44aa-a039-9d704aafc6da)

## บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5
![image](https://github.com/Sorawit255/03376836-OOP-2566-Lab-14/assets/144196505/23dc41da-62c8-4fe4-a2b6-9dee805a4743)

## อธิบายสิ่งที่พบในการทดลอง
### โค้ดนี้มีการใช้ `Generic queue โดย Queue<int> numbers = new Queue<int>();` เป็นการส้ราง queue โดยใช้ Generic เพื่อให้เก็บข้อมูลประเภท int
### `foreach (var item in numbers)` อันแรกเป็นลูปแสดงข้อมูลใน queue 5 10 และ 15 ตามลำดับ
### `var removeItem = numbers.Dequeue();` คือการนำข้อมูลตัวแรกออกจาก queue ซึ่งในที่นี้คือเลข 5 และเก็บค่าในตัวแปร removeItem
### และเรียกใช้ `foreach (var item in numbers)` อีกรอบเพื่อแสดงข้อมูลที่เหลือ = 10 15
