using C__Training.Models;

Calculator calc = new Calculator();

while (true)
{
    string option;
    Console.WriteLine("1 - ADD");
    Console.WriteLine("2 - SUBTRACT");
    Console.WriteLine("3 - MULTIPLY");
    Console.WriteLine("4 - DIVIDE");
    Console.WriteLine("0 - EXIT");
    Console.Write("Select an option: ");
    option = Console.ReadLine();

    if (option == "0")
    {
        Console.WriteLine("Operation finished.");
        break;
    }

    if (option != "1" && option != "2" && option != "3" && option != "4")
    {
        Console.WriteLine("Invalid option. Please try again.");
        continue;
    }

    Console.Write("First Value: ");
    double v1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Second Value: ");
    double v2 = Convert.ToDouble(Console.ReadLine());

    if (option == "1")
    {
        Console.WriteLine($"{v1} + {v2} = {calc.Add(v1, v2)}");
    }
    else if (option == "2")
    {
        Console.WriteLine($"{v1} - {v2} = {calc.Subtract(v1, v2)}");
    }
    else if (option == "3")
    {
        Console.WriteLine($"{v1} X {v2} = {calc.Multiply(v1, v2)}");
    }
    else if (option == "4")
    {
        if (calc.Divide(v1, v2) == double.MaxValue)
        {
            Console.WriteLine("Not possible to divide by 0");
        }
        else
        {
            Console.WriteLine($"{v1} - {v2} = {calc.Divide(v1, v2)}");
        }
    }
}
