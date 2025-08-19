using C__Training.Models;

Calculator calc = new Calculator();

while (true)
{
    Console.WriteLine("1 - CALCULATOR");
    Console.WriteLine("2 - ANGLE CALCULATOR");
    Console.WriteLine("0 - EXIT");
    Console.Write("SELECT THE CALCULATOR TYPE: ");
    string type = Console.ReadLine();

    if (type == "0")
    {
        Console.WriteLine("Operation finished.\n\n");
        break;
    }

    if (type != "1" && type != "2")
    {
        Console.WriteLine("Invalid option. Please try again.");
        continue;
    }

    while (type == "1")
    {
        double v1 = 0;
        double v2 = 0;
        string option;
        Console.WriteLine("1 - ADD");
        Console.WriteLine("2 - SUBTRACT");
        Console.WriteLine("3 - MULTIPLY");
        Console.WriteLine("4 - DIVIDE");
        Console.WriteLine("5 - POWER");
        Console.WriteLine("6 - SQUARE ROOT");
        Console.WriteLine("0 - GO BACK");
        Console.Write("Select an option: ");
        option = Console.ReadLine();

        if (option == "0")
        {
            Console.WriteLine("Operation finished.\n\n");
            break;
        }

        if (option != "1" && option != "2" && option != "3" && option != "4" && option != "5" && option != "6")
        {
            Console.WriteLine("Invalid option. Please try again.");
            continue;
        }

        Console.Write("First Value: ");
        v1 = Convert.ToDouble(Console.ReadLine());
        if (option != "6")
        {
            Console.Write("Second Value: ");
            v2 = Convert.ToDouble(Console.ReadLine());
        }

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
        else if (option == "5")
        {
            Console.WriteLine($"{v1}^{v2} = {calc.Power(v1, v2)}");
        }
        else if (option == "6")
        {
            Console.WriteLine($"Square root of {v1} = {calc.SqrRoot(v1)}");
        }
    }

    while (type == "2")
    {
        string option;
        Console.WriteLine("1 - SINE");
        Console.WriteLine("2 - COSINE");
        Console.WriteLine("3 - TANGENT");
        Console.WriteLine("0 - GO BACK");
        Console.Write("Select an option: ");
        option = Console.ReadLine();

        if (option == "0")
        {
            Console.WriteLine("Operation finished.\n\n");
            break;
        }

        if (option != "1" && option != "2" && option != "3")
        {
            Console.WriteLine("Invalid option. Please try again.");
            continue;
        }

        Console.Write("Angle: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        if (option == "1")
        {
            Console.WriteLine($"Sine of {angle}° = {Math.Round(calc.Sine(angle), 4)}");
        }
        else if (option == "2")
        {
            Console.WriteLine($"Cosine of {angle}° = {Math.Round(calc.Cosine(angle), 4)}");
        }
        else if (option == "3")
        {
            Console.WriteLine($"Tangent of {angle}° = {Math.Round(calc.Tangent(angle), 4)}");
        }
    }
}
