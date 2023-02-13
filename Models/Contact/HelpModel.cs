using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;
using System.Net.Mail;
using System.Xml.Linq;

namespace DevBoost.Models.Contact
{
    public class HelpModel : PageModel
    {
        public string isSend { get; set; }   

        public void OnGet()
        {

        }

        public void OnPost()
        {
            var name = Request.Form["name"];
            var email = Request.Form["emailaddress"];
            var message = Request.Form["message"];

            try
            {

                SendMail(name, email, message);
                isSend = "sent";
            }
            catch (Exception)
            {
                isSend = "failed";
            }
        }

        public bool SendMail(string name, string email, string message)
        {
            MailMessage mainMessage = new MailMessage();
            SmtpClient smtpClient  = new SmtpClient();
            mainMessage.From = new MailAddress("noreply@zetbit.tech");
            mainMessage.To.Add("vaskoorakov17@gmail.com");
            mainMessage.Subject = "Test email";
            mainMessage.IsBodyHtml = true;
            mainMessage.Body = "<p>Name: " + name +" </p>"+ "<p>Email: " + email + " </p>"+ "<p>Message: " + message + "</p>";


            smtpClient.Port = 587;
            smtpClient.Host = "something.provider.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("when i get a provider","i will type it");
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.Send(mainMessage);

            return true;
        }
    }
}
