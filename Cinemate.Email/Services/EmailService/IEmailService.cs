using Cinemate.Email.Models;

namespace Cinemate.Email.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);
    }
}
