using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Models {
    public class EmailService : IEmailSender {
        public void SendEmail(string content) {
            Console.WriteLine($"{content}");
        }
    }
}