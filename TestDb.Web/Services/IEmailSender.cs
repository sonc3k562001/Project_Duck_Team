using System.Threading.Tasks;

namespace TestDb.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
