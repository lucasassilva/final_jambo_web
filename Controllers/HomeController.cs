using Microsoft.AspNetCore.Mvc;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System;
using System.IO;
using Jambo_dev.Models;
using System.Text.Json;
using System.Threading.Tasks;

namespace Jambo_dev.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("/")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult SendEmail([FromBody] EmailModel model, MimeMessage mail, SmtpClient smtp, BodyBuilder bodyBuilder)
        {
            dynamic path = Path.Combine("Views/Shared/" + Path.GetFileName("_Template.cshtml"));
            dynamic content = System.IO.File.ReadAllText(path);
            content = content.Replace("@Model.first_name", model.first_name);
            content = content.Replace("@Model.last_name", model.last_name);
            content = content.Replace("@Model.message", model.message);
            try
            {
                mail.From.Add(MailboxAddress.Parse(model.email));
                mail.To.Add(MailboxAddress.Parse("lucasalves5671@gmail.com"));
                mail.Subject = model.subject;
                mail.Date = DateTimeOffset.Now;
                bodyBuilder.HtmlBody = content;
                mail.Body = bodyBuilder.ToMessageBody();
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("lucasalves5671@gmail.com", "Lu123456789@");
                smtp.Send(mail);
                return Json(new {model, message = "E-mail foi enviado com sucesso !"});
            }
            catch (Exception e)
            {
                throw new InvalidOperationException(e.Message);
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }
        }
    }
}

