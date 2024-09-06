using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models {
    public class Manager : IEmployees, IWorkHours, IManaging { 
        public void Work() {
            Console.WriteLine("Manager is working.");
        }

        public void TimeIn() {
            Console.WriteLine("Manager time-in at 8:00 AM.");
        }

        public void Manage() {
            Console.WriteLine("Manager is managing.");
        }
    }
}