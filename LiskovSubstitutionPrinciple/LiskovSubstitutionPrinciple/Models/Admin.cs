namespace LiskovSubstitutionPrinciple.Models {

    public class Admin : User {
        public Admin(string name) : base(name) { }
        public override void PerformWork() {
            AccessAdmin();
        }
        public void AccessAdmin() {
            Console.WriteLine($"{_name} accessed admin modules.");
        }
    }
    
}