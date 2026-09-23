Console.Write("Storlek: ");
// Läser inmatningen från användaren och gör om till ett heltal
int storlek = int.Parse(Console.ReadLine()!);
// Loopar från 1 till och med den angivna storleken
for (int i = 1; i <= storlek; i++)
{
    // kontrollerar att talet är delbart
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    // Kontrollera om talet är delbart med 3
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    // Kontrollera om talet är delbart med 5
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    // Annars skrivs själva talet ut
    else
    {
        Console.WriteLine(i);
    }
}