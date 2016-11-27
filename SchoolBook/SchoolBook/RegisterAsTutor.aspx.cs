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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string Email = Request.QueryString["Parameter"].ToString();
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select CourseName , courses.CourseID from coursetaking inner join courses on coursetaking.CourseID = courses.CourseID where coursetaking.CourseTakingID = (select CourseTakingID from useraccounts where Email = '" + Email + "');"))
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

        protected void Register_Click(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();

            string filename = Path.GetFileName(pdfResult.PostedFile.FileName);
            string contentType = pdfResult.PostedFile.ContentType;

            if (contentType == "application/pdf")
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                conn.Open();
                string selCourseTakenID = "select CourseTakenID from useraccounts where Email='" + Email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(selCourseTakenID, conn);
                string coursetakenid = sqlcmd.ExecuteScalar().ToString();
                conn.Close();
                string courseID = ddlCourses.SelectedValue;
                string grade = ddlGrade.SelectedValue;

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