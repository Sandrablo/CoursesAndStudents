using System.Runtime.InteropServices;

public class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();
    public Student(string name)
    {
        Name = name;
    }
}