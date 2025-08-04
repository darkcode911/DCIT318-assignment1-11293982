using System;

namespace GradeCalculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grade Calculator ===");
            Console.WriteLine("Enter a numerical grade between 0 and 100:");
            
            string input = Console.ReadLine();
            int grade;

            if (!int.TryParse(input, out grade))
            {
                Console.WriteLine("Error: Please enter a valid number.");
                return;
            }

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Error: Grade must be between 0 and 100.");
                return;
            }

            // score to letter grade
            string letterGrade;
            if (grade >= 90)
            {
                letterGrade = "A";
            }
            else if (grade >= 80){
                letterGrade = "B";
            }
            else if (grade >= 70)
            {
                letterGrade = "C";
            }
            else if (grade >= 60)
            {
                letterGrade = "D";
            }
            else 
            {
                letterGrade = "F";
            }

            Console.WriteLine($"Numerical Grade: {grade}");
            Console.WriteLine($"Letter Grade: {letterGrade}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
