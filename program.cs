static double Add(double a, double b)
{
    return a + b;
}

static double Subtract(double a, double b)
{
    return a + b;
}

static int IntConverter(string a)
{
    int.TryParse(a, out int number);
    return number;
}

Console.WriteLine($"Adding 1.0 and 3.5 = {Add(1.0, 3.5)}");

Console.WriteLine($"Substracting 1.0 with 1.5 = {Subtract(1.0, 1.5)}");

Console.Write("Skriv in ett heltal");

int number;
while (true)
{
    string asString = Console.ReadLine()!;
    number = IntConverter(asString);
    if (asString == "0" || number != 0)
    {
        break;
    }
    Console.WriteLine("Skriv in heltal!!!");
}

Console.WriteLine($"Talet plus 1 är ${number + 1}");