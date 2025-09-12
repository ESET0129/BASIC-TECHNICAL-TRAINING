using System.Numerics;


namespace Student_grade_evaluator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int;
            int total = 0;
            bool allpassed = true;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine($"enter marks for subjects {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            total += marks[i];

            if (marks[i] < 40)
            {
                allpassed = false;
            }


            double average = total / 5.0;
            string grade;

            if (average >= 90)
                grade = "A";

            else if (average >= 70)
                grade = "B";
            else if (average >= 60)
                grade = "C";
            else if (average >= 50)
                grade = "D";
            else
                grade = "F";

            Console.WriteLine("\n student grade report ");
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Subject{i + 1}: {marks[i]}");
            }
            Console.WriteLine($"\naverage marks: {average}");
            Console.WriteLine($"\noverall grade: {grade}");

            if (allpassed) {
                Console.WriteLine("\n passed all subject");
            }
            else
            {
                Console.WriteLine("\n failed subjects:");
                for (int i = 0; i < 5; i++)
                {
                    if (marks[i] < 50)
                    {
                        Console.WriteLine("\n subject{i+1}:{marks[i]}");

                    }
                }
            }
        }
    }
}
     

