using System;
using System.Net.Mail;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{   
    class Program
    { 
    static void Main(string[] Args)
    {
            SendEmail(getUserName(), getPassword());
            Console.ReadLine();
    }
    
    public static void SendEmail(string fromAddress,string password)
    {
            using SmtpClient email = new SmtpClient
            {
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                EnableSsl = true,
                Host = "smtp.sendgrid.net",
                Port = 465,
                Credentials = new System.Net.NetworkCredential(fromAddress, password, "smtp.sendgrid.net"),
                Timeout = 180
        };
            string subject = "test1";
            string body = $"welcome @{DateTime.UtcNow:F}";

          



            try
            {
                Console.WriteLine("sending email.....");
                var toaddress = new MailAddress("hberk2509@gmail.com");
                var fromaddress = new MailAddress("asd@gmail.com");
                var message= new MailMessage(fromaddress,toaddress);
                message.Subject = "SADS";
                message.Body = " welcome ";
                email.Send(message);
                
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e.Message);
             
            }


           
        }
    public static string getUserName()
    {
        return "apikey";
    }

    public static string getPassword()
    {
        return "SG.OY3nTWGuT_yVgaoOjoMcEg.L-hv1PxHm8nsc5f3h_txULb24qwC0yQoY2idy";
    }

    

}

}
