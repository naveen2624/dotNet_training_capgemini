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
                case 1:EmployeeBonus();
                    break;
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
}