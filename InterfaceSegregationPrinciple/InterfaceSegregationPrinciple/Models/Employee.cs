using InterfaceSegregationPrinciple.Interfaces;

namespace InterfaceSegregationPrinciple.Models {
    public class Employee : IEmployees, IWorkHours {
        public void Work() {
            Console.WriteLine("Employee is working.");
        }

        public void TimeIn() {
            Console.WriteLine("Employee time-in at 8:58 AM.");
        }
    }
    
}