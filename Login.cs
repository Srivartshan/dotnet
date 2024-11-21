using System;

public class LoginManager
{
    private readonly string Username = "admin"; 
    private readonly string Password = "Password123";

    public bool ValidateLogin(string inputUsername, string inputPassword)
    {
        return inputUsername == Username && inputPassword == Password;
    }

    public string GetHiddenPassword()
    {
        string password = "";
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);
            if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
            {
                password += key.KeyChar;
                Console.Write("*");
            }
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password = password.Substring(0, password.Length - 1);
                Console.Write("\b \b");
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine();
        return password;
    }
}
