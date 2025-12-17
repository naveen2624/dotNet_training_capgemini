using System;

namespace Level2LabPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Programming Elements Level 2 Lab Practice\n");

            Console.WriteLine("1. Quotient and Remainder\n");
            QuotientRemainder();

            Console.WriteLine("\n2. Int Operations\n");
            IntOperations();

            Console.WriteLine("\n3. Double Operations\n");
            DoubleOperations();

            Console.WriteLine("\n4. Celsius to Fahrenheit\n");
            CelsiusToFahrenheit();

            Console.WriteLine("\n5. Fahrenheit to Celsius\n");
            FahrenheitToCelsius();

            Console.WriteLine("\n6. Total Income\n");
            TotalIncome();

            Console.WriteLine("\n7. Swap Two Numbers\n");
            SwapNumbers();

            Console.WriteLine("\n8. Travel Details Program\n");
            TravelDetails();

            Console.WriteLine("\n9. Athlete Running Rounds\n");
            AthleteRounds();

            Console.WriteLine("\n10. Chocolates Distribution\n");
            ChocolateDistribution();

            Console.WriteLine("\n11. Simple Interest\n");
            SimpleInterest();

            Console.WriteLine("\n12. Pounds to Kilograms\n");
            PoundsToKilograms();
        }

        // 1
        public static void QuotientRemainder()
        {
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int quotient = num1 / num2;
            int remainder = num1 % num2;

            Console.WriteLine("The Quotient is {0} and Remainder is {1} of two numbers {2} and {3}",
                quotient, remainder, num1, num2);
        }

        // 2
        public static void IntOperations()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result1 = a + b * c;
            int result2 = a * b + c;
            int result3 = c + a / b;
            int result4 = a % b + c;

            Console.WriteLine("The results of Int Operations are {0}, {1}, {2}, {3}",
                result1, result2, result3, result4);
        }

        // 3
        public static void DoubleOperations()
        {
            Console.Write("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double result1 = a + b * c;
            double result2 = a * b + c;
            double result3 = c + a / b;
            double result4 = a % b + c;

            Console.WriteLine("The results of Double Operations are {0}, {1}, {2}, {3}",
                result1, result2, result3, result4);
        }

        // 4
        public static void CelsiusToFahrenheit()
        {
            Console.Write("Enter temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("The {0} Celsius is {1} Fahrenheit", celsius, fahrenheit);
        }

        // 5
        public static void FahrenheitToCelsius()
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The {0} Fahrenheit is {1} Celsius", fahrenheit, celsius);
        }

        // 6
        public static void TotalIncome()
        {
            Console.Write("Enter salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter bonus: ");
            double bonus = Convert.ToDouble(Console.ReadLine());

            double income = salary + bonus;

            Console.WriteLine("The salary is INR {0} and bonus is INR {1}. Hence Total Income is INR {2}",
                salary, bonus, income);
        }

        // 7
        public static void SwapNumbers()
        {
            Console.Write("Enter number 1: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number 2: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int temp = number1;
            number1 = number2;
            number2 = temp;

            Console.WriteLine("The swapped numbers are {0} and {1}", number1, number2);
        }

        // 8
        public static void TravelDetails()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("From City: ");
            string fromCity = Console.ReadLine();

            Console.Write("Via City: ");
            string viaCity = Console.ReadLine();

            Console.Write("To City: ");
            string toCity = Console.ReadLine();

            Console.Write("Distance From-To-Via (miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Distance Via-To-Final (miles): ");
            double viaToFinal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Time Taken (hours): ");
            double time = Convert.ToDouble(Console.ReadLine());

            double totalDistance = fromToVia + viaToFinal;
            double speed = totalDistance / time;

            Console.WriteLine("The results of the trip are Distance: {0} miles, Time: {1} hours, Speed: {2} mph",
                totalDistance, time, speed);
        }

        // 9
        public static void AthleteRounds()
        {
            Console.Write("Enter side 1 (meters): ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2 (meters): ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3 (meters): ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            double perimeter = s1 + s2 + s3;
            double rounds = 5000 / perimeter;

            Console.WriteLine("The total number of rounds the athlete will run is {0} to complete 5 km", rounds);
        }

        // 10
        public static void ChocolateDistribution()
        {
            Console.Write("Enter number of chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());

            int each = chocolates / children;
            int remaining = chocolates % children;

            Console.WriteLine("The number of chocolates each child gets is {0} and the number of remaining chocolates is {1}",
                each, remaining);
        }

        // 11
        public static void SimpleInterest()
        {
            Console.Write("Enter principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double si = (principal * rate * time) / 100;

            Console.WriteLine("The Simple Interest is {0} for Principal {1}, Rate of Interest {2} and Time {3}",
                si, principal, rate, time);
        }

        // 12
        public static void PoundsToKilograms()
        {
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kg = pounds / 2.2;

            Console.WriteLine("The weight of the person in pounds is {0} and in kg is {1}", pounds, kg);
        }
    }
}
