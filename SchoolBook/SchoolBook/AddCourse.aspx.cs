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

        protected void AddCourseBtn_Click(object sender, EventArgs e)
        {
            string courseid = ddlCourses.SelectedValue.ToString();
            string Email = Request.QueryString["Parameter"].ToString();
            string courseTakingID;
            MySqlConnection conn = new MySqlConnection(connstr);

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