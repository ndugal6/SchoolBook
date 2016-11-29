using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolBook
{
    public partial class Updateprofile : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";


        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["Parameter"].ToString();
            if (!IsPostBack)
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                try
                {
                    conn.Open();

                    string cmd = "SELECT PhoneNo FROM useraccounts where Email = '" + email + "';";
                    string cmd2 = "SELECT FullName FROM useraccounts where Email = '" + email + "';";
                    MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                    PhoneNumber.Text = sqlcmd.ExecuteScalar().ToString();
                    sqlcmd.CommandText = cmd2;
                    FullName.Text = sqlcmd.ExecuteScalar().ToString();
                }
                catch (MySqlException ex)
                {


                }
                conn.Close();
            }
        }

        protected void PhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        protected void UpateProfileButton_Click(object sender, EventArgs e)
        {

            string PhoneNo = PhoneNumber.Text.ToString();
            string Name = FullName.Text.ToString();
            string email = Request.QueryString["Parameter"].ToString();
            MySqlConnection conn = new MySqlConnection(connstr);

            //Add Validation Code
            try
            {
                conn.Open();
                string cmd = "UPDATE useraccounts SET PhoneNo = '" + PhoneNo + "', FullName = '" + Name + "' where email = '" + email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                sqlcmd.ExecuteNonQuery();
                lblmessage.Text = "Updated Sucessfully!";
            }
            catch (MySqlException ex)
            {
                lblmessage.Text = ex.ToString();
            }
            conn.Close();
        }

        protected void FullName_TextChanged(object sender, EventArgs e)
        {


        }


    }
}