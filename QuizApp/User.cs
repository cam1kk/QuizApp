using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
internal class User
{
    public string? Login { get; set; }
    public string? Password { get; set; }
    public DateTime BirthDay { get; set; }
    public User(string login, string password, DateTime birthday)
    {
        Login = login; Password = password;
        BirthDay = birthday;
    }
    public User(User other)
    {
        Login = other.Login; Password = other.Password;
        BirthDay = other.BirthDay;
    }
    public void Show()
    {
        Console.WriteLine($"Login:{Login}"); 
        Console.WriteLine($"Password:{Password}");
        Console.WriteLine($"Birthday:{BirthDay.ToString("dd.MM.yyyy")}");
    }
    public static User Registration()
    {
        string loginR = null, passwordR = null; DateTime birthDayR = default(DateTime);
        while (true)
        {
            Console.Clear();
            if (string.IsNullOrEmpty(loginR))
            {
                Console.WriteLine("Create a login: "); 
                loginR = Console.ReadLine();
            }
            if (string.IsNullOrEmpty(passwordR))
            {
                Console.WriteLine("Create a password: ");
                passwordR = Console.ReadLine();
            }
            if (birthDayR == default(DateTime))
            {
                Console.WriteLine("Enter your birth date (dd.MM.yyyy): "); 
                if (DateTime.TryParse(Console.ReadLine(), out birthDayR))
                {
                    if (birthDayR > DateTime.Now)
                    {
                        Console.WriteLine("Invalid birth date. Please enter a valid date.");
                        birthDayR = default(DateTime);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid date format. Please enter date in yyyy-MM-dd format.");
                }
            }
            if (!string.IsNullOrEmpty(loginR) && !string.IsNullOrEmpty(passwordR) && birthDayR != default(DateTime))
            {
                break;
            }
        }
        return new(loginR, passwordR, birthDayR);
    }
}