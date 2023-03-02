using AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Negosud.MVCWeb.Models;
using System.Net.Mail;

namespace Negosud.MVCWeb.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="from"></param>
        /// <param name="body"></param>
        public static void sendContact(string from, string body)
        {
            string mail = "renaud.levasseur@viacesi.fr";
            string paswword = "Rykew589";

            MailMessage mailMessage = new MailMessage();
            System.Net.Mail.MailAddress address = new MailAddress(mail, from);
            mailMessage = new MailMessage();
            mailMessage.IsBodyHtml = true;
            mailMessage.Subject = "Message contact de site negosud";
            mailMessage.From = address;
            mailMessage.Body = body;
            mailMessage.To.Add("clement.cantaloube@viacesi.fr");

            SmtpClient smtpClient = new SmtpClient("smtp-mail.outlook.com");
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            System.Net.NetworkCredential credential = new System.Net.NetworkCredential(mail, paswword);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = credential;

            smtpClient.Send(mailMessage);


        }

        //Méthode Post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(ContactViewModel model)
        {

            sendContact(model.from, model.body);
            return View("../Home/Contact");

        }
    }
}
