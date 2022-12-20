using Email.Models;

namespace Email.Services
{
    public interface IEmailService
    {
        void SendMail(Emaildto request);

    }
}
