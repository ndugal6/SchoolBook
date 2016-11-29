using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace SchoolBook
{
    public partial class PasswordResetPage : System.Web.UI.Page
    {
        string email;
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        protected void Page_Load(object sender, EventArgs e)
        {
            email = Request.QueryString["Parameter"].ToString();

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string newpassword = newpw.Text;
            string cfmpassword = confirmnew.Text;
            if (newpassword == cfmpassword) {
                MySqlConnection conn = new MySqlConnection(connstr);
                string cmd = "UPDATE useraccounts set Password = '" + newpassword + "' WHERE Email = '" + email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                lblmsg.Text = "Password updated! redirecting you to SchoolBook in 3 seconds!";
                Response.AddHeader("REFRESH", "2;URL=Default.aspx");
            }
            else
            {
                lblmsg.Text = "Confirm password did not match";
            }
        }
    }
}