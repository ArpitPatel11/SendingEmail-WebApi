using Email.Models;
using Email.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Email.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Email : ControllerBase
    {
        private readonly IEmailService _emailService;

        public Email(IEmailService emailService)
        {
           _emailService = emailService;
        }
        [HttpPost]
        public IActionResult SendEmail (Emaildto request)
        {
            _emailService.SendMail(request);
            return Ok();
        }

    }
}
