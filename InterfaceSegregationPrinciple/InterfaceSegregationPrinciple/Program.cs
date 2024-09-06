using InterfaceSegregationPrinciple.Models;

public class Program {
    public static void Main(string[] args) {

        Admin admin = new Admin();
        Manager manager = new Manager();
        Employee employee = new Employee();

        admin.TimeIn();
        admin.Work();
        admin.DeleteUser();

        Console.WriteLine();

        manager.TimeIn();
        manager.Work();
        manager.Manage();

        Console.WriteLine();

        employee.TimeIn();
        employee.Work();
    }
}