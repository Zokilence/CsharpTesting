using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks; 
using System.Security.Principal;

namespace mailTest
{
    class Program
    {
        static void Main(string[] args)
        {

            string EmailSender = "zlazarov@smart.edu.rs";
            string EmailNalog = "zlazarov@smart.edu.rs";
            string EmailPass = "Zoki123";
            string EmailReceiver = "zokicerevic@gmail.com";
            string EmailSubject = "NAslov mejla";
            string emailBody = "sadržaj mejla";
             
            var smtpClient = new SmtpClient("smtp.outlook.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(EmailNalog, EmailPass),
                EnableSsl = true,
            };
            smtpClient.Send(EmailSender, EmailReceiver, EmailSubject, emailBody);
        }
    }
}
