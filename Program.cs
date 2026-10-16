using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Test kurser och studerande");
        Console.WriteLine();

        Course matte = new Course("Matematik", 2);
        Course engelska = new Course("Engelska", 5);

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
        Console.WriteLine("Testar att anmäla Kalle till Matematik (full) via Join:");
        kalle.Join(matte);

        Console.WriteLine("Testar att anmäla Kalle till Matematik (full) via Enroll:");
        matte.Enroll(kalle);

        Console.WriteLine("Matematik ska fortfarande bara ha Emma och Erik:");
        matte.RollCall();
        Console.WriteLine("Kalle ska inte ha Matematik i sitt schema:");
        kalle.Schedule();
        Console.WriteLine();

        Console.WriteLine("Test: Borttagning");
        Console.WriteLine("Testar att ta bort Kalle från Matematik via Remove:");
        matte.Remove(kalle);

        Console.WriteLine("Testar att låta Kalle lämna Matematik via Leave:");
        kalle.Leave(matte);
        Console.WriteLine("Borttagning utan krasch");
        Console.WriteLine();

        Console.WriteLine("Test: Tvåvägskoppling vid avanmälan");
        engelska.Enroll(emma);
        engelska.Enroll(erik);
        kalle.Join(engelska);

        Console.WriteLine("Innan avanmälan på engelska:");
        engelska.RollCall();
        Console.WriteLine();

        Console.WriteLine("Tar bort Emma via engelska.Remove()...");
        engelska.Remove(emma);

        Console.WriteLine("Tar bort Erik via erik.Leave()...");
        erik.Leave(engelska);
        Console.WriteLine();

        Console.WriteLine("Efter avanmälan:");
        engelska.RollCall();
        Console.WriteLine();

        Console.WriteLine("Studenternas schema:");
        emma.Schedule();
        erik.Schedule();
        kalle.Schedule();
    }
}