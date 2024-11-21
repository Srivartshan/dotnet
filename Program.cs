using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************************************************");
        Console.WriteLine("Welcome to the Login Page!");

        var loginManager = new LoginManager();

        string username;
        do
        {
            Console.Write("Enter your username: ");
            username = Console.ReadLine();
        } while (string.IsNullOrEmpty(username)); 

        string password;
        do
        {
            Console.Write("Enter your password: ");
            password = loginManager.GetHiddenPassword();
        } while (string.IsNullOrEmpty(password));

        if (loginManager.ValidateLogin(username, password))
        {
            Console.WriteLine("\nLogin Successful!");
            Console.WriteLine("*********************************************************");

            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. List Employees");
                Console.WriteLine("3. Exit");
                Console.WriteLine("---------------------------------------------------------");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string name = Validation.ValidateName();
                        string dob = Validation.ValidateDOB();
                        string email = Validation.ValidateEmail();
                        string phoneNumber = Validation.ValidatePhoneNumber();
                        int employeeID = Validation.ValidateEmployeeID();
                        double salary = Validation.ValidateSalary();

                        Console.Write("Enter Department: ");
                        string department = Console.ReadLine();

                        Console.Write("Enter Position: ");
                        string position = Console.ReadLine();

                        var employee = new Employee(name, dob, email, phoneNumber, employeeID, salary, department, position);
                        employees.Add(employee);
                        Console.WriteLine("Employee added successfully!");
                        break;

                    case "2":
                        if (employees.Count > 0)
                        {
                            Console.WriteLine(".........................................................");   
                            Console.WriteLine("\nEmployee List:");
                            foreach (var emp in employees)
                            {
                                emp.DisplayDetails();
                            }
                            Console.WriteLine("........................................................."); 
                        }
                        else
                        {
                            Console.WriteLine("No employees found.");
                            Console.WriteLine("........................................................."); 
                        }
                        break;

                    case "3":
                        // Exit
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("\nLogin Failed! Incorrect username or password.");
            Console.WriteLine("*********************************************************");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
