using System.Runtime.InteropServices;
namespace datastructure_demo
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int marks { get; set; }

        public Student(int id, string name, int marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.id}, Name: {s.name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].name}");
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine(student.Value.id);
            }


            //Hashset Example
            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student student in students_hashset)
            {
                Console.WriteLine(student.id);
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.name);


            //Queue demo
            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().name);


            //linked list demo
            Console.WriteLine("\nLinked List Demo\n");
            LinkedList<Student> Student_list = new LinkedList<Student>();

            // Push
            Student_list.AddFirst(first);
            Student_list.AddFirst(second);
            Student_list.AddFirst(third);

            // Pop
            Student pop_from_list = Student_list.First.Value;
            Student_list.RemoveFirst();

            Console.WriteLine($"Popped from List: {pop_from_list.name}");


            //TUPLE DEMO
            Console.WriteLine("\nTuple demo\n");
            
            Tuple<int, string, int> student_tuple = new Tuple<int, string, int>(1, "Alice", 10);

            Console.WriteLine($"iD: {student_tuple.Item1}");
            Console.WriteLine($"name: {student_tuple.Item2}");
            Console.WriteLine($"marks: {student_tuple.Item3}");            

        }
    }
}

        

