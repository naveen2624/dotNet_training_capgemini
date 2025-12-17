using System;

namespace Level1LabPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Programming Elements Level 1 Lab Practice\n");

            Console.WriteLine("1. Age of Harry\n");
            AgeCalculator(2000);

            Console.WriteLine("\n2. Average Percent Mark in PCM\n");
            AveragePercentMark(94, 95, 96);

            Console.WriteLine("\n3. KM to Miles\n");
            KmToMiles(10.8);

            Console.WriteLine("\n4. Profit and Loss\n");
            ProfitAndLoss(129, 191);

            Console.WriteLine("\n5. Split Pens\n");
            SplitPens(14, 3);

            Console.WriteLine("\n6. Course Fee Discount (Fixed Values)\n");
            CourseFeeDiscount();

            Console.WriteLine("\n7. Volume of Earth\n");
            VolumeOfEarth();

            Console.WriteLine("\n8. KM to Miles with user input\n");
            KmToMilesUserInput();

            Console.WriteLine("\n9. Course Fee Discount with user input\n");
            CourseFeeDiscountUserInput();

            Console.WriteLine("\n10. Height Conversion\n");
            HeightConversion();

            Console.WriteLine("\n11. Basic Calculator\n");
            BasicCalculator();

            Console.WriteLine("\n12. Area of Triangle\n");
            TriangleArea();

            Console.WriteLine("\n13. Side of Square\n");
            SquareSide();

            Console.WriteLine("\n14. Feet to Yards and Miles\n");
            FeetToYardsMiles();

            Console.WriteLine("\n15. Total Purchase Price\n");
            TotalPurchasePrice();

            Console.WriteLine("\n16. Maximum Handshakes\n");
            Handshakes();
        }

        // 1
        public static void AgeCalculator(int birthYear)
        {
            int currentYear = 2024;
            int age = currentYear - birthYear;
            Console.WriteLine("Harry's age in 2024 is {0}", age);
        }

        // 2
        public static void AveragePercentMark(double math, double physics, double chemistry)
        {
            double average = (math + physics + chemistry) / 3;
            Console.WriteLine("Sam’s average mark in PCM is {0}%", average);
        }

        // 3
        public static void KmToMiles(double km)
        {
            double miles = km / 1.6;
            Console.WriteLine("The distance {0} km in miles is {1}", km, miles);
        }

        // 4
        public static void ProfitAndLoss(int costPrice, int sellingPrice)
        {
            int profit = sellingPrice - costPrice;
            double profitPercentage = (double)profit / costPrice * 100;

            Console.WriteLine("The Cost Price is INR {0} and Selling Price is INR {1}", costPrice, sellingPrice);
            Console.WriteLine("The Profit is INR {0} and the Profit Percentage is {1}%", profit, profitPercentage);
        }

        // 5
        public static void SplitPens(int pens, int students)
        {
            int perStudent = pens / students;
            int remaining = pens % students;
            Console.WriteLine("The Pen Per Student is {0} and the remaining pen not distributed is {1}", perStudent, remaining);
        }

        // 6
        public static void CourseFeeDiscount()
        {
            double fee = 125000;
            double discountPercent = 10;
            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR {0} and final discounted fee is INR {1}", discount, finalFee);
        }

        // 7
        public static void VolumeOfEarth()
        {
            double radiusKm = 6378;
            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
            double volumeMiles = volumeKm * Math.Pow(0.621371, 3);

            Console.WriteLine("The volume of earth in cubic kilometers is {0}", volumeKm);
            Console.WriteLine("The volume of earth in cubic miles is {0}", volumeMiles);
        }

        // 8
        public static void KmToMilesUserInput()
        {
            Console.Write("Enter distance in km: ");
            double km = Convert.ToDouble(Console.ReadLine());
            double miles = km / 1.6;

            Console.WriteLine("The total miles is {0} mile for the given {1} km", miles, km);
        }

        // 9
        public static void CourseFeeDiscountUserInput()
        {
            Console.Write("Enter fee amount: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter discount percentage: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());

            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR {0} and final discounted fee is INR {1}", discount, finalFee);
        }

        // 10
        public static void HeightConversion()
        {
            Console.Write("Enter height in cm: ");
            double cm = Convert.ToDouble(Console.ReadLine());

            double inches = cm / 2.54;
            int feet = (int)(inches / 12);
            double remainingInches = inches % 12;

            Console.WriteLine("Your Height in cm is {0} while in feet is {1} and inches is {2}", cm, feet, remainingInches);
        }

        // 11
        public static void BasicCalculator()
        {
            Console.Write("Enter number 1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition: {0}", n1 + n2);
            Console.WriteLine("Subtraction: {0}", n1 - n2);
            Console.WriteLine("Multiplication: {0}", n1 * n2);
            Console.WriteLine("Division: {0}", n1 / n2);
        }

        // 12
        public static void TriangleArea()
        {
            Console.Write("Enter base: ");
            double baseVal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseVal * height;
            Console.WriteLine("Area of triangle is {0}", area);
        }

        // 13
        public static void SquareSide()
        {
            Console.Write("Enter perimeter: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            double side = perimeter / 4;
            Console.WriteLine("The length of the side is {0} whose perimeter is {1}", side, perimeter);
        }

        // 14
        public static void FeetToYardsMiles()
        {
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double yards = feet / 3;
            double miles = yards / 1760;

            Console.WriteLine("Distance in yards is {0} and in miles is {1}", yards, miles);
        }

        // 15
        public static void TotalPurchasePrice()
        {
            Console.Write("Enter unit price: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double total = unitPrice * quantity;
            Console.WriteLine("The total purchase price is INR {0} if the quantity {1} and unit price is INR {2}",
                total, quantity, unitPrice);
        }

        // 16
        public static void Handshakes()
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int handshakes = (n * (n - 1)) / 2;
            Console.WriteLine("The maximum number of handshakes is {0}", handshakes);
        }
    }
}
