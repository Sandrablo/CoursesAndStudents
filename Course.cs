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
    student.Join(this);
}

public void Remove(Student student)
    {
        if (Students.Contains(student))
        {
            Students.Remove(student);
            student.Leave(this);
        }
}

// Skriver ut alla studerande
public void RollCall()
{
    Console.WriteLine($"Upprop för {Name}");
    if (Students.Count == 0)
    {
        Console.WriteLine("Inga studerande i denna kurs.");
        return;
    }

    foreach (var student in Students)
    {
        Console.WriteLine("- " + student.Name);
    }
}

public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} platser)";
    }
}