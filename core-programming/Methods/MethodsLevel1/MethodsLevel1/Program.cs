using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Calculate Simple Interest");
            Console.WriteLine("2. Calculate Maximum Handshakes");
            Console.WriteLine("3. Calculate Maximum Handshakes");
            Console.WriteLine("4. Calculate Athlete Rounds");
            Console.WriteLine("5. Check Number Positive/Negative/Zero");
            Console.WriteLine("6. Check Spring Season");
            Console.WriteLine("7. Sum of Natural Numbers");
            Console.WriteLine("8. Find Smallest and Largest of Three Numbers");
            Console.WriteLine("9. Find Quotient and Remainder");
            Console.WriteLine("10. Chocolate Distribution");
            Console.WriteLine("11. Calculate Wind Chill");
            Console.WriteLine("12. Trigonometry Calculator");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SimpleInterest();
                    break;
                case 2:
                    HandShake();
                    break;
                case 3:
                    HandShake();
                    break;
                case 4:
                    Athelete();
                    break;
                case 5:
                    NumberCheck();
                    break;
                case 6:
                    SpringSeason(new string[] { "3", "21" });
                    break;
                case 7:
                    SumOfNaturalNumbers();
                    break;
                case 8:
                    SmallestLargest();
                    break;
                case 9:
                    QuotientRemainder();
                    break;
                case 10:   
                    ChocolateDistribution();
                    break;
                case 11:
                    WindChill();
                    break;
                case 12:
                    TrignometryCalculator();
                    break;
                case 0:
                    Console.WriteLine("Exiting the program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
    static void SimpleInterest()
    {
        Console.Write("Enter Principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = CalculateSimpleInterest(principal, rate, time);

        Console.WriteLine(
            $"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time}"
        );

        static double CalculateSimpleInterest(double principal, double rate, double time)
        {
            return (principal * rate * time) / 100;
        }
    }
    static void HandShake()
    {
        Console.Write("Enter number of students: ");
        int students = Convert.ToInt32(Console.ReadLine());

        int handshakes = CalculateHandshakes(students);

        Console.WriteLine($"Maximum number of handshakes among {students} students is {handshakes}");

        static int CalculateHandshakes(int n)
        {
            return (n * (n - 1)) / 2;
        }
    }
    static void Athelete()
    {
        Console.Write("Enter side 1 of the triangular park (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2 of the triangular park (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3 of the triangular park (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        double rounds = CalculateRounds(side1, side2, side3);

        Console.WriteLine($"The athlete must complete {rounds:F2} rounds to finish a 5 km run.");
        static double CalculateRounds(double side1, double side2, double side3)
        {
            double perimeter = side1 + side2 + side3;
            double totalDistance = 5000;
            return totalDistance / perimeter;
        }
    }
    static void NumberCheck()
    {
        Console.Write("Enter an integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = CheckNumber(number);

        if (result == 1)
            Console.WriteLine("The number is Positive");
        else if (result == -1)
            Console.WriteLine("The number is Negative");
        else
            Console.WriteLine("The number is Zero");
        static int CheckNumber(int number)
        {
            if (number > 0)
                return 1;
            else if (number < 0)
                return -1;
            else
                return 0;
        }
    }
    static void SpringSeason(string[] args)
    {
        int month = Convert.ToInt32(args[0]);
        int day = Convert.ToInt32(args[1]);

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
            Console.WriteLine("Its a Spring Season");
        else
            Console.WriteLine("Not a Spring Season");
        static bool IsSpringSeason(int month, int day)
        {
            if ((month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20))
            {
                return true;
            }
            return false;
        }
    }
    static void SumOfNaturalNumbers()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = CalculateSum(n);

        Console.WriteLine($"The sum of first {n} natural numbers is {result}");
        static int CalculateSum(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

    }
    static void SmallestLargest()
    {
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);

        Console.WriteLine($"Smallest number is: {result[0]}");
        Console.WriteLine($"Largest number is: {result[1]}");
        static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
        int smallest = number1;
        int largest = number1;

        if (number2 < smallest)
            smallest = number2;
        if (number2 > largest)
            largest = number2;

        if (number3 < smallest)
            smallest = number3;
        if (number3 > largest)
            largest = number3;

        return new int[] { smallest, largest };
        }
    }
    static void QuotientRemainder()
    {
        Console.Write("Enter the number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine($"Quotient: {result[0]}");
        Console.WriteLine($"Remainder: {result[1]}");
        static int[] FindRemainderAndQuotient(int number, int divisor)
        {
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
        }
    }
    static void ChocolateDistribution()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);

        Console.WriteLine($"Each child gets {result[0]} chocolates");
        Console.WriteLine($"Remaining chocolates: {result[1]}");
        static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            return new int[] { chocolatesPerChild, remainingChocolates };
        }
    }
    static void WindChill()
    {
        Console.Write("Enter temperature: ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double result = CalculateWindChill(temperature, windSpeed);

        Console.WriteLine($"Wind Chill Temperature is: {result:F2}");
        static double CalculateWindChill(double temperature, double windSpeed)
        {
        double windChill = 35.74 + (0.6215 * temperature) +
                           ((0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16));
        return windChill;
        }
    }
    static void TrignometryCalculator()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);

        Console.WriteLine($"Sine: {result[0]:F4}");
        Console.WriteLine($"Cosine: {result[1]:F4}");
        Console.WriteLine($"Tangent: {result[2]:F4}");
        static double[] CalculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            return new double[] { sin, cos, tan };
        }
    }
}