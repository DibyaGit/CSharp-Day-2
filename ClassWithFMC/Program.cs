using System;

class Student
{
    // Fields
    public string Name;
    public int Id;

    // Constructor
    public Student(string name, int id)
    {
        Name = name;
        Id = id;
    }

    // Method to display info
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + Name + ", Id: " + Id);
    }

    // Method to update name
    public void UpdateName(string newName)
    {
        Name = newName;
    }

    // Method to update Id
    public void UpdateId(int newId)
    {
        Id = newId;
    }
}

class Program
{
    static void Main()
    {
        Student s1 = new Student("Alice", 101);
        Student s2 = new Student("Bob", 102);

        s1.DisplayInfo();
        s2.DisplayInfo();

        // Updating values
        s1.UpdateName("Alicia");
        s1.UpdateId(201);

        s2.UpdateName("Bobby");
        s2.UpdateId(202);

        Console.WriteLine("\nAfter Update:");
        s1.DisplayInfo();
        s2.DisplayInfo();
    }
}