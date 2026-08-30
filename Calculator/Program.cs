Console.WriteLine("====================");
Console.WriteLine("   CALCULATOR v1.1.1");
Console.WriteLine("====================");

Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Square");

Console.WriteLine("6. Exit");

Console.Write("Choose an option: ");

string? choice = Console.ReadLine();

if (choice == "1")
{
    Console.Write("Enter first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    double result = number1 + number2;

    Console.WriteLine($"Result = {result}");
}
else if (choice == "2")
{
    Console.Write("Enter first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    double result = number1 - number2;

    Console.WriteLine($"Result = {result}");
}
else if (choice == "3")
{
    Console.Write("Enter first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    double result = number1 * number2;

    Console.WriteLine($"Result = {result}");
}else if (choice == "4")
{
    Console.Write("Enter first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    double number2 = double.Parse(Console.ReadLine()!);

    if (number2 == 0)
    {
        Console.WriteLine("Cannot divide by zero.");
    }
    else
    {
        double result = number1 / number2;

        Console.WriteLine($"Result = {result}");
    }
}
else
{
    Console.Write("Enter first number: ");
    double number1 = double.Parse(Console.ReadLine()!);

    Console.Write("Enter second number: ");
    double number2 = double.Parse(Console.ReadLine()!);
      Console.WriteLine(Math.Pow(number1,number2));
}