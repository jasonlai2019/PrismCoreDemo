using PrismCoreDemo.Services.Interfaces;

namespace PrismCoreDemo.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
