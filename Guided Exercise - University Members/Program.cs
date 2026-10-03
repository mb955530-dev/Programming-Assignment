using System;

class Person
{
    public string Name;
    public string Email;

    public Person(string name, string email)
    {
        Console.WriteLine("Person Created");
        Name = name;
        Email = email;
    }

    public void DisplayBasicInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Email);
    }
}

class Student : Person
{
    public string StudentId;
    public double GPA;

    public Student(string name, string email, string studentId, double gpa)
        : base(name, email)
    {
        Console.WriteLine("Student Created");
        StudentId = studentId;
        GPA = gpa;
    }
}

class Employee : Person
{
    public string EmployeeId;
    public double Salary;

    public Employee(string name, string email, string employeeId, double salary)
        : base(name, email)
    {
        Console.WriteLine("Employee Created");
        EmployeeId = employeeId;
        Salary = salary;
    }
}

class Teacher : Employee
{
    public string CourseName;

    public Teacher(string name, string email, string employeeId, double salary, string courseName)
        : base(name, email, employeeId, salary)
    {
        Console.WriteLine("Teacher Created");
        CourseName = courseName;
    }

    public void Teach()
    {
        Console.WriteLine("Teaching " + CourseName);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student("Ali", "ali@gmail.com", "101", 3.5);
        s.DisplayBasicInfo();

        Teacher t = new Teacher("Ahmed", "ahmed@gmail.com", "201", 5000, "Math");
        t.DisplayBasicInfo();
        t.Teach();
    }
}