using System;
using System.Text.RegularExpressions;

public static class Validation
{
    public static string ValidateUsername()
    {
        string username;
        do
        {
            Console.Write("\nEnter Username: ");
            username = Console.ReadLine();

            if (string.IsNullOrEmpty(username) || !Regex.IsMatch(username, @"^[A-Za-z0-9]{3,15}$"))
            {
                Console.WriteLine("Invalid username. Please enter a valid username.");
            }
        } while (string.IsNullOrEmpty(username) || !Regex.IsMatch(username, @"^[A-Za-z0-9]{3,15}$"));

        return username;
    }

    public static string ValidatePassword()
    {
        string password;
        do
        {
            Console.Write("\nEnter Password: ");
            password = Console.ReadLine();

            if (string.IsNullOrEmpty(password) || 
                !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,20}$"))
            {
                Console.WriteLine("Invalid password. Please enter a valid password.");
            }
        } while (string.IsNullOrEmpty(password) || 
                 !Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,20}$"));

        return password;
    }

    public static string ValidateName()
    {
        string name;
        do
        {
            Console.Write("\nEnter Employee Name: ");
            name = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(name) || !Regex.IsMatch(name, @"^[A-Za-z\s]+$"));

        return name;
    }

    public static string ValidateDOB()
    {
        string dob;
        do
        {
            Console.Write("Enter Date of Birth (DD/MM/YYYY): ");
            dob = Console.ReadLine();
        } while (!DateTime.TryParseExact(dob, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _));

        return dob;
    }

    public static string ValidateEmail()
    {
        string email;
        do
        {
            Console.Write("Enter Email: ");
            email = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(email) || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"));

        return email;
    }

    public static string ValidatePhoneNumber()
    {
        string phoneNumber;
        do
        {
            Console.Write("Enter Phone Number: ");
            phoneNumber = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(phoneNumber) || !Regex.IsMatch(phoneNumber, @"^\d{10}$"));

        return phoneNumber;
    }

    public static int ValidateEmployeeID()
    {
        int employeeID;
        do
        {
            Console.Write("Enter Employee ID: ");
        } while (!int.TryParse(Console.ReadLine(), out employeeID) || employeeID <= 0);

        return employeeID;
    }

    public static double ValidateSalary()
    {
        double salary;
        do
        {
            Console.Write("Enter Salary: ");
        } while (!double.TryParse(Console.ReadLine(), out salary) || salary <= 0);

        return salary;
    }
}
