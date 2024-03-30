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