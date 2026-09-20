using System.Runtime.InteropServices;

public class Student
{
    public string Name;
    public List<Course> Courses = new List<Course>();
    public Student(string name)
    {
        Name = name;
    }
// Gå med i en kurs
public void Join(Course course)
{
    if (Courses.Contains(course))
    {
        return;
    }
    Courses.Add(course);

    course.Enroll(this);
}

// Lämna en kurs
public void Leave(Course course)
{
    if (!Courses.Contains(course))
        {
            return;
        }
        Courses.Remove(course);

        course.Remove(this);
}

// Skriv ut kurser 
public void Schedule()
{
    Console.WriteLine($"Schema för {Name}");
    if (Courses.count == 0)
        {
            Console.WriteLine("Inga registrerade kurser");
            return;
        }

        foreach (var course in Courses)
        {
            Console.WriteLine("-" + course);
        }
}

public override string ToString()
    {
        return Name;
    }
}