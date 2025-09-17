using System.Runtime.InteropServices;

namespace datastructure_bank
{
    public class Student
    {

        public string Name { get; set; }
        public int RollNumber { get; set; }
        public double GPA { get; set; }
        public int Age { get; set; }

        // Constructor
        public Student(string name, int rollNumber, double gpa, int age)
        {
            Name = name;
            RollNumber = rollNumber;
            GPA = gpa;
            Age = age;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


            //LIST

            /*
            List<Student> student_list = new List<Student>();

            
            Student student1 = new Student("Ram", 1, 3.0,18);
            Student student2 = new Student("Shyam", 2, 3.5,21);
            Student student3 = new Student("Ghanshyam", 3, 4.0,20);

         
            student_list.Add(student1);
            student_list.Add(student2);
            student_list.Add(student3);

          
            Console.WriteLine("Student Details:");

            

            
            Console.WriteLine("\tName\t\tRoll Number\tGPA\tAge");
            Console.WriteLine("-----------------------------------------------------");

            
            foreach (Student student in student_list)
            {
                Console.WriteLine($"\t{student.Name}\t\t{student.RollNumber}\t\t{student.GPA}\t\t{student.Age}");
            }
            */

            /*
            //foreach (Student student in student_list)
            //
            //    //Console.WriteLine($"\nName: {student.Name}, \nRoll Number: {student.RollNumber}, \nGPA: {student.GPA},\nAge: {student.Age}");
            //    Console.WriteLine($"Name: {student.Name}");
            //    Console.WriteLine($"Roll Number :{student.RollNumber}");
            //    Console.WriteLine($"GPA :{student.GPA}");
            //    Console.WriteLine($"AGE :{student.Age}");

            //
            */



            //DICTIONARY
            Dictionary<int, Student> student_dict = new Dictionary<int, Student>();

            Student student1 = new Student("Ram", 1, 3.0, 18);
            Student student2 = new Student("Shyam", 2, 3.5, 21);
            Student student3 = new Student("Ghanshyam", 3, 4.0, 20);

            student_dict.Add(student1.RollNumber, student1);
            student_dict.Add(student2.RollNumber, student2);
            student_dict.Add(student3.RollNumber, student3);

            Console.WriteLine("Student Details:");
            Console.WriteLine("\tName\t\tRoll Number\tGPA\tAge");
            Console.WriteLine("-----------------------------------------------------");

            foreach (var studentEntry in student_dict)
            {
                Student student = studentEntry.Value;
                Console.WriteLine($"\t{student.Name}\t\t{student.RollNumber}\t\t{student.GPA}\t\t{student.Age}");




            }
        }
    }
}

//studen class list
//3 student object in a list
//Create a Console application to store 3 Student Objects in a list called 'student_list'
//and display them. You need to use Constructors to initialize Student objects

//list of dictionaries