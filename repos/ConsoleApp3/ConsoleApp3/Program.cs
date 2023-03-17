using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> mails = new List<string>();
            recipients(mails);

            int i = 0;


            while (i < mails.Count)
            {
                SendEmail(mails, i);
                i++;
            }
        }



        public static void SendEmail(List<string> list, int index)
        {
            string recip = list[index];
            SqlConnection conn = new SqlConnection("Server=DESKTOP-06E9EHK;Database=DBSignUp;Trusted_Connection=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_mail", conn);
            SqlCommand comm = new SqlCommand("newstat", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            comm.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DateTime", DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
            cmd.Parameters.AddWithValue("@MailID", Guid.NewGuid());
            cmd.Parameters.AddWithValue("@Recipient", recip);


            MailMessage message = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("randomhesap111123123@gmail.com", "guevysykzvqjothj");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            message.To.Add(recip);
            message.From = new MailAddress("randomhesap111123123@gmail.com", "guevysykzvqjothj");
            message.Subject = "test1";
            message.Body = "Welcome " + recip + $" @ {DateTime.UtcNow:F}";
            cmd.Parameters.AddWithValue("@Context", message.Body);


            try
            {
                Console.WriteLine("sending email.....");
                smtp.Send(message);
                cmd.Parameters.AddWithValue("@ErrorMessage", "0");
                comm.Parameters.AddWithValue("@Email", recip);
            }
            catch (SmtpException e)
            {
                Console.WriteLine(e.Message);
                cmd.Parameters.AddWithValue("@ErrorMessage", e.Message);
            }

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void recipients(List<string> maillist)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-06E9EHK;Database=DBSignUp;Trusted_Connection=True;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_recipients", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    maillist.Add((string)dr["Email"]);
                }
            }


            dr.Close();
            conn.Close();
        }
    }
}

