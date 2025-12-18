using System;
class Program {
    static void Main() {
        int choice = 1;
        while (choice != 0)
        {
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("1. Age of Students");
            Console.WriteLine("2. Positive, Negative or Zero");
            Console.WriteLine("3. Multiplication Table");
            Console.WriteLine("4. Sum of Numbers");
            Console.WriteLine("5. Multiplication Table from 6 to 9");
            Console.WriteLine("6. Football Players Height");
            Console.WriteLine("7. Odd and Even Numbers");
            Console.WriteLine("8. Factors of a Number");
            Console.WriteLine("9. 2D Array to 1D Array");
            Console.WriteLine("10. FizzBuzz");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter the Program to execute: ");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0: Console.WriteLine("Thank You");break;
                case 1: StudentVote(); break;
                case 2: PositiveNegative(); break;
                case 3: MultiplicationTable(); break;
                case 4: SumOfNumbers(); break;
                case 5: Multiplication6To9(); break;
                case 6: FootballPlayersHeight(); break;
                case 7: OddorEven(); break;
                case 8: Factors(); break;
                case 9: Array2D(); break;
                case 10: FizzBuzz(); break;

            }
          
        }
    }
    public static void StudentVote()
    {
        Console.WriteLine("\nEnter Age of 10 Students:");
        int[] studentAge = new int[10];
        for (int i=0;i<10; i++)
        {
            Console.Write($"Enter age of Student{i}: ");
            studentAge[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < 10; i++)
        {
            if (studentAge[i] >= 18)
            {
                Console.WriteLine($"Student{i} can Vote");
            }
            else
            {
                Console.WriteLine($"Student{i} cannot Vote");
            }
        }
    }
    public static void PositiveNegative()
    {
        Console.WriteLine("Enter 5 Numbers: ");
        int[] numbers = new int[5];
        for (int i = 0; i <= numbers.Length-1; i++)
        {
            Console.Write($"Enter Number{i}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i <= numbers.Length-1; i++)
        {
            if (numbers[i] < 0)
            {
                Console.WriteLine($"Number{i}: {numbers[i]} is a Negative Integer\n");
            }
            else if (numbers[i] == 0)
            {
                Console.WriteLine($"Number{i}: {numbers[i]} is a Zero\n");
            }
            else if (numbers[i] > 0)
            {
                Console.WriteLine($"Number{i}: {numbers[i]} is a Positive Integer\n");
            }
        }
        if (numbers[0] == numbers[numbers.Length - 1])
        {
            Console.WriteLine("{0} and {1} are equal", numbers[0], numbers[numbers.Length - 1]);
        }
        else if (numbers[0] > numbers[numbers.Length - 1])
        {
            Console.WriteLine("{0} is greater than {1}", numbers[0], numbers[numbers.Length - 1]);
        }
        else
        {
            Console.WriteLine("{0} is less than {1}", numbers[0], numbers[numbers.Length - 1]);
        }
    }
    public static void MultiplicationTable()
    {
        Console.Write("Enter a number to display its multiplication table: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int [] multiplication=new int[10];
        for (int i = 1; i <= 10; i++)
        {
            multiplication[i-1]=num*i;
        }
        for (int i = 0; i < multiplication.Length; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", num, i + 1, multiplication[i]);
        }
    }
    public static void SumOfNumbers()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        Console.WriteLine("Enter numbers (0 or negative number to stop):");

        while (true)
        {
            Console.Write($"Enter number {index + 1}: ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0)
            {
                break;
            }

            if (index == 10)
            {
                break;
            }

            numbers[index] = input;
            index++;
        }

        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }
        Console.WriteLine($"\nSum of all numbers: {total}");
    }
    public static void Multiplication6To9()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        Console.WriteLine("\nMultiplication Table:");
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{number} * {i} = {multiplicationResult[i - 6]}");
        }
    }
    public static void FootballPlayersHeight()
    {
        Console.WriteLine("Enter the heights of 11 football players in cm:");
        double[] heights = new double[11];
        for (int i = 0; i < heights.Length; i++)
        {
            Console.Write($"Player {i + 1} height: ");
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }
        double totalHeight = heights.Sum();
        double meanHeight = totalHeight / heights.Length;
        Console.WriteLine($"\nMean Height of Football Players: {meanHeight} cm");

    }
    public static void OddorEven()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Error: Please enter a natural number.");
            return;
        }

        int size = number / 2 + 1;
        int[] oddNumbers = new int[size];
        int[] evenNumbers = new int[size];

        int oddIndex = 0;
        int evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
    public static void Factors()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == maxFactor)
                {
                    maxFactor = maxFactor * 2;
                    int[] temp = new int[maxFactor];

                    for (int j = 0; j < factors.Length; j++)
                    {
                        temp[j] = factors[j];
                    }

                    factors = temp;
                }

                factors[index] = i;
                index++;
            }
        }

        Console.WriteLine("\nFactors of " + number + ":");
        for (int i = 0; i < index; i++)
        {
            Console.Write(factors[i] + " ");
        }
    }
    public static void Array2D()
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        if (rows <= 0 || columns <= 0)
        {
            Console.WriteLine("Rows and columns must be positive integers.");
            return;
        }

        int[,] matrix = new int[rows, columns];

        Console.WriteLine("\nEnter matrix elements:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int[] array = new int[rows * columns];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                array[index] = matrix[i, j];
                index++;
            }
        }

        Console.WriteLine("\n2D Array (Matrix):");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n1D Array:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
    public static void FizzBuzz()
    {
        Console.Write("Enter a positive integer: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number <= 0)
        {
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        string[] results = new string[number + 1];

        for (int i = 0; i <= number; i++)
        {
            if (i == 0)
            {
                results[i] = "0";
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0)
            {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0)
            {
                results[i] = "Buzz";
            }
            else
            {
                results[i] = i.ToString();
            }
        }

        Console.WriteLine("\nFizzBuzz Results:");
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine($"Position {i} = {results[i]}");
        }
    }
}