/****************************************************************************************/
/*
/* FILE NAME: Default.aspx.cs
/*
/* DESCRIPTION: Contains the various functions required by the introductory page: Login, Register , Send-Email , Forget Password
/*
/* REFERENCE: -Nil-
/*
/* DATE         BY              CHANGE       DESCRIPTION
/* ========     =======         ======       =============
/* 10/20/2016   Steffano soh    Creation     Created the file and implemented Functions for Login, Register , Forget Password & UI Creation.   
/*
/*
/*
/****************************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace SchoolBook
{
    public partial class Default : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //Function called when login button is clicked, retrieves information from database to check if useraccount is registered!
        protected void login_Click(object sender, EventArgs e)
        {
            string Email = email.Value;
            string password = formpassword.Value;
            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();
                string cmd = "SELECT * FROM useraccounts WHERE Email = '" + Email + "' and Password = '" + password + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                

                if (sqlcmd.ExecuteReader().Read())
                {
                    loginstatuslbl.InnerHtml = "Logged in sucessfully";
                    Response.Redirect("Homepage.aspx?Parameter=" + Email);
                }
                else
                    loginstatuslbl.InnerHtml = "incorrect Userid / Password!";

                
            }
            catch (MySqlException ex)
            {
                loginstatuslbl.InnerHtml = "Failed to login";
            }
            conn.Close();
        }

        //function called when user request for password reset.
        protected void forgetpass_click(object sender, EventArgs e)
        {
            string Email = email.Value;
            string emailMessage = "Hi! please go to this link to reset your password!:<a href='http://localhost:23240/PasswordResetPage.aspx?COmplex=YtshdbahK8duNdjdyahsbJduashndk&Parameter=" + Email + "'>Click Here! </a>";
            sendEmail(emailMessage, Email , "Password Retrieval");
        }
        //function called when cancel button is clicked
        protected void forgetpasscancel_click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        //function called when Register button is clicked, inserts values to database.
        protected void Reg_Click(object sender, EventArgs e)
        {
            string Email = email.Value;
            string password = formpassword.Value;
            string cfmemail = regcfmemail.Value;
            string cfmpassword = regcfmpassword.Value;
            string DOB = DobInput.Value;
            string fullname = regFullName.Value;
            string gender = "empty";
            if (regMale.Value == "Male")
                gender = "M";
            else if (regFemale.Value == "Female")
                gender = "F";
            string uni = regUni.Value;
            int coursetakindid;

            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();
                string SelUniCmd = "SELECT UniversityID FROM university WHERE UniversityName = '" + uni + "';";
                string selCourseTakingID = "select max(CourseTakingID) from useraccounts;";
                MySqlCommand sqlcmd = new MySqlCommand(SelUniCmd, conn);
                string uniid = sqlcmd.ExecuteScalar().ToString();

               

                sqlcmd.CommandText = selCourseTakingID;
                coursetakindid = Int32.Parse(sqlcmd.ExecuteScalar().ToString());
                coursetakindid = coursetakindid + 1;
                string CourseTakingIDString = coursetakindid.ToString();

                string selCourseTakenID = "select max(CourseTakenID) from useraccounts;";
                sqlcmd.CommandText = selCourseTakenID;
                int coursetakenID = Int32.Parse(sqlcmd.ExecuteScalar().ToString());
                coursetakenID = coursetakenID + 1;
                string CoursetakenIDString = coursetakenID.ToString();

                string insertCourseTaking = "INSERT INTO coursetaking values ('" + CourseTakingIDString + "' , '0' , '0' , '' )";
                sqlcmd.CommandText = insertCourseTaking;
                sqlcmd.ExecuteNonQuery();

                string insertCourseTaken = "INSERT INTO coursetaken values ('" + CoursetakenIDString + "', '0' , '500000000' , 'F' , 'F' , '1' , ' ' , ' ' )";
                sqlcmd.CommandText = insertCourseTaken;
                sqlcmd.ExecuteNonQuery();


                string cmd = "INSERT INTO useraccounts (Email,Password,UniversityID,Gender,DOB,FullName,CourseTakingID, CourseTakenID) Values ('" + Email + "','" + password + "','" + uniid + "','" + gender + "','" + DOB + "','" + fullname + "','" +CourseTakingIDString + "','" + coursetakenID + "');";
                sqlcmd.CommandText = cmd;
                sqlcmd.ExecuteNonQuery();
                loginstatuslbl.InnerHtml = "Sucessfully Registered!";
                sendEmail("Sucessfully registered!",Email, "Welcome to SchoolBook!");

            }
            catch (MySqlException ex)
            {
                loginstatuslbl.InnerHtml = ex.ToString();
            }

            conn.Close();
        }

        public void sendEmail(string emailMsg, string receiver, string emailsubject)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("theschoolbook2016@gmail.com");
            msg.To.Add(receiver);
            msg.Body = emailMsg;
            msg.IsBodyHtml = true;
            msg.Subject = emailsubject;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            System.Net.NetworkCredential NetCred = new System.Net.NetworkCredential();
            NetCred.UserName = "theschoolbook2016@gmail.com";
            NetCred.Password = "Password2016";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetCred;
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Send(msg);

        }

       


    }
}