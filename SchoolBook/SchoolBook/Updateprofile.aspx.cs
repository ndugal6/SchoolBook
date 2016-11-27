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

        //Fills all text boxes with user information
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["Parameter"].ToString();
            if (!IsPostBack)
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                try
                {
                    conn.Open();
                    //Below code: 
                    //Mysql commands to select the user information are set to strings cmd and cmd2. Said strings are made into sql commands.
                    //These commands are now used to pull the user information and add said information to their respective text boxes.
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
        //This method uses the text inside the text boxes to updats the user profile information inside the databse.
        protected void UpateProfileButton_Click(object sender, EventArgs e)
        {
            //Creates a string value for phone number, name and email. Sets the phone number and name to the respective text box values.
            //QueryString is used to get the user's email
            string PhoneNo = PhoneNumber.Text.ToString();
            string Name = FullName.Text.ToString();
            string email = Request.QueryString["Parameter"].ToString();
            MySqlConnection conn = new MySqlConnection(connstr);    //Creates connection

            //Below code:
            //A MySql Select command is set as a string. This command will update the phone number and full name to whatever strings are held in their respective text box.
            //the command is then ran and a message will display telling the user if it succeeeded or failed.
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
