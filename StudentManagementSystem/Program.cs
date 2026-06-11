using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagementSystem
{
   
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

       
    }

    
    public class Program
    {
        public static Student AddStudent(List<Student> students)
        {
            string id;
            while (true)
            {
                Console.Write("Enter Student Id : ");
                id =  Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Id cannot be empty");
                }
                else if (GetStudent(id, students) != null)
                {
                    Console.WriteLine("Error: A Student with this Id already exists");
                }
                else
                {
                    break;
                }
            }
                Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();
           
            int age;
            while (true)
            {
                Console.Write("Enter Student Age : ");
                if(int.TryParse(Console.ReadLine(),out age) && age>0)
                {
                    break ;
                }
                Console.WriteLine("Invalid input. Please enter a valid age");

            }
            
            
            return new Student(id,name,age);
        }
        public static void ViewStudent(List<Student> students)
        {
            if(students.Count == 0)
            {
                Console.WriteLine("No Students Available");
                return;
            }
            foreach(Student student in students) {
                Console.WriteLine("Student Id : "+student.Id);
                Console.WriteLine("Student Name : " + student.Name);
                Console.WriteLine("Student Age : " + student.Age);
                Console.WriteLine();
            }
        }

        public static Student GetStudent(string id, List<Student> students)
        {
            foreach(Student student in students)
            {
                if(student.Id == id)return student;
            }
            return null;
        }
        public static void UpdateStudent(List<Student> students)
        {
            string id;
            while (true)
            {
                Console.Write("Enter Student Id : ");
                id = Console.ReadLine()?.Trim();
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("Id cannot be empty");
                }
                else if (GetStudent(id, students) == null)
                {
                    Console.WriteLine("Error: A Student with this Id doesn't exists");
                }
                else
                {
                    break;
                }
            }
            Console.Write("Enter Student Name : ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter Student Age : ");
                if (int.TryParse(Console.ReadLine(), out age) && age > 0)
                {
                    break;
                }
                Console.WriteLine("Invalid input. Please enter a valid age");

            }
            Student s = GetStudent(id, students);
            s.Name = name;
            s.Age = age;

            return; 
        }
        public static bool DelStudent(string id, List<Student> students)
        {
            Student s = GetStudent(id, students);
            if (s != null) { students.Remove(s); return true; }
           
                return false;
        }
        public static int StudentCount(List<Student> students)
        {
            return students.Count;
        }
        public static void Main(string[] args)
        {
            // Senior Clue: Your master data storage list goes here!
            List<Student> students = new List<Student>();
            
           

            while (true)
            {
                Console.WriteLine("\n==================================");
                Console.WriteLine("    STUDENT MANAGEMENT SYSTEM    ");
                Console.WriteLine("==================================");
                Console.WriteLine("1. Add Student");

                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Update");
                Console.WriteLine("6. Total Students");
                Console.WriteLine("7. Search by Name");
                Console.WriteLine("8. Exit");
                Console.Write("\nSelect an option (1-8): ");
                Console.WriteLine();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        students.Add(AddStudent(students));
                        break;

                    case "2":
                        ViewStudent(students);
                        break;
                    case "3":
                        Console.Write("Enter Student Id you want to search : ");
                        string id = Console.ReadLine();
                        Student s = GetStudent(id, students);
                        if(s == null)
                        {
                            Console.WriteLine("No student found!");
                        }
                        else
                        {
                            Console.WriteLine($"Student Found!");
                            Console.WriteLine($"Id : {s.Id}");
                            Console.WriteLine($"Name : {s.Name}");
                            Console.WriteLine($"Age : {s.Age}");
                        }
                            break;
                    case "4":
                        Console.Write("Enter Student Id you want to delete : ");
                        string sId = Console.ReadLine();
                        if(string.IsNullOrWhiteSpace(sId))
                        {
                            Console.WriteLine("Student Id cannot be empty");
                            break;
                        }
                        bool isDel = DelStudent(sId, students);
                        if (isDel)
                        {
                            Console.WriteLine("Student deleted successfully");
                        }
                        else
                        {
                            Console.WriteLine("No Student found with the given Id");
                        }
                            break;

                    case "5":
                        UpdateStudent(students);
                        break;
                    case "6":
                        int count = StudentCount(students);
                        Console.WriteLine($"Total Students : {count}");
                        break;
                    case "7":
                        Console.Write("Enter Student Name you want to search : ");
                        string name = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(name))
                        {
                            Console.WriteLine("Student name cannot be empty");
                        }
                        var foundStudents = students.Where(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).ToList();
                        if (!foundStudents.Any())
                        {
                            Console.WriteLine("No student found with that name!");
                        }
                        else
                        {
                            Console.WriteLine($"Found {foundStudents.Count} student(s) with the name '{name}':");
                            foreach (var student in foundStudents)
                            {
                                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("Exiting program. Goodbye!");
                        return; // Stops the execution loop cleanly

                    default:
                        Console.WriteLine("Invalid option. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
