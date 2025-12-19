using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\nArrays Level 2");
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("1. Employee Salary and Bonus");


            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Exiting..."); break;
                case 1:EmployeeBonus();break;
                case 2: YoungestAndTallest(); break;
                case 3: LargestNumber(); break;
                case 4: YoungestTallestRework(); break;
                case 5: ReverseANumber(); break;

                default:Console.WriteLine("Invalid choice. Please try again.");break;
            }
        }
    }
    public static void EmployeeBonus()
    {
        double[] salaries = new double[10];
        double[] years = new double[10];
        double[] bonuses = new double[10];
        double[] newSalaries = new double[10];
        double totalOldSalary = 0;
        double totalNewSalary = 0;
        double totalBonus = 0;
        Console.WriteLine("Enter salaries and years of service for 10 employees:");

        for (int i = 0; i < 10; i++)
        {
            while (salaries[i] <= 0 || years[i] <= 0)
            {
                Console.Write("Enter salary for employee " + (i + 1) + ": ");
                salaries[i] = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter years of service for employee " + (i + 1) + ": ");
                years[i] = Convert.ToDouble(Console.ReadLine());
                if (salaries[i] <= 0 || years[i] <= 0)
                {
                    Console.WriteLine("Salary and years of service must be positive numbers. Please re-enter.");
                }
            }
        }
        Console.WriteLine("Calculating bonuses and new salaries...");
        for (int i=0; i < 10; i++)
        {
            if (years[i] >5)
            {
                bonuses[i] = salaries[i] * 5 / 100;
                
            }
            else
            {
                bonuses[i] = salaries[i] * 2 / 100;
            }
            newSalaries[i] = salaries[i] + bonuses[i];
            totalOldSalary += salaries[i];
            totalNewSalary += newSalaries[i];
            totalBonus += bonuses[i];
            Console.WriteLine("Employee " + (i + 1) + ": Old Salary: " + salaries[i] + ", Bonus: " + bonuses[i] + ", New Salary: " + newSalaries[i]);
        }
        Console.WriteLine("Total Old Salary: " + totalOldSalary);
        Console.WriteLine("Total Bonus: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNewSalary);
    }
    public static void YoungestAndTallest()
    {
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        double[] heights = new double[3];

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter age of {names[i]}: ");
            ages[i] = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter height of {names[i]} (in cm): ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        int youngestIndex = 0;
        int tallestIndex = 0;

        for (int i = 1; i < 3; i++)
        {
            if (ages[i] < ages[youngestIndex])
            {
                youngestIndex = i;
            }

            if (heights[i] > heights[tallestIndex])
            {
                tallestIndex = i;
            }
        }

        Console.WriteLine($"\nYoungest Friend: {names[youngestIndex]} (Age: {ages[youngestIndex]})");
        Console.WriteLine($"Tallest Friend: {names[tallestIndex]} (Height: {heights[tallestIndex]} cm)");

    }
    public static void LargestNumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;
        while (number != 0 && index < maxDigit)
        {
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
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

        Console.WriteLine($"\nLargest Digit: {largest}");
        Console.WriteLine($"Second Largest Digit: {secondLargest}");
    }
    public static void YoungestTallestRework()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        while (number != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];

                for (int i = 0; i < digits.Length; i++)
                {
                    temp[i] = digits[i];
                }

                digits = temp;
            }

            digits[index] = number % 10;
            number = number / 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        for (int i = 0; i < index; i++)
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

        Console.WriteLine("\nLargest Digit: " + largest);
        Console.WriteLine("Second Largest Digit: " + secondLargest);
    }
    public static void ReverseANumber()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number;
        int count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        int[] reverseDigits = new int[count];

        temp = number;
        for (int i = 0; i < count; i++)
        {
            digits[i] = temp % 10;
            temp /= 10;
        }

        for (int i = 0; i < count; i++)
        {
            reverseDigits[i] = digits[count - 1 - i];
        }

        Console.Write("\nReversed Number: ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(reverseDigits[i]);
        }

    }
    public static void BMI()
    {
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[] height = new double[number];
        double[] weight = new double[number];
        double[] bmi = new double[number];
        string[] status = new string[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}");

            Console.Write("Enter height in meters: ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter weight in kg: ");
            weight[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < number; i++)
        {
            bmi[i] = weight[i] / (height[i] * height[i]);

            if (bmi[i] < 18.5)
                status[i] = "Underweight";
            else if (bmi[i] < 25)
                status[i] = "Normal";
            else if (bmi[i] < 30)
                status[i] = "Overweight";
            else
                status[i] = "Obese";
        }

        Console.WriteLine("\nHeight\tWeight\tBMI\tStatus");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"{height[i]}\t{weight[i]}\t{bmi[i]:F2}\t{status[i]}");
        }
    }
    public static void BMIRework()
    {
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];

        for (int i = 0; i < number; i++)
        {
            personData[i] = new double[3];
        }

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"\nPerson {i + 1}");

            do
            {
                Console.Write("Enter weight in kg: ");
                personData[i][0] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][0] <= 0);

            do
            {
                Console.Write("Enter height in meters: ");
                personData[i][1] = Convert.ToDouble(Console.ReadLine());
            } while (personData[i][1] <= 0);
        }

        for (int i = 0; i < number; i++)
        {
            double weight = personData[i][0];
            double height = personData[i][1];

            personData[i][2] = weight / (height * height);

            if (personData[i][2] < 18.5)
                weightStatus[i] = "Underweight";
            else if (personData[i][2] < 25)
                weightStatus[i] = "Normal";
            else if (personData[i][2] < 30)
                weightStatus[i] = "Overweight";
            else
                weightStatus[i] = "Obese";
        }

        Console.WriteLine("\nWeight\tHeight\tBMI\tStatus");
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(
                $"{personData[i][0]}\t{personData[i][1]}\t{personData[i][2]:F2}\t{weightStatus[i]}"
            );
        }
    }
}