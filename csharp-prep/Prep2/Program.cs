using System;

class Program
{
    static void Main(string[] args)
    {
        // Asks the user for their grade percentage and tells them thier letter grade.
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? Please use whole numbers from 0 to 100 only: ");
        int grade_number = int.Parse(Console.ReadLine());

        if (grade_number >= 90 && grade_number <= 100)
        {
            if (grade_number > 94) {
            Console.WriteLine("Your letter grade is A.");
            }
            else {
                Console.WriteLine("Your letter grade is A-.");
            }
        }

        else if (grade_number >= 80 && grade_number < 90)
        {
            if (grade_number > 86) {
                Console.WriteLine("Your letter grade is B+.");
            }
            else if (grade_number > 83) {
                Console.WriteLine("Your letter grade is B.");
            }
            else {
                Console.WriteLine("Your letter grade is B-.");
            }
        }

        else if (grade_number >= 70 && grade_number < 80)
        {
            if (grade_number > 76) {
                Console.WriteLine("Your letter grade is C+.");
            }
            else if (grade_number > 73) {
                Console.WriteLine("Your letter grade is C.");
            }
            else {
                Console.WriteLine("Your letter grade is C-.");
            }
        }

        else if (grade_number >= 60 && grade_number < 70)
        {
            if (grade_number > 66) {
                Console.WriteLine("Your letter grade is D+.");
            }
            else if (grade_number > 63) {
                Console.WriteLine("Your letter grade is D.");
            }
            else {
                Console.WriteLine("Your letter grade is D-.");
            }
        }

        else if (grade_number < 60 && grade_number > 0)
        {
            Console.WriteLine("Your letter grade is F.");
        }
        else
        {
            Console.WriteLine("You have entered an incorrect value.");
        }
    }
}