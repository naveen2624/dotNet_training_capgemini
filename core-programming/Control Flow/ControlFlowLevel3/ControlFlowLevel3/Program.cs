using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n__________________________________________");
            Console.WriteLine("\nControl Flow Level 3\n");
            Console.WriteLine("1. Armstrong Number Check");
            Console.WriteLine("2. Count Number of Digits");
            Console.WriteLine("3. Harshad Number Check");
            Console.WriteLine("4. Abundant Number Check");
            Console.WriteLine("5. Day Of Week");
            Console.WriteLine("6. Calculator");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter a Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: ArmstrongNumber(); break;
                case 2: CountDigits(); break;
                case 3: HarshadNumber(); break;
                case 4: AbundantNumber(); break;
                case 5: DayOfWeek(); break;
                case 6: Calculator(); break;
                default: Console.WriteLine("Invalid Choice"); break;
            }
        }
    }

    // 1. Armstrong Number
    public static void ArmstrongNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10;
            sum += remainder * remainder * remainder;
            originalNumber = originalNumber / 10;
        }

        if (sum == number)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }

    // 2. Count Number of Digits
    public static void CountDigits()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        while (number != 0)
        {
            number = number / 10;
            count++;
        }

        Console.WriteLine("Number of Digits: " + count);
    }

    // 3. Harshad Number
    public static void HarshadNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        if (originalNumber % sum == 0)
            Console.WriteLine("Harshad Number");
        else
            Console.WriteLine("Not a Harshad Number");
    }

    // 4. Abundant Number
    public static void AbundantNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum > number)
            Console.WriteLine("Abundant Number");
        else
            Console.WriteLine("Not an Abundant Number");
    }

    // 5. Day Of Week
    public static void DayOfWeek()
    {
        Console.Write("Enter Month (1-12): ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Day: ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Year: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine("Day of Week: " + d0);
        Console.WriteLine("0=Sunday, 1=Monday, 2=Tuesday, 3=Wednesday, 4=Thursday, 5=Friday, 6=Saturday");
    }
    public static void Calculator()
    {
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;

            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;

            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;

            case "/":
                if (second != 0)
                    Console.WriteLine("Result = " + (first / second));
                else
                    Console.WriteLine("Division by zero is not allowed");
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
