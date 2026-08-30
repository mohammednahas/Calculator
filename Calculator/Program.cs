Console.WriteLine("====================");
Console.WriteLine("     CALCULATOR");
Console.WriteLine("====================");

Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Exit");

Console.Write("Choose an option: ");

string? choice = Console.ReadLine();

Console.WriteLine($"You selected: {choice}");
