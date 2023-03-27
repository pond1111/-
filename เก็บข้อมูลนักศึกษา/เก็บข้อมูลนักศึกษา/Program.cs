using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        string input = "";

        while (input != "end")
        {
            Console.WriteLine("\nEnter student information (or 'end' to stop):");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            if (name == "end")
            {
                break;
            }

            Console.Write("ID: ");
            string id = Console.ReadLine();

            Console.Write("Year of Birth: ");
            int yearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Height (cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Grade: ");
            double grade = double.Parse(Console.ReadLine());

            Console.Write("Major: ");
            string major = Console.ReadLine();

            // Create new Student object and add to list
            Student student = new Student(name, id, yearOfBirth, height, grade, major);
            students.Add(student);
        }

        // Calculate summary statistics
        int numStudents = students.Count;
        double highestGrade = double.MinValue;
        double lowestGrade = double.MaxValue;
        foreach (Student student in students)
        {
            double grade = student.Grade;
            if (grade > highestGrade)
            {
                highestGrade = grade;
            }
            if (grade < lowestGrade)
            {
                lowestGrade = grade;
            }
        }

        // Print summary
        Console.WriteLine("\nSummary:");
        Console.WriteLine($"Highest grade: {highestGrade}");
        Console.WriteLine($"Lowest grade: {lowestGrade}");
        Console.WriteLine($"Number of students entered: {numStudents}");
    }
}

class Student
{
    public string Name;
    public string Id;
    public int YearOfBirth;
    public double Height;
    public double Grade;
    public string Major;

    public Student(string name, string id, int yearOfBirth, double height, double grade, string major)
    {
        Name = name;
        Id = id;
        YearOfBirth = yearOfBirth;
        Height = height;
        Grade = grade;
        Major = major;
    }
}