using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Control Flow - Level 1\n");

        Console.WriteLine("1. Number Divisible by 5\n");
        DivisibleBy5();

        Console.WriteLine("\n2. First Number Smallest\n");
        FirstNumberSmallest();

        Console.WriteLine("\n3. Largest of Three Numbers\n");
        LargestOfThree();

        Console.WriteLine("\n4. Natural Number and Sum\n");
        NaturalNumberSum();

        Console.WriteLine("\n5. Voting Eligibility\n");
        VotingEligibility();

        Console.WriteLine("\n6. Positive, Negative or Zero\n");
        PositiveNegativeZero();

        Console.WriteLine("\n7. Spring Season\n");
        SpringSeason();

        Console.WriteLine("\n8. Rocket Countdown (While Loop)\n");
        RocketCountdownWhile();

        Console.WriteLine("\n9. Rocket Countdown (For Loop)\n");
        RocketCountdownFor();

        Console.WriteLine("\n10. Sum Until Zero\n");
        SumUntilZero();

        Console.WriteLine("\n11. Sum Until Zero or Negative (Break)\n");
        SumUntilZeroOrNegative();

        Console.WriteLine("\n12. Sum of N Natural Numbers (While Loop)\n");
        SumNaturalWhile();

        Console.WriteLine("\n13. Sum of N Natural Numbers (For Loop)\n");
        SumNaturalFor();

        Console.WriteLine("\n14. Factorial (While Loop)\n");
        FactorialWhile();

        Console.WriteLine("\n15. Factorial (For Loop)\n");
        FactorialFor();

        Console.WriteLine("\n16. Odd and Even Numbers\n");
        OddEvenNumbers();

        Console.WriteLine("\n17. Employee Bonus\n");
        EmployeeBonus();

        Console.WriteLine("\n18. Multiplication Table (6 to 9)\n");
        MultiplicationTable();
    }

    // 1
    public static void DivisibleBy5()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is the number {0} divisible by 5? {1}",
            number, number % 5 == 0 ? "Yes" : "No");
    }

    // 2
    public static void FirstNumberSmallest()
    {
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is the first number the smallest? {0}",
            (num1 <= num2 && num1 <= num3) ? "Yes" : "No");
    }

    // 3
    public static void LargestOfThree()
    {
        Console.WriteLine("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter third number:");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Is the first number the largest? {0}", a >= b && a >= c ? "Yes" : "No");
        Console.WriteLine("Is the second number the largest? {0}", b >= a && b >= c ? "Yes" : "No");
        Console.WriteLine("Is the third number the largest? {0}", c >= a && c >= b ? "Yes" : "No");
    }

    // 4
    public static void NaturalNumberSum()
    {
        Console.WriteLine("Enter a number:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
            Console.WriteLine("The sum of {0} natural numbers is {1}", n, n * (n + 1) / 2);
        else
            Console.WriteLine("The number {0} is not a natural number", n);
    }

    // 5
    public static void VotingEligibility()
    {
        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(age >= 18
            ? $"The person's age is {age} and can vote."
            : $"The person's age is {age} and cannot vote.");
    }

    // 6
    public static void PositiveNegativeZero()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0) Console.WriteLine("Positive");
        else if (number < 0) Console.WriteLine("Negative");
        else Console.WriteLine("Zero");
    }

    // 7
    public static void SpringSeason()
    {
        Console.WriteLine("Enter month in digit:");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter day:");
        int day = Convert.ToInt32(Console.ReadLine());

        if ((month == 3 && day >= 20) || (month > 3 && month < 6) || (month == 6 && day <= 20))
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
    }

    // 8
    public static void RocketCountdownWhile()
    {
        Console.WriteLine("Enter countdown start number:");
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
    }

    // 9
    public static void RocketCountdownFor()
    {
        Console.WriteLine("Enter countdown start number:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
            Console.WriteLine(i);
    }

    // 10
    public static void SumUntilZero()
    {
        Console.WriteLine("Enter numbers (enter 0 to stop):");
        double total = 0;

        while (true)
        {
            double value = Convert.ToDouble(Console.ReadLine());
            if (value == 0) break;
            total += value;
        }

        Console.WriteLine("Total sum is {0}", total);
    }

    // 11
    public static void SumUntilZeroOrNegative()
    {
        Console.WriteLine("Enter numbers (enter 0 or negative to stop):");
        double total = 0;

        while (true)
        {
            double value = Convert.ToDouble(Console.ReadLine());
            if (value <= 0) break;
            total += value;
        }

        Console.WriteLine("Total sum is {0}", total);
    }

    // 12
    public static void SumNaturalWhile()
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0, i = 1;
            while (i <= n) sum += i++;
            Console.WriteLine("While Loop Sum: {0}, Formula Sum: {1}", sum, n * (n + 1) / 2);
        }
    }

    // 13
    public static void SumNaturalFor()
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++) sum += i;
            Console.WriteLine("For Loop Sum: {0}, Formula Sum: {1}", sum, n * (n + 1) / 2);
        }
    }

    // 14
    public static void FactorialWhile()
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        int fact = 1;
        while (n > 0) fact *= n--;

        Console.WriteLine("Factorial is {0}", fact);
    }

    // 15
    public static void FactorialFor()
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        int fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;

        Console.WriteLine("Factorial is {0}", fact);
    }

    // 16
    public static void OddEvenNumbers()
    {
        Console.WriteLine("Enter a natural number:");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine("{0} is {1}", i, i % 2 == 0 ? "Even" : "Odd");
    }

    // 17
    public static void EmployeeBonus()
    {
        Console.WriteLine("Enter salary:");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter years of service:");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years > 5)
            Console.WriteLine("Bonus amount is {0}", salary * 0.05);
        else
            Console.WriteLine("No bonus applicable");
    }

    // 18
    public static void MultiplicationTable()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
            Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
    }
}
