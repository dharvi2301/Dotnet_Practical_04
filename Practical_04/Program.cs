using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_04
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Taking user input to initialize student
            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();
            Student student = new Student { Name = name };

            Console.WriteLine("Enter 5 marks: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Mark {i + 1}: ");
                student.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            // Display menu options
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1 - Aggregate: Displays the Name & Average Marks");
            Console.WriteLine("2 - MinMark: Displays the Minimum Marks");
            Console.WriteLine("3 - MaximumMark: Displays the Maximum Marks");
            Console.WriteLine("4 - Grade: Displays Grade");

            // Taking user input for menu choice
            Console.Write("Enter your choice: ");
            if (Enum.TryParse(Console.ReadLine(), out Options choice))
            {
                switch (choice)
                {
                    case Options.Aggregate:
                        Console.WriteLine($"{student.Name}: Average Marks = {student.CalculateAverageMarks()}");
                        break;
                    case Options.MinMark:
                        Console.WriteLine($"Minimum Marks: {student.Marks.Min()}");
                        break;
                    case Options.MaximumMark:
                        Console.WriteLine($"Minimum Marks: {student.Marks.Max()}");
                        break;
                    case Options.Grade:
                        Console.WriteLine($"Grade: {student.CalculateGrade(student.CalculateAverageMarks())}");
                        break;
                    default:
                        Console.WriteLine("Wrong option chosen!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.ReadLine();
        
    }
    }
}
