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

            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();
                string SelUniCmd = "SELECT UniversityID FROM university WHERE UniversityName = '" + uni + "';";
                MySqlCommand sqlcmd = new MySqlCommand(SelUniCmd, conn);
                string uniid = sqlcmd.ExecuteScalar().ToString();
                string cmd = "INSERT INTO useraccounts (Email,Password,UniversityID,Gender,DOB,FullName) Values ('" + Email + "','" + password + "','" + uniid + "','" + gender + "','" + DOB + "','" + fullname + "');";
                sqlcmd.CommandText = cmd;
                sqlcmd.ExecuteNonQuery();
                loginstatuslbl.InnerHtml = "Sucessfully Registered!";
                sendEmail("Sucessfully registered!",Email);

            }
            catch (MySqlException ex)
            {
                loginstatuslbl.InnerHtml = ex.ToString();
            }

            conn.Close();
        }

        public void sendEmail(string emailMsg, string receiver)
        {
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress("theschoolbook2016@gmail.com");
            msg.To.Add(receiver);
            msg.Body = emailMsg;
            msg.IsBodyHtml = true;
            msg.Subject = "Welcome to SchoolBook!";

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