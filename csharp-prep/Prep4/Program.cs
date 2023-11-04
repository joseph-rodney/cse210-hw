using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (number != 0);

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers entered.");
            return;
        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int largestNumber = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");

        // Stretch Challenge
        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        int smallestPositiveNumber = positiveNumbers.Count > 0 ? positiveNumbers.Min() : 0;

        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        List<int> sortedNumbers = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("The sorted list is:");
        foreach (int sortedNumber in sortedNumbers)
        {
            Console.WriteLine(sortedNumber);
        }

    }
}