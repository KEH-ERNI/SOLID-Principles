using DependencyInversionPrinciple.Interfaces;
using DependencyInversionPrinciple.Models;

class Program {
    public static void Main(string[] args) {
        IEmailSender emailSender = new EmailService();
        Notification notification = new Notification(emailSender);
        
        notification.PromotionalNotification();
    }
}