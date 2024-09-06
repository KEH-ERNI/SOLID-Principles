namespace LiskovSubstitutionPrinciple.Models {

    public class Employee : User {
        public Employee(string name) : base(name) { }
        public override void PerformWork()
        {
             Console.WriteLine($"{_name} performed work.");
        }
    }
    
}