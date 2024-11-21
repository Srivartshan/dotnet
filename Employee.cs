using System;

public class Employee : Person
{
    public int EmployeeID { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }
    public string Position { get; set; }

    public Employee(string name, string dob, string email, string phoneNumber, int employeeID, double salary, string department, string position)
    {
        Name = name;
        DOB = dob;
        Email = email;
        PhoneNumber = phoneNumber;
        EmployeeID = employeeID;
        Salary = salary;
        Department = department;
        Position = position;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("/////////////////////////////////////////////////////////");
        Console.WriteLine("\nEmployee Details:");
        Console.WriteLine($"Name       : {Name}");
        Console.WriteLine($"DOB        : {DOB}");
        Console.WriteLine($"Email      : {Email}");
        Console.WriteLine($"Phone      : {PhoneNumber}");
        Console.WriteLine($"Employee ID: {EmployeeID}");
        Console.WriteLine($"Salary     : ${Salary:F2}");
        Console.WriteLine($"Department : {Department}");
        Console.WriteLine($"Position   : {Position}");
        Console.WriteLine("/////////////////////////////////////////////////////////");
    }
}
