using DependencyInversionPrinciple.Interfaces;

namespace DependencyInversionPrinciple.Models {
    public class Notification {
        private IEmailSender _sender;

        public Notification(IEmailSender sender) {
            this._sender = sender;
        }

        public void PromotionalNotification() {
            var content = "You have won a gift!";
            _sender.SendEmail(content);
        }

      
    }
}