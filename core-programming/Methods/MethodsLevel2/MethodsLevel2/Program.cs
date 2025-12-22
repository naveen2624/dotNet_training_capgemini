using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Factors, Sum, Product");
            Console.WriteLine("2. Sum of Natural Numbers");
            Console.WriteLine("3. Leap Year Checker");
            Console.WriteLine("4. Unit Convertor - Distance");
            Console.WriteLine("5. Unit Convertor - Yards, Meters, Inches");
            Console.WriteLine("6. Unit Convertor - Temperature, Weight, Volume");
            Console.WriteLine("7. Student Vote Checker");
            Console.WriteLine("8. Youngest and Tallest Friend");
            Console.WriteLine("9. Positive, Negative, Even, Odd");
            Console.WriteLine("10. Body Mass Index Calculator");
            Console.WriteLine("11. Quadratic Equation Roots");
            Console.WriteLine("12. Random Numbers Statistics");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: FactorsSumProduct(); break;
                case 2: SumNaturalNumbers(); break;
                case 3: LeapYearChecker(); break;
                case 4: UnitConvertorDistance(); break;
                case 5: UnitConvertorYardsMetersInches(); break;
                case 6: UnitConvertorTempWeightVolume(); break;
                case 7: StudentVoteCheckerProgram(); break;
                case 8: YoungestTallestFriend(); break;
                case 9: PositiveNegativeEvenOdd(); break;
                case 10: BMICalculator(); break;
                case 11: QuadraticRoots(); break;
                case 12: RandomNumbersStats(); break;
            }
        }
    }

    public static void FactorsSumProduct()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int[] factors = FindFactors(number);

        Console.WriteLine("\nFactors of " + number + ":");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        int sum = FindSumOfFactors(factors);
        Console.WriteLine("\n\nSum of factors: " + sum);

        long product = FindProductOfFactors(factors);
        Console.WriteLine("Product of factors: " + product);

        double sumOfSquares = FindSumOfSquareOfFactors(factors);
        Console.WriteLine("Sum of square of factors: " + sumOfSquares);
    }

    public static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static long FindProductOfFactors(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }

    public static double FindSumOfSquareOfFactors(int[] factors)
    {
        double sumOfSquares = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sumOfSquares += Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }

    public static void SumNaturalNumbers()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number (positive integer).");
            return;
        }

        int recursiveSum = SumUsingRecursion(n);
        int formulaSum = SumUsingFormula(n);

        Console.WriteLine("\nSum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula n*(n+1)/2: " + formulaSum);

        if (recursiveSum == formulaSum)
        {
            Console.WriteLine("\nBoth results are correct and equal!");
        }
        else
        {
            Console.WriteLine("\nResults do not match.");
        }
    }

    public static int SumUsingRecursion(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n + SumUsingRecursion(n - 1);
    }

    public static int SumUsingFormula(int n)
    {
        return n * (n + 1) / 2;
    }

    public static void LeapYearChecker()
    {
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (IsLeapYear(year))
        {
            Console.WriteLine(year + " is a Leap Year");
        }
        else
        {
            Console.WriteLine(year + " is not a Leap Year");
        }
    }

    public static bool IsLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.WriteLine("Error: Year must be 1582 or later (Gregorian calendar).");
            return false;
        }

        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void UnitConvertorDistance()
    {
        Console.WriteLine("\n1. Kilometers to Miles");
        Console.WriteLine("2. Miles to Kilometers");
        Console.WriteLine("3. Meters to Feet");
        Console.WriteLine("4. Feet to Meters");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (choice)
        {
            case 1:
                result = ConvertKmToMiles(value);
                Console.WriteLine($"{value} km = {result} miles");
                break;
            case 2:
                result = ConvertMilesToKm(value);
                Console.WriteLine($"{value} miles = {result} km");
                break;
            case 3:
                result = ConvertMetersToFeet(value);
                Console.WriteLine($"{value} meters = {result} feet");
                break;
            case 4:
                result = ConvertFeetToMeters(value);
                Console.WriteLine($"{value} feet = {result} meters");
                break;
        }
    }

    public static double ConvertKmToMiles(double km)
    {
        double km2miles = 0.621371;
        return km * km2miles;
    }

    public static double ConvertMilesToKm(double miles)
    {
        double miles2km = 1.60934;
        return miles * miles2km;
    }

    public static double ConvertMetersToFeet(double meters)
    {
        double meters2feet = 3.28084;
        return meters * meters2feet;
    }

    public static double ConvertFeetToMeters(double feet)
    {
        double feet2meters = 0.3048;
        return feet * feet2meters;
    }

    public static void UnitConvertorYardsMetersInches()
    {
        Console.WriteLine("\n1. Yards to Feet");
        Console.WriteLine("2. Feet to Yards");
        Console.WriteLine("3. Meters to Inches");
        Console.WriteLine("4. Inches to Meters");
        Console.WriteLine("5. Inches to Centimeters");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (choice)
        {
            case 1:
                result = ConvertYardsToFeet(value);
                Console.WriteLine($"{value} yards = {result} feet");
                break;
            case 2:
                result = ConvertFeetToYards(value);
                Console.WriteLine($"{value} feet = {result} yards");
                break;
            case 3:
                result = ConvertMetersToInches(value);
                Console.WriteLine($"{value} meters = {result} inches");
                break;
            case 4:
                result = ConvertInchesToMeters(value);
                Console.WriteLine($"{value} inches = {result} meters");
                break;
            case 5:
                result = ConvertInchesToCentimeters(value);
                Console.WriteLine($"{value} inches = {result} cm");
                break;
        }
    }

    public static double ConvertYardsToFeet(double yards)
    {
        double yards2feet = 3;
        return yards * yards2feet;
    }

    public static double ConvertFeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet * feet2yards;
    }

    public static double ConvertMetersToInches(double meters)
    {
        double meters2inches = 39.3701;
        return meters * meters2inches;
    }

    public static double ConvertInchesToMeters(double inches)
    {
        double inches2meters = 0.0254;
        return inches * inches2meters;
    }

    public static double ConvertInchesToCentimeters(double inches)
    {
        double inches2cm = 2.54;
        return inches * inches2cm;
    }

    public static void UnitConvertorTempWeightVolume()
    {
        Console.WriteLine("\n1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.WriteLine("3. Pounds to Kilograms");
        Console.WriteLine("4. Kilograms to Pounds");
        Console.WriteLine("5. Gallons to Liters");
        Console.WriteLine("6. Liters to Gallons");
        Console.Write("Enter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value: ");
        double value = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (choice)
        {
            case 1:
                result = ConvertFahrenheitToCelsius(value);
                Console.WriteLine($"{value}°F = {result}°C");
                break;
            case 2:
                result = ConvertCelsiusToFahrenheit(value);
                Console.WriteLine($"{value}°C = {result}°F");
                break;
            case 3:
                result = ConvertPoundsToKilograms(value);
                Console.WriteLine($"{value} lbs = {result} kg");
                break;
            case 4:
                result = ConvertKilogramsToPounds(value);
                Console.WriteLine($"{value} kg = {result} lbs");
                break;
            case 5:
                result = ConvertGallonsToLiters(value);
                Console.WriteLine($"{value} gallons = {result} liters");
                break;
            case 6:
                result = ConvertLitersToGallons(value);
                Console.WriteLine($"{value} liters = {result} gallons");
                break;
        }
    }

    public static double ConvertFahrenheitToCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    public static double ConvertPoundsToKilograms(double pounds)
    {
        double pounds2kilograms = 0.453592;
        return pounds * pounds2kilograms;
    }

    public static double ConvertKilogramsToPounds(double kilograms)
    {
        double kilograms2pounds = 2.20462;
        return kilograms * kilograms2pounds;
    }

    public static double ConvertGallonsToLiters(double gallons)
    {
        double gallons2liters = 3.78541;
        return gallons * gallons2liters;
    }

    public static double ConvertLitersToGallons(double liters)
    {
        double liters2gallons = 0.264172;
        return liters * liters2gallons;
    }

    public static void StudentVoteCheckerProgram()
    {
        int[] ages = new int[10];
        Console.WriteLine("Enter ages of 10 students:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Student {i + 1} age: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nVoting Eligibility:");
        for (int i = 0; i < 10; i++)
        {
            if (CanStudentVote(ages[i]))
            {
                Console.WriteLine($"Student {i + 1} can vote");
            }
            else
            {
                Console.WriteLine($"Student {i + 1} cannot vote");
            }
        }
    }

    public static bool CanStudentVote(int age)
    {
        if (age < 0)
        {
            return false;
        }

        if (age >= 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void YoungestTallestFriend()
    {
        int[] ages = new int[3];
        double[] heights = new double[3];
        string[] names = { "Amar", "Akbar", "Anthony" };

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter height of {names[i]} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestIndex = FindYoungest(ages);
        int tallestIndex = FindTallest(heights);

        Console.WriteLine($"\nYoungest friend: {names[youngestIndex]} (Age: {ages[youngestIndex]})");
        Console.WriteLine($"Tallest friend: {names[tallestIndex]} (Height: {heights[tallestIndex]} cm)");
    }

    public static int FindYoungest(int[] ages)
    {
        int minAge = ages[0];
        int minIndex = 0;

        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < minAge)
            {
                minAge = ages[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    public static int FindTallest(double[] heights)
    {
        double maxHeight = heights[0];
        int maxIndex = 0;

        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > maxHeight)
            {
                maxHeight = heights[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static void PositiveNegativeEvenOdd()
    {
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nAnalysis:");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPositive(numbers[i]))
            {
                Console.Write($"Number {i + 1}: {numbers[i]} is Positive");
                if (IsEven(numbers[i]))
                {
                    Console.WriteLine(" and Even");
                }
                else
                {
                    Console.WriteLine(" and Odd");
                }
            }
            else
            {
                Console.WriteLine($"Number {i + 1}: {numbers[i]} is Negative");
            }
        }

        int comparison = Compare(numbers[0], numbers[4]);
        Console.WriteLine("\nComparison of first and last elements:");
        if (comparison == 0)
        {
            Console.WriteLine($"{numbers[0]} and {numbers[4]} are equal");
        }
        else if (comparison == 1)
        {
            Console.WriteLine($"{numbers[0]} is greater than {numbers[4]}");
        }
        else
        {
            Console.WriteLine($"{numbers[0]} is less than {numbers[4]}");
        }
    }

    public static bool IsPositive(int number)
    {
        return number > 0;
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static int Compare(int number1, int number2)
    {
        if (number1 > number2)
        {
            return 1;
        }
        else if (number1 == number2)
        {
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public static void BMICalculator()
    {
        double[,] data = new double[10, 3];

        Console.WriteLine("Enter weight and height for 10 persons:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Person {i + 1} weight (kg): ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Person {i + 1} height (cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        CalculateBMI(data);
        string[] statuses = GetBMIStatus(data);

        Console.WriteLine("\nBMI Results:");
        Console.WriteLine("Person\tWeight(kg)\tHeight(cm)\tBMI\t\tStatus");
        Console.WriteLine("--------------------------------------------------------------");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t\t{data[i, 2]:F2}\t\t{statuses[i]}");
        }
    }

    public static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < data.GetLength(0); i++)
        {
            double weight = data[i, 0];
            double heightInMeters = data[i, 1] / 100;
            data[i, 2] = weight / (heightInMeters * heightInMeters);
        }
    }

    public static string[] GetBMIStatus(double[,] data)
    {
        string[] statuses = new string[data.GetLength(0)];

        for (int i = 0; i < data.GetLength(0); i++)
        {
            double bmi = data[i, 2];

            if (bmi < 18.5)
            {
                statuses[i] = "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                statuses[i] = "Normal";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                statuses[i] = "Overweight";
            }
            else
            {
                statuses[i] = "Obese";
            }
        }

        return statuses;
    }

    public static void QuadraticRoots()
    {
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindQuadraticRoots(a, b, c);

        if (roots.Length == 0)
        {
            Console.WriteLine("\nNo real roots exist (discriminant is negative)");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"\nOne root: x = {roots[0]}");
        }
        else
        {
            Console.WriteLine($"\nTwo roots:");
            Console.WriteLine($"x1 = {roots[0]}");
            Console.WriteLine($"x2 = {roots[1]}");
        }
    }

    public static double[] FindQuadraticRoots(double a, double b, double c)
    {
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta > 0)
        {
            double[] roots = new double[2];
            roots[0] = (-b + Math.Sqrt(delta)) / (2 * a);
            roots[1] = (-b - Math.Sqrt(delta)) / (2 * a);
            return roots;
        }
        else if (delta == 0)
        {
            double[] roots = new double[1];
            roots[0] = -b / (2 * a);
            return roots;
        }
        else
        {
            return new double[0];
        }
    }

    public static void RandomNumbersStats()
    {
        int[] randomNumbers = Generate4DigitRandomArray(5);

        Console.WriteLine("Generated 4-digit random numbers:");
        for (int i = 0; i < randomNumbers.Length; i++)
        {
            Console.WriteLine($"Number {i + 1}: {randomNumbers[i]}");
        }

        double[] stats = FindAverageMinMax(randomNumbers);

        Console.WriteLine($"\nAverage: {stats[0]:F2}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }

    public static int[] Generate4DigitRandomArray(int size)
    {
        int[] numbers = new int[size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(1000, 10000);
        }

        return numbers;
    }

    public static double[] FindAverageMinMax(int[] numbers)
    {
        double[] result = new double[3];

        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }

        result[0] = sum / numbers.Length;
        result[1] = min;
        result[2] = max;

        return result;
    }
}