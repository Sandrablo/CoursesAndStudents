using System;
using System.Formats.Tar;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string []args)
    {
        Console.WriteLine("Test kurser och studerande");

        Course matte = new Course ("Matematik", 2);
        Course engelska = new Course ("Engelska", 5);

        Student emma = new Student("Emma");
        Student erik = new Student("Erik");
        Student kalle = new Student("Kalle");

        Console.WriteLine("Test: Tvåvägskoppling");

        matte.Enroll(emma);

        erik.Join(matte);

        matte.RollCall();
        Console.WriteLine();
        emma.Schedule();
        erik.Schedule();
        Console.WriteLine();

        Console.WriteLine("Test: Dubletter");
        Console.WriteLine("Testar att anmäla Emma till matematik igen via Enroll:");
        matte.Enroll(emma);

        Console.WriteLine("Testar att anmäla Emma till matematik igen via Join:");
        emma.Join(matte);

        Console.WriteLine("Testar upprop:");
        matte.RollCall();
        Console.WriteLine();

        Console.WriteLine("Test: Kapacitetstak");
        matte.Enroll(kalle);
        Console.WriteLine();

        Console.WriteLine("Test: Borttagning");
        matte.Remove(kalle);
        Console.WriteLine("Borttagning utan krasch");

        Console.WriteLine("Tvåvägskoppling vid avanmälan");

        engelska.Enroll(emma);
        engelska.Enroll(erik);
        engelska.Enroll(kalle);

        Console.WriteLine("Innan avanmälan på engelska:");
        engelska.RollCall();
        Console.WriteLine();

        Console.WriteLine("Tar bort Emma via engelska.Remove()...");
        engelska.Remove(emma);

        Console.WriteLine("Tar bort Erik via erik.leave()...");
        erik.Leave(engelska);

        Console.WriteLine("Efter avanmälan:");
        engelska.RollCall();

        Console.WriteLine();
        Console.WriteLine("Studenternas schema:");
        emma.Schedule();
        kalle.Schedule();

    }
}