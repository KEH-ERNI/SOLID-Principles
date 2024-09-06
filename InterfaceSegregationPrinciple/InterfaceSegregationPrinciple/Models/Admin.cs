using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models {
    public class Admin : IEmployees, IWorkHours, IAccounts {
        public void Work() {
            Console.WriteLine("Admin is working.");
        }

        public void TimeIn() {
            Console.WriteLine("Admin time-in at 8:30 AM.");
        }

        public void DeleteUser() {
            Console.WriteLine("Admin deleted a user.");
        }
    }
}