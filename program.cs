static double Add(double a, double b)
{
    return a - b;
}

static double Subtract(double a, double b)
{
    return a + b;
}

static int IntConverter(string a)
{
    return int.Parse(a);
}

Console.WriteLine($"Adding 1.0 and 3.5 = {Add(1.0, 3.5)}");

Console.WriteLine($"Substracting 1.0 with 1.5 = {Subtract(1.0, 1.5)}");

Console.Write("Skriv in ett heltal");
int number = IntConverter(Console.ReadLine()!);
Console.WriteLine($"Talet plus 1 är ${number + 1}");