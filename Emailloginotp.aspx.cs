using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string k = ConfigurationManager.ConnectionStrings["cs"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        } 

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(k);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_login", con);
                cmd.Parameters.AddWithValue("@username",txtuname.Text);
                cmd.Parameters.AddWithValue("@password",txtpwd.Text);
                cmd.CommandType = CommandType.StoredProcedure;
               int i = Convert.ToInt32(cmd.ExecuteScalar());
                if(i==1)
                {
                    try
                    {
                        MailMessage mail = new MailMessage();
                        mail.To.Add(txtuname.Text);
                        mail.From = new MailAddress("sathishpabballa@gmail.com");
                        mail.Subject = "LOGIN--ALERT";

                        string emailbody = "";
                        emailbody += "<br>Hello User</br>";
                        emailbody += "<br>sucessfully Logined</br>";
                        emailbody += "<br>Thank You</br>";

                        mail.Body = emailbody;
                        mail.IsBodyHtml = true;

                        SmtpClient smtp = new SmtpClient();
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtp.Port = 587;
                        smtp.EnableSsl = true;
                        smtp.Host = "smtp.gmail.com";
                        smtp.Credentials = new System.Net.NetworkCredential("sathishpabballa@gmail.com", "leju bobt tijm nhwp");
                        smtp.Send(mail);
                        lbldisplay.Text = "hloo mail";
                    }
                    catch(Exception ex)
                    {
                        lbldisplay.Text = ex.Message;
                    }
                   
                }
                else
                {
                    Random r = new Random();
                    int num=r.Next(1000,9999);
                    string otp = num.ToString();
                    lbldisplay.Text = otp;
                }
            }
            catch(Exception ex)
            {
                lbldisplay.Text = ex.Message;
            }
            finally
            {
                con.Close();
            }
        }
    }
}