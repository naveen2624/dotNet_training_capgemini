using System;
class Program
{
    static void Main(string[] args)
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n__________________________________________");
            Console.WriteLine("\nControl Flow Level 2\n");
            Console.WriteLine("1. Leap Year Program (Multiple if and else if statements) ");
            Console.WriteLine("2. Leap Year Program (Single If statement");
            Console.WriteLine("3. Grade Calculator");
            Console.WriteLine("4. Prime Number Checker");
            Console.WriteLine("5. FizzBuzz (using for loop) ");
            Console.WriteLine("6. FizzBuzz (using while loop)");
            Console.WriteLine("7. BMI Calculator");
            Console.WriteLine("8. Youngest Among 3");
            Console.WriteLine("9. Greatest Factor");
            Console.WriteLine("10. Power of the Number");
            Console.WriteLine("11. Factors of number (user input)");
            Console.WriteLine("12. Multiples of a Number");




            Console.Write("Enter a Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (choice){
                case 0: Console.WriteLine("Thank You"); break;
                case 1: LeapYearMultiple(); break;
                case 2: LeapYearSingle(); break;
                case 3: GradeCalculator(); break;
                case 4: PrimeNumber(); break;
                case 5: FizzBuzzFor(); break;
                case 6: FizzBuzzWhile(); break;
                case 7: BMICalculator(); break;
                case 8: YoungestTallest(); break;
                case 9: GreatestFactor(); break;
                case 10: PowerOfNumber(); break;
                case 11: FactorsOfNumber(); break;
                case 12: MultiplesBelow100(); break;
                default: Console.WriteLine("Invalid Choice"); break;

            }

        }
    }
    public static void LeapYearMultiple()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
        {
            Console.WriteLine("Leap Year calculation is valid only for year 1582 and above.");
        }
        else
        {
            if (year % 400 == 0)
            {
                Console.WriteLine("The year is a Leap Year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("The year is not a Leap Year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("The year is a Leap Year");
            }
            else
            {
                Console.WriteLine("The year is not a Leap Year");
            }
        }
    }
    public static void LeapYearSingle()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
        {
            Console.WriteLine("The year is a Leap Year");
        }
        else
        {
            Console.WriteLine("The year is not a Leap Year");
        }
    }

    public static void GradeCalculator()
    {
        Console.Write("Enter the Marks obtained in Physics out of 100: ");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Marks obtained in Chemistry out of 100: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Marks obtained in Maths out of 100: ");
        int maths = Convert.ToInt32(Console.ReadLine());
        double percentage = (physics + chemistry + maths) / 3;
        if (percentage >= 80)
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : A ");
            Console.WriteLine("Remark: Level 4, above agency normalized standards");
        }
        else if (percentage >= 70&&percentage<80)
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : B ");
            Console.WriteLine("Remark: Level 3, at agency normalized standards");
        }
        else if (percentage >=60&& percentage < 70)
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : C ");
            Console.WriteLine("Remark: Level 2, below, but approaching agency normalized standards");
        }
        else if (percentage >= 50 && percentage<60)
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : D ");
            Console.WriteLine("Remark: Level 1, well below agency normalized standards");
        }
        else if (percentage >= 40 && percentage<50)
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : E ");
            Console.WriteLine("Remark: Level -1, too below agency normalized standards");
        }
        else
        {
            Console.WriteLine($"Average Marks Obtained across 3 Subjects is {percentage}");
            Console.WriteLine("Grade : R ");
            Console.WriteLine("Remark: Remedial standards");
        }

    }
    public static void PrimeNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
            isPrime = false;
        else
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        Console.WriteLine(isPrime ? "Prime Number" : "Not a Prime Number");
    }

    public static void FizzBuzzFor()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
        }
    }

    public static void FizzBuzzWhile()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        while (i <= n)
        {
            if (i % 3 == 0 && i % 5 == 0) Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0) Console.WriteLine("Fizz");
            else if (i % 5 == 0) Console.WriteLine("Buzz");
            else Console.WriteLine(i);
            i++;
        }
    }

    public static void BMICalculator()
    {
        Console.Write("Weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height (cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);

        Console.WriteLine($"BMI = {bmi:F2}");
        if (bmi <= 18.4)
        {
            Console.WriteLine("Under Weight");
        }
        else if (bmi > 18.4 && bmi<= 24.9)
        {
            Console.WriteLine("Normal");
        }
        else if( bmi >=25 && bmi <= 39.9)
        {
            Console.WriteLine("Over Weight");
        }
        else
        {
            Console.WriteLine("Obese");
        }
    }

    public static void YoungestTallest()
    {
        Console.Write("Amar age & height: ");
        int aAge = Convert.ToInt32(Console.ReadLine());
        int aHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Akbar age & height: ");
        int akAge = Convert.ToInt32(Console.ReadLine());
        int akHeight = Convert.ToInt32(Console.ReadLine());

        Console.Write("Anthony age & height: ");
        int anAge = Convert.ToInt32(Console.ReadLine());
        int anHeight = Convert.ToInt32(Console.ReadLine());

        int youngest = Math.Min(aAge, Math.Min(akAge, anAge));
        int tallest = Math.Max(aHeight, Math.Max(akHeight, anHeight));

        Console.WriteLine("Youngest Age: " + youngest);
        Console.WriteLine("Tallest Height: " + tallest);
    }

    public static void GreatestFactor()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("Greatest Factor: " + greatestFactor);
    }

    public static void PowerOfNumber()
    {
        Console.Write("Number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++)
            result *= number;

        Console.WriteLine("Result = " + result);
    }

    public static void FactorsOfNumber()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }

    public static void MultiplesBelow100()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 100; i >= 1; i--)
        {
            if (i % number == 0)
                Console.WriteLine(i);
        }
    }

}