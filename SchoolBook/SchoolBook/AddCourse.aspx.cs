using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class AddCourse : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        StringBuilder table = new StringBuilder();
        
        //Below code:
        //Fills the drop down list with all courses that has the univeristy ID as the user.
        protected void Page_Load(object sender, EventArgs e)
        {
            AddCourseBtn.Visible = false;
            if (!Page.IsPostBack)
            {
                string Email = Request.QueryString["Parameter"].ToString();
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select CourseID, CourseName from courses where courses.UniversityID = (select UniversityID from useraccounts where useraccounts.Email = '" + Email + "');"))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = conn;
                        conn.Open();
                        ddlCourses.DataSource = cmd.ExecuteReader();
                        ddlCourses.DataTextField = "CourseName";
                        ddlCourses.DataValueField = "CourseID";
                        ddlCourses.DataBind();
                        conn.Close();
                    }
                }
                ddlCourses.Items.Insert(0, new ListItem("--Select Course--", "0"));
            }
        }

        protected void ddlCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        //Below code:
        //Creates a table of the course data and fill the table with the class that is selected in the drop down list. 
        //The class data is found using a select command, which restricts the class rows to only classes that have the specified univesity ID.
        protected void Find_Click(object sender, EventArgs e)
        {
            table.Append("<table class='responstable'>");
            table.Append("<tr><th> University </th><th> CourseName </th><th> Course Credit </th><th> Professor </th></tr> ");
            string courseid = ddlCourses.SelectedValue.ToString();
            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();
                string cmd = "select * from courses inner join university on courses.UniversityID = university.UniversityID where courses.CourseID = '" + courseid + "'";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                MySqlDataReader CourseData = sqlcmd.ExecuteReader();
                while (CourseData.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>" + CourseData.GetValue(6).ToString() + "</td>");
                    table.Append("<td>" + CourseData.GetValue(2).ToString() + "</td>");
                    table.Append("<td>" + CourseData.GetValue(3).ToString() + "</td>");
                    table.Append("<td>" + CourseData.GetValue(4).ToString() + "</td>");
                    table.Append("</tr>");
                }
                table.Append("</table>");
                CourseTbl.Controls.Add(new Literal { Text = table.ToString() });

            }
            catch (MySqlException ex)
            {

            }
            conn.Close();
            AddCourseBtn.Visible = true;
        }
        //Below code adds a new row into coursetaking using the selected course info
        protected void AddCourseBtn_Click(object sender, EventArgs e)
        {
            //Gains usesr email using QueryString. Gets course ID from the selected course in the drop down list.
            string courseid = ddlCourses.SelectedValue.ToString();
            string Email = Request.QueryString["Parameter"].ToString();
            string courseTakingID;
            MySqlConnection conn = new MySqlConnection(connstr);
            //Below code:
            //Finds unique course taking ID from the user using a select MySql command.
            //Using an insert MySql command, a new row in coursetaking is made with the previously stated data filling the rows.
            try
            {
                conn.Open();
                string cmd = "SELECT CourseTakingID from useraccounts WHERE Email = '" + Email + "'";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                courseTakingID = sqlcmd.ExecuteScalar().ToString();
                string cmd2 = "INSERT into coursetaking VALUES ('" + courseTakingID + "' , '" + courseid + "' , '500000000' , ' ');";
                sqlcmd.CommandText = cmd2;
                sqlcmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                Msglbl.InnerHtml = ex.ToString();
            }

        }
    }
    }
