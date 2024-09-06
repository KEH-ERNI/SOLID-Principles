namespace LiskovSubstitutionPrinciple.Models {
    public abstract class User {
        protected string _name;
        
        public User(string name) {
            _name = name;
        }

        public void LogIn() {
            Console.WriteLine($"{_name} log in.");
        }

        public void LogOut() {
            Console.WriteLine($"{_name} log out.");
        }
        public abstract void PerformWork();
    }
}