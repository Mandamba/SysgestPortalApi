using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;

namespace SysgestColegios.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendEmailAttachController : ControllerBase
    {
        [HttpPost]
        public IActionResult SendEmail(string body)
        {
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("florindo937@gmail.com"));
            email.To.Add(MailboxAddress.Parse("florindo.sysgest@gmail.com"));
            email.Subject = "Email de Teste";
            email.Body = new TextPart(TextFormat.Html) { Text = body};

            
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587);
            
            smtp.Authenticate("florindo937@gmail.com", "1993florindobraganca");
            smtp.Send(email);
            smtp.Disconnect(true);


            return Ok();
        }
    }
}
