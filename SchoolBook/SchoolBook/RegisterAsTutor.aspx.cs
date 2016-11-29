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
using System.IO;

namespace SchoolBook
{
    public partial class RegisterAsTutor : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        
        //Below code fills in the drop down list with all courses in the user's university.
        //This is completed with a select sql command that selects all class names and course IDs and binds that data to the drop down list.
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string Email = Request.QueryString["Parameter"].ToString();
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select CourseName , courses.CourseID from coursetaking inner join courses on coursetaking.CourseID = courses.CourseID where courses.CourseID != '0' and coursetaking.CourseTakingID = (select CourseTakingID from useraccounts where Email = '" + Email + "');"))
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
        //Below code will take selected pdf file and class and creates a new row in the coursetaken table using all info gathered.
        protected void Register_Click(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString(); //Gains user email by using QueryString
            
            //Finding file name and type of file that was uploaded
            string filename = Path.GetFileName(pdfResult.PostedFile.FileName);
            string contentType = pdfResult.PostedFile.ContentType;

            //If it's a pdf, continue. If it isn't then throw an error
            if (contentType == "application/pdf")
            {   
                //Below code:
                //Gets string value of the course taken ID of the user using a select command. 
                //Gets the course ID and grade using the selected option on the drop down list.
                MySqlConnection conn = new MySqlConnection(connstr);
                conn.Open();
                string selCourseTakenID = "select CourseTakenID from useraccounts where Email='" + Email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(selCourseTakenID, conn);
                string coursetakenid = sqlcmd.ExecuteScalar().ToString();
                conn.Close();
                string courseID = ddlCourses.SelectedValue;
                string grade = ddlGrade.SelectedValue;

                //Below code:
                //A new row is added into the coursetaken MySql table using the insert command.
                //The row is filled with all string values created before said code.
                using (Stream fs = pdfResult.PostedFile.InputStream)
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((Int32)fs.Length);
                        using (MySqlConnection con = new MySqlConnection(connstr))
                        {
                            string query = "INSERT INTO coursetaken VALUES (@coursetakenID, @CourseID, '500000000' , @grade , @tutor , 1 , @pdfResdata , ' ')";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                cmd.Parameters.AddWithValue("@coursetakenID", coursetakenid);
                                cmd.Parameters.AddWithValue("@CourseID", courseID);
                                cmd.Parameters.AddWithValue("@grade", grade);
                                cmd.Parameters.AddWithValue("@tutor" , 'p');
                                cmd.Parameters.AddWithValue("@pdfResdata", bytes);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                }
                lblMessage.Text = "Application for tutoring Sent!";
            }

            else
            {
                lblMessage.Text = "only pdf files are allowed";
            }

           
        }
    }
}
