using System;

class Vehicle
{
    public string Brand;
    public int Year;

    public Vehicle(string brand, int year)
    {
        Brand = brand;
        Year = year;
    }

    public void Start()
    {
        Console.WriteLine(Brand + " (" + Year + ") is starting...");
    }
}

class Car : Vehicle
{
    public int NumberOfDoors;

    public Car(string brand, int year, int numberOfDoors)
        : base(brand, year)
    {
        NumberOfDoors = numberOfDoors;
    }
}

class Bus : Vehicle
{
    public int Capacity;

    public Bus(string brand, int year, int capacity)
        : base(brand, year)
    {
        Capacity = capacity;
    }
}

class Motorcycle : Vehicle
{
    public bool HasSidecar;

    public Motorcycle(string brand, int year, bool hasSidecar)
        : base(brand, year)
    {
        HasSidecar = hasSidecar;
    }
}

class Program
{
    static void Main()
    {
        // Objects Creation
        Car c = new Car("Toyota", 2022, 4);
        Bus b = new Bus("Volvo", 2020, 50);
        Motorcycle m = new Motorcycle("Honda", 2023, false);

        // Demonstrating Start()
        c.Start();
        b.Start();
        m.Start();
    }
}