using System;
using System.Collections.Generic;

class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name);
    }
}

class Student : Person
{
    public string StudentId;

    public Student(string name, string studentId) : base(name)
    {
        StudentId = studentId;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Student Name: " + Name + ", ID: " + StudentId);
    }
}

class Employee : Person
{
    public double Salary;

    public Employee(string name, double salary) : base(name)
    {
        Salary = salary;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Employee Name: " + Name + ", Salary: " + Salary);
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, double salary, string courseName) : base(name, salary)
    {
        CourseName = courseName;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine("Teacher Name: " + Name + ", Course: " + CourseName);
    }
}

class Program
{
    static void PrintPerson(Person p)
    {
        p.DisplayInfo();
    }

    static void Main()
    {
        List<Person> list = new List<Person>();
        list.Add(new Person("Ali"));
        list.Add(new Student("Salem", "101"));
        list.Add(new Employee("Omer", 4000));
        list.Add(new Teacher("Khaled", 6000, "math"));

        foreach (Person p in list)
        {
            Console.WriteLine(p.GetType().Name);
            p.DisplayInfo();
        }

        PrintPerson(list[0]);
    }
}