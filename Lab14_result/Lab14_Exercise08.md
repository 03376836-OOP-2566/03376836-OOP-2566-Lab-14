### ผลที่ได้จากการรันคำสั่งในข้อ 3

![Screenshot 2024-03-29 195649](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-14/assets/144195697/981d93dd-5f6e-4f14-a172-557800574d35)

โปรแกรม Build ได้เพราะโค้ดมีการใช้ Generic queue โดย Queue<int> numbers = new Queue<int>(); เป็นการส้ราง queue โดยใช้ Generic เพื่อให้เก็บข้อมูลประเภท int

### ผลที่ได้จากการรันคำสั่งในข้อ 5

![Screenshot 2024-03-29 195653](https://github.com/KanyakornPuengmon/03376836-OOP-2566-Lab-14/assets/144195697/4e31b1e0-a6b3-4338-af6e-666bdfadcf9e)

โปรแกรม Run ได้เพราะมีการใช้ var removeItem = numbers.Dequeue(); คือการนำข้อมูลตัวแรกออกจาก queue ซึ่งในที่นี้คือเลข 5 และเก็บค่าในตัวแปร removeItem

### สิ่งที่พบในการทดลอง
- โปรแกรม Build ได้เพราะโค้ดมีการใช้ Generic queue โดย Queue<int> numbers = new Queue<int>(); เป็นการส้ราง queue โดยใช้ Generic เพื่อให้เก็บข้อมูลประเภท int
- โปรแกรม Run ได้เพราะมีการใช้ var removeItem = numbers.Dequeue(); คือการนำข้อมูลตัวแรกออกจาก queue ซึ่งในที่นี้คือเลข 5 และเก็บค่าในตัวแปร removeItem
- ผลลัพท์ที่ได้ คือ
  - Add 3 elements (5, 10, 15)
  - Items in queue:
  - 5
  - 10
  - 15
  - Remove first item in queue : 5
  - Remaining items in queue:
  - 10
  - 15
