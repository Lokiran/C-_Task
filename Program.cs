using System;
using System.Collections.Generic;

public class Student
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public int Marks { get; set; }

    public string GetGrade()
    {
        if (Marks >= 90)
            return "A";
        else if (Marks >= 75)
            return "B";
        else if (Marks >= 50)
            return "C";
        else
            return "Fail";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter multiple students? (Y/N): ");
        string? input = Console.ReadLine();

        if (input?.ToUpper() == "Y")
            MultipleStudents();
        else
            SingleStudent();
    }

    static void SingleStudent() =>
        PrintStudent(ReadStudent());

    static void MultipleStudents()
    {
        List<Student> students = new();

        while (true)
        {
            students.Add(ReadStudent());

            Console.Write("Add another? (Y/N): ");
            if (Console.ReadLine()?.ToUpper() != "Y")
                break;
        }

        Console.WriteLine("\n--- Results ---");
        foreach (var s in students)
            PrintStudent(s);
    }

    static Student ReadStudent()
    {
        Student s = new Student();

        Console.Write("Name: ");
        s.Name = Console.ReadLine() ?? "";

        Console.Write("Age: ");
        s.Age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Marks: ");
        s.Marks = Convert.ToInt32(Console.ReadLine());

        return s;
    }

    static void PrintStudent(Student s)
    {
        Console.WriteLine($"\nName: {s.Name}");
        Console.WriteLine($"Age: {s.Age}");
        Console.WriteLine($"Marks: {s.Marks}");
        Console.WriteLine($"Grade: {s.GetGrade()}");
    }
}