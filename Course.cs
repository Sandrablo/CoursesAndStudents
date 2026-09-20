public class Course
{
    public string Name;
    public int MaxSeats;
    public List<Student> Students = new List<Student>();

    public Course(string name, int maxSeats)
    {
        Name = name;
        MaxSeats = maxSeats;
    }


// Lägger till en student i kursen
public void Enroll(Student student)
{
    // Kontrollera att studenten inte finns registrerad
    if (Students.Contains(student))
    {
        Console.WriteLine(student.Name + " är redan registrerad");
        return;
    }
    // Kontrollerar om kursen är full
    if (Students.Count >= MaxSeats)
    {
        Console.WriteLine("Kursen är full");
        return;
    }

    // Lägger till student
    Students.Add(student);
}
}