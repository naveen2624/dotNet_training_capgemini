using System;
class Program
{
    static void Main()
    {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Football Team Heights");
            Console.WriteLine("2. Number Checker - Duck, Armstrong");
            Console.WriteLine("3. Number Checker - Harshad, Frequency");
            Console.WriteLine("4. Number Checker - Palindrome");
            Console.WriteLine("5. Number Checker - Prime, Neon, Spy");
            Console.WriteLine("6. Number Checker - Perfect, Abundant");
            Console.WriteLine("7. OTP Generator");
            Console.WriteLine("8. Calendar Display");
            Console.WriteLine("9. Euclidean Distance");
            Console.WriteLine("10. Collinear Points");
            Console.WriteLine("11. Employee Bonus Calculator");
            Console.WriteLine("12. Student Scorecard");
            Console.WriteLine("13. Matrix Operations");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You"); break;
                case 1: FootballTeamHeights(); break;
                case 2: NumberCheckerDuckArmstrong(); break;
                case 3: NumberCheckerHarshadFrequency(); break;
                case 4: NumberCheckerPalindrome(); break;
                case 5: NumberCheckerPrimeNeonSpy(); break;
                case 6: NumberCheckerPerfectAbundant(); break;
                case 7: OTPGenerator(); break;
                case 8: CalendarDisplay(); break;
                case 9: EuclideanDistance(); break;
                case 10: CollinearPoints(); break;
                case 11: EmployeeBonusCalculator(); break;
                case 12: StudentScorecard(); break;
                case 13: MatrixOperations(); break;
            }
        }
    }

    public static void FootballTeamHeights()
    {
        int[] heights = new int[11];
        Random random = new Random();

        Console.WriteLine("Generating random heights for 11 football players (150-250 cm):");
        for (int i = 0; i < 11; i++)
        {
            heights[i] = random.Next(150, 251);
            Console.WriteLine($"Player {i + 1}: {heights[i]} cm");
        }

        int sum = FindSum(heights);
        double mean = FindMeanHeight(heights);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        Console.WriteLine($"\nSum of heights: {sum} cm");
        Console.WriteLine($"Mean height: {mean:F2} cm");
        Console.WriteLine($"Shortest height: {shortest} cm");
        Console.WriteLine($"Tallest height: {tallest} cm");
    }

    public static int FindSum(int[] heights)
    {
        int sum = 0;
        for (int i = 0; i < heights.Length; i++)
        {
            sum += heights[i];
        }
        return sum;
    }

    public static double FindMeanHeight(int[] heights)
    {
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    public static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] < shortest)
            {
                shortest = heights[i];
            }
        }
        return shortest;
    }

    public static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallest)
            {
                tallest = heights[i];
            }
        }
        return tallest;
    }

    public static void NumberCheckerDuckArmstrong()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int count = CountDigits(number);
        int[] digits = StoreDigits(number);

        Console.WriteLine($"\nNumber of digits: {count}");
        Console.Write("Digits: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }

        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine($"\n\nIs Duck Number: {isDuck}");

        bool isArmstrong = IsArmstrongNumber(number, digits);
        Console.WriteLine($"Is Armstrong Number: {isArmstrong}");

        int[] largest = FindLargestAndSecondLargest(digits);
        Console.WriteLine($"\nLargest digit: {largest[0]}");
        Console.WriteLine($"Second largest digit: {largest[1]}");

        int[] smallest = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine($"Smallest digit: {smallest[0]}");
        Console.WriteLine($"Second smallest digit: {smallest[1]}");
    }

    public static int CountDigits(int number)
    {
        if (number == 0) return 1;
        int count = 0;
        int temp = Math.Abs(number);
        while (temp > 0)
        {
            count++;
            temp /= 10;
        }
        return count;
    }

    public static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];
        int temp = Math.Abs(number);
        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }
        return digits;
    }

    public static bool IsDuckNumber(int[] digits)
    {
        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] == 0)
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsArmstrongNumber(int number, int[] digits)
    {
        int sum = 0;
        int power = digits.Length;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += (int)Math.Pow(digits[i], power);
        }
        return sum == number;
    }

    public static int[] FindLargestAndSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] > largest)
            {
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest)
            {
                secondLargest = digits[i];
            }
        }

        return new int[] { largest, secondLargest };
    }

    public static int[] FindSmallestAndSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for (int i = 0; i < digits.Length; i++)
        {
            if (digits[i] < smallest)
            {
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if (digits[i] < secondSmallest && digits[i] != smallest)
            {
                secondSmallest = digits[i];
            }
        }

        return new int[] { smallest, secondSmallest };
    }

    public static void NumberCheckerHarshadFrequency()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        int sum = SumOfDigits(digits);
        Console.WriteLine($"\nSum of digits: {sum}");

        double sumOfSquares = SumOfSquaresOfDigits(digits);
        Console.WriteLine($"Sum of squares of digits: {sumOfSquares}");

        bool isHarshad = IsHarshadNumber(number, digits);
        Console.WriteLine($"Is Harshad Number: {isHarshad}");

        int[,] frequency = FindDigitFrequency(digits);
        Console.WriteLine("\nDigit Frequency:");
        Console.WriteLine("Digit\tFrequency");
        for (int i = 0; i < frequency.GetLength(0); i++)
        {
            if (frequency[i, 1] > 0)
            {
                Console.WriteLine($"{frequency[i, 0]}\t{frequency[i, 1]}");
            }
        }
    }

    public static int SumOfDigits(int[] digits)
    {
        int sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
        }
        return sum;
    }

    public static double SumOfSquaresOfDigits(int[] digits)
    {
        double sum = 0;
        for (int i = 0; i < digits.Length; i++)
        {
            sum += Math.Pow(digits[i], 2);
        }
        return sum;
    }

    public static bool IsHarshadNumber(int number, int[] digits)
    {
        int sum = SumOfDigits(digits);
        return sum != 0 && number % sum == 0;
    }

    public static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] frequency = new int[10, 2];
        for (int i = 0; i < 10; i++)
        {
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }

        for (int i = 0; i < digits.Length; i++)
        {
            frequency[digits[i], 1]++;
        }

        return frequency;
    }

    public static void NumberCheckerPalindrome()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);
        int[] reversed = ReverseDigitsArray(digits);

        Console.Write("\nOriginal digits: ");
        for (int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }

        Console.Write("\nReversed digits: ");
        for (int i = 0; i < reversed.Length; i++)
        {
            Console.Write(reversed[i] + " ");
        }

        bool areEqual = CompareArrays(digits, reversed);
        Console.WriteLine($"\n\nArrays are equal: {areEqual}");

        bool isPalindrome = IsPalindromeNumber(digits);
        Console.WriteLine($"Is Palindrome Number: {isPalindrome}");

        bool isDuck = IsDuckNumber(digits);
        Console.WriteLine($"Is Duck Number: {isDuck}");
    }

    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed = new int[digits.Length];
        for (int i = 0; i < digits.Length; i++)
        {
            reversed[i] = digits[digits.Length - 1 - i];
        }
        return reversed;
    }

    public static bool CompareArrays(int[] arr1, int[] arr2)
    {
        if (arr1.Length != arr2.Length)
        {
            return false;
        }

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsPalindromeNumber(int[] digits)
    {
        int[] reversed = ReverseDigitsArray(digits);
        return CompareArrays(digits, reversed);
    }

    public static void NumberCheckerPrimeNeonSpy()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = IsPrimeNumber(number);
        Console.WriteLine($"\nIs Prime Number: {isPrime}");

        bool isNeon = IsNeonNumber(number);
        Console.WriteLine($"Is Neon Number: {isNeon}");

        bool isSpy = IsSpyNumber(number);
        Console.WriteLine($"Is Spy Number: {isSpy}");

        bool isAutomorphic = IsAutomorphicNumber(number);
        Console.WriteLine($"Is Automorphic Number: {isAutomorphic}");

        bool isBuzz = IsBuzzNumber(number);
        Console.WriteLine($"Is Buzz Number: {isBuzz}");
    }

    public static bool IsPrimeNumber(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsNeonNumber(int number)
    {
        int square = number * number;
        int[] digits = StoreDigits(square);
        int sum = SumOfDigits(digits);
        return sum == number;
    }

    public static bool IsSpyNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;
        int product = 1;

        for (int i = 0; i < digits.Length; i++)
        {
            sum += digits[i];
            product *= digits[i];
        }

        return sum == product;
    }

    public static bool IsAutomorphicNumber(int number)
    {
        int square = number * number;
        string numStr = number.ToString();
        string squareStr = square.ToString();

        return squareStr.EndsWith(numStr);
    }

    public static bool IsBuzzNumber(int number)
    {
        return (number % 7 == 0) || (number % 10 == 7);
    }

    public static void NumberCheckerPerfectAbundant()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] factors = FindFactorsArray(number);

        Console.Write("\nFactors: ");
        for (int i = 0; i < factors.Length; i++)
        {
            Console.Write(factors[i] + " ");
        }

        int greatestFactor = FindGreatestFactor(factors);
        Console.WriteLine($"\n\nGreatest factor: {greatestFactor}");

        int sumFactors = SumOfFactors(factors);
        Console.WriteLine($"Sum of factors: {sumFactors}");

        long productFactors = ProductOfFactors(factors);
        Console.WriteLine($"Product of factors: {productFactors}");

        double productCube = ProductOfCubeOfFactors(factors);
        Console.WriteLine($"Product of cube of factors: {productCube}");

        bool isPerfect = IsPerfectNumber(number);
        Console.WriteLine($"\nIs Perfect Number: {isPerfect}");

        bool isAbundant = IsAbundantNumber(number);
        Console.WriteLine($"Is Abundant Number: {isAbundant}");

        bool isDeficient = IsDeficientNumber(number);
        Console.WriteLine($"Is Deficient Number: {isDeficient}");

        bool isStrong = IsStrongNumber(number);
        Console.WriteLine($"Is Strong Number: {isStrong}");
    }

    public static int[] FindFactorsArray(int number)
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

    public static int FindGreatestFactor(int[] factors)
    {
        int greatest = factors[0];
        for (int i = 1; i < factors.Length; i++)
        {
            if (factors[i] > greatest)
            {
                greatest = factors[i];
            }
        }
        return greatest;
    }

    public static int SumOfFactors(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    public static long ProductOfFactors(int[] factors)
    {
        long product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= factors[i];
        }
        return product;
    }

    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product = 1;
        for (int i = 0; i < factors.Length; i++)
        {
            product *= Math.Pow(factors[i], 3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }

    public static bool IsAbundantNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum > number;
    }

    public static bool IsDeficientNumber(int number)
    {
        int sum = 0;
        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum < number;
    }

    public static bool IsStrongNumber(int number)
    {
        int[] digits = StoreDigits(number);
        int sum = 0;

        for (int i = 0; i < digits.Length; i++)
        {
            sum += Factorial(digits[i]);
        }

        return sum == number;
    }

    public static int Factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        int result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    public static void OTPGenerator()
    {
        int[] otps = new int[10];

        Console.WriteLine("Generating 10 OTP numbers:");
        for (int i = 0; i < 10; i++)
        {
            otps[i] = GenerateOTP();
            Console.WriteLine($"OTP {i + 1}: {otps[i]}");
        }

        bool areUnique = AreOTPsUnique(otps);
        Console.WriteLine($"\nAll OTPs are unique: {areUnique}");
    }

    public static int GenerateOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    public static bool AreOTPsUnique(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    public static void CalendarDisplay()
    {
        Console.Write("Enter month (1-12): ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month");
            return;
        }

        string monthName = GetMonthName(month);
        int daysInMonth = GetDaysInMonth(month, year);
        int firstDay = GetFirstDayOfMonth(month, year);

        Console.WriteLine($"\n   {monthName} {year}");
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        for (int i = 0; i < firstDay; i++)
        {
            Console.Write("    ");
        }

        for (int day = 1; day <= daysInMonth; day++)
        {
            Console.Write($"{day,3} ");
            if ((day + firstDay) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }

    public static string GetMonthName(int month)
    {
        string[] months = { "January", "February", "March", "April", "May", "June",
                           "July", "August", "September", "October", "November", "December" };
        return months[month - 1];
    }

    public static int GetDaysInMonth(int month, int year)
    {
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (month == 2 && IsLeapYearCalendar(year))
        {
            return 29;
        }

        return days[month - 1];
    }

    public static bool IsLeapYearCalendar(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public static int GetFirstDayOfMonth(int month, int year)
    {
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (1 + x + 31 * m0 / 12) % 7;
        return d0;
    }

    public static void EuclideanDistance()
    {
        Console.WriteLine("Enter coordinates for two points:");
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double distance = CalculateEuclideanDistance(x1, y1, x2, y2);
        Console.WriteLine($"\nEuclidean distance: {distance:F2}");

        double[] lineEquation = FindLineEquation(x1, y1, x2, y2);
        Console.WriteLine($"\nEquation of line: y = {lineEquation[0]:F2}x + {lineEquation[1]:F2}");
        Console.WriteLine($"Slope (m): {lineEquation[0]:F2}");
        Console.WriteLine($"Y-intercept (b): {lineEquation[1]:F2}");
    }

    public static double CalculateEuclideanDistance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public static double[] FindLineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }

    public static void CollinearPoints()
    {
        Console.WriteLine("Enter coordinates for three points:");
        Console.Write("x1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("x3: ");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y3: ");
        double y3 = Convert.ToDouble(Console.ReadLine());

        bool collinearSlope = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"\nAre collinear (using slope): {collinearSlope}");

        bool collinearArea = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);
        Console.WriteLine($"Are collinear (using area): {collinearArea}");
    }

    public static bool AreCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        if (x2 - x1 == 0 || x3 - x2 == 0 || x3 - x1 == 0)
        {
            return (x2 - x1 == 0 && x3 - x1 == 0);
        }

        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);

        return Math.Abs(slopeAB - slopeBC) < 0.0001 && Math.Abs(slopeBC - slopeAC) < 0.0001;
    }

    public static bool AreCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
        return Math.Abs(area) < 0.0001;
    }

    public static void EmployeeBonusCalculator()
    {
        double[,] employeeData = GenerateEmployeeData(10);

        Console.WriteLine("Employee Data (Salary and Years of Service):");
        Console.WriteLine("Employee\tSalary\t\tYears");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t\t{employeeData[i, 0]:F2}\t\t{employeeData[i, 1]}");
        }

        double[,] bonusData = CalculateBonusAndNewSalary(employeeData);

        Console.WriteLine("\nEmployee Bonus and New Salary:");
        Console.WriteLine("Employee\tOld Salary\tBonus\t\tNew Salary");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}\t\t{employeeData[i, 0]:F2}\t\t{bonusData[i, 1]:F2}\t\t{bonusData[i, 0]:F2}");
        }

        double[] totals = CalculateTotals(employeeData, bonusData);
        Console.WriteLine("\n---------------------------------------------------------");
        Console.WriteLine($"Total Old Salary: {totals[0]:F2}");
        Console.WriteLine($"Total New Salary: {totals[1]:F2}");
        Console.WriteLine($"Total Bonus: {totals[2]:F2}");
    }

    public static double[,] GenerateEmployeeData(int count)
    {
        double[,] data = new double[count, 2];
        Random random = new Random();

        for (int i = 0; i < count; i++)
        {
            data[i, 0] = random.Next(10000, 100000);
            data[i, 1] = random.Next(1, 11);
        }

        return data;
    }

    public static double[,] CalculateBonusAndNewSalary(double[,] employeeData)
    {
        double[,] bonusData = new double[employeeData.GetLength(0), 2];

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            double salary = employeeData[i, 0];
            double years = employeeData[i, 1];
            double bonusPercent = years > 5 ? 0.05 : 0.02;
            double bonus = salary * bonusPercent;
            double newSalary = salary + bonus;

            bonusData[i, 0] = newSalary;
            bonusData[i, 1] = bonus;
        }

        return bonusData;
    }

    public static double[] CalculateTotals(double[,] employeeData, double[,] bonusData)
    {
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;

        for (int i = 0; i < employeeData.GetLength(0); i++)
        {
            totalOldSalary += employeeData[i, 0];
            totalNewSalary += bonusData[i, 0];
            totalBonus += bonusData[i, 1];
        }

        return new double[] { totalOldSalary, totalNewSalary, totalBonus };
    }

    public static void StudentScorecard()
    {
        Console.Write("Enter number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        double[,] scores = GenerateScores(numStudents);

        Console.WriteLine("\nGenerated Scores (Physics, Chemistry, Maths):");
        for (int i = 0; i < numStudents; i++)
        {
            Console.WriteLine($"Student {i + 1}: {scores[i, 0]}, {scores[i, 1]}, {scores[i, 2]}");
        }

        double[,] results = CalculateResults(scores);

        DisplayScorecard(scores, results);
    }

    public static double[,] GenerateScores(int numStudents)
    {
        double[,] scores = new double[numStudents, 3];
        Random random = new Random();

        for (int i = 0; i < numStudents; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                scores[i, j] = random.Next(10, 100);
            }
        }

        return scores;
    }

    public static double[,] CalculateResults(double[,] scores)
    {
        double[,] results = new double[scores.GetLength(0), 3];

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            double total = scores[i, 0] + scores[i, 1] + scores[i, 2];
            double average = total / 3;
            double percentage = (total / 300) * 100;

            results[i, 0] = Math.Round(total, 2);
            results[i, 1] = Math.Round(average, 2);
            results[i, 2] = Math.Round(percentage, 2);
        }

        return results;
    }

    public static void DisplayScorecard(double[,] scores, double[,] results)
    {
        Console.WriteLine("\n========== Student Scorecard ==========");
        Console.WriteLine("Student\tPhysics\tChemistry\tMaths\tTotal\tAverage\tPercentage");
        Console.WriteLine("-----------------------------------------------------------------------");

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            Console.WriteLine($"{i + 1}\t{scores[i, 0]}\t{scores[i, 1]}\t\t{scores[i, 2]}\t{results[i, 0]}\t{results[i, 1]}\t{results[i, 2]}%");
        }
    }

    public static void MatrixOperations()
    {
        Console.WriteLine("Matrix Operations");
        Console.WriteLine("\n1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Transpose");
        Console.WriteLine("5. Determinant");
        Console.WriteLine("6. Inverse");
        Console.Write("\nEnter choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        if (choice >= 1 && choice <= 3)
        {
            Console.Write("Enter rows for matrices: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns for matrices: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            double[,] matrix1 = CreateRandomMatrix(rows, cols);
            double[,] matrix2 = CreateRandomMatrix(rows, cols);

            Console.WriteLine("\nMatrix 1:");
            DisplayMatrix(matrix1);
            Console.WriteLine("\nMatrix 2:");
            DisplayMatrix(matrix2);

            if (choice == 1)
            {
                double[,] result = AddMatrices(matrix1, matrix2);
                Console.WriteLine("\nResult (Addition):");
                DisplayMatrix(result);
            }
            else if (choice == 2)
            {
                double[,] result = SubtractMatrices(matrix1, matrix2);
                Console.WriteLine("\nResult (Subtraction):");
                DisplayMatrix(result);
            }
            else if (choice == 3)
            {
                Console.Write("Enter columns for second matrix: ");
                int cols2 = Convert.ToInt32(Console.ReadLine());
                matrix2 = CreateRandomMatrix(cols, cols2);
                Console.WriteLine("\nMatrix 2:");
                DisplayMatrix(matrix2);
                double[,] result = MultiplyMatrices(matrix1, matrix2);
                Console.WriteLine("\nResult (Multiplication):");
                DisplayMatrix(result);
            }
        }
        else if (choice == 4)
        {
            Console.Write("Enter rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            double[,] matrix = CreateRandomMatrix(rows, cols);
            Console.WriteLine("\nOriginal Matrix:");
            DisplayMatrix(matrix);

            double[,] transpose = TransposeMatrix(matrix);
            Console.WriteLine("\nTranspose:");
            DisplayMatrix(transpose);
        }
        else if (choice == 5)
        {
            Console.WriteLine("\n1. 2x2 Matrix");
            Console.WriteLine("2. 3x3 Matrix");
            Console.Write("Enter choice: ");
            int detChoice = Convert.ToInt32(Console.ReadLine());

            if (detChoice == 1)
            {
                double[,] matrix = CreateRandomMatrix(2, 2);
                Console.WriteLine("\nMatrix:");
                DisplayMatrix(matrix);
                double det = Determinant2x2(matrix);
                Console.WriteLine($"\nDeterminant: {det:F2}");
            }
            else if (detChoice == 2)
            {
                double[,] matrix = CreateRandomMatrix(3, 3);
                Console.WriteLine("\nMatrix:");
                DisplayMatrix(matrix);
                double det = Determinant3x3(matrix);
                Console.WriteLine($"\nDeterminant: {det:F2}");
            }
        }
        else if (choice == 6)
        {
            Console.WriteLine("\n1. 2x2 Matrix");
            Console.WriteLine("2. 3x3 Matrix");
            Console.Write("Enter choice: ");
            int invChoice = Convert.ToInt32(Console.ReadLine());

            if (invChoice == 1)
            {
                double[,] matrix = CreateRandomMatrix(2, 2);
                Console.WriteLine("\nMatrix:");
                DisplayMatrix(matrix);
                double[,] inverse = Inverse2x2(matrix);
                if (inverse != null)
                {
                    Console.WriteLine("\nInverse:");
                    DisplayMatrix(inverse);
                }
                else
                {
                    Console.WriteLine("\nMatrix is not invertible (determinant is zero)");
                }
            }
            else if (invChoice == 2)
            {
                double[,] matrix = CreateRandomMatrix(3, 3);
                Console.WriteLine("\nMatrix:");
                DisplayMatrix(matrix);
                double[,] inverse = Inverse3x3(matrix);
                if (inverse != null)
                {
                    Console.WriteLine("\nInverse:");
                    DisplayMatrix(inverse);
                }
                else
                {
                    Console.WriteLine("\nMatrix is not invertible (determinant is zero)");
                }
            }
        }
    }

    public static double[,] CreateRandomMatrix(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(1, 10);
            }
        }

        return matrix;
    }

    public static double[,] AddMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }

    public static double[,] SubtractMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows = matrix1.GetLength(0);
        int cols = matrix1.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix1[i, j] - matrix2[i, j];
            }
        }

        return result;
    }

    public static double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int cols2 = matrix2.GetLength(1);
        double[,] result = new double[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < cols1; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        return result;
    }

    public static double[,] TransposeMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transpose[j, i] = matrix[i, j];
            }
        }

        return transpose;
    }

    public static double Determinant2x2(double[,] matrix)
    {
        return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
    }

    public static double Determinant3x3(double[,] matrix)
    {
        double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1])
                   - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                   + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);
        return det;
    }

    public static double[,] Inverse2x2(double[,] matrix)
    {
        double det = Determinant2x2(matrix);

        if (Math.Abs(det) < 0.0001)
        {
            return null;
        }

        double[,] inverse = new double[2, 2];
        inverse[0, 0] = matrix[1, 1] / det;
        inverse[0, 1] = -matrix[0, 1] / det;
        inverse[1, 0] = -matrix[1, 0] / det;
        inverse[1, 1] = matrix[0, 0] / det;

        return inverse;
    }

    public static double[,] Inverse3x3(double[,] matrix)
    {
        double det = Determinant3x3(matrix);

        if (Math.Abs(det) < 0.0001)
        {
            return null;
        }

        double[,] inverse = new double[3, 3];

        inverse[0, 0] = (matrix[1, 1] * matrix[2, 2] - matrix[1, 2] * matrix[2, 1]) / det;
        inverse[0, 1] = (matrix[0, 2] * matrix[2, 1] - matrix[0, 1] * matrix[2, 2]) / det;
        inverse[0, 2] = (matrix[0, 1] * matrix[1, 2] - matrix[0, 2] * matrix[1, 1]) / det;

        inverse[1, 0] = (matrix[1, 2] * matrix[2, 0] - matrix[1, 0] * matrix[2, 2]) / det;
        inverse[1, 1] = (matrix[0, 0] * matrix[2, 2] - matrix[0, 2] * matrix[2, 0]) / det;
        inverse[1, 2] = (matrix[0, 2] * matrix[1, 0] - matrix[0, 0] * matrix[1, 2]) / det;

        inverse[2, 0] = (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]) / det;
        inverse[2, 1] = (matrix[0, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1]) / det;
        inverse[2, 2] = (matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0]) / det;

        return inverse;
    }

    public static void DisplayMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j]:F2}\t");
            }
            Console.WriteLine();
        }
    }
}