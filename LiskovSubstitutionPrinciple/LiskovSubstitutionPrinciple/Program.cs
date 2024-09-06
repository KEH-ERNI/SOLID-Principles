using LiskovSubstitutionPrinciple.Models;

public class Program
{
    static void Main(string[] args)
    {
        Admin admin = new Admin("Lester");
        Employee emp = new Employee("Khyla");

        DoSomething(admin);
        Console.WriteLine("");
        DoSomething(emp);
    }

    private static void DoSomething(User user) {
        user.LogIn();
        user.PerformWork();
        user.LogOut();
    }
}