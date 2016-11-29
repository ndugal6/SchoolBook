using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySql.Data;
using System.Web.UI.HtmlControls;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

namespace SchoolBook
{
    public partial class UploadFiles : System.Web.UI.Page
    {

        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        string email;
        string userID;
        string[] coursesNameArray = new string[6];
        string selectedCourseName; 

        protected void Page_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);

            email = Request.QueryString["Parameter"].ToString();
            try
            {
                conn.Open();
                string cmd1 = "select CourseTakingID from useraccounts where email = '" + email + "'";
                MySqlCommand sqlcmd1 = new MySqlCommand(cmd1, conn);
                string courseTakenID = sqlcmd1.ExecuteScalar().ToString();
                //string cmd2 = "select * from CourseTaking where CourseTakingId = '" + courseTakenID + "'";
                string cmd2 = "select CourseName from CourseTaking inner join courses on coursetaking.courseid = courses.courseid where CourseTakingId = '" + courseTakenID + "' and courses.courseid != '0'";
                sqlcmd1.CommandText = cmd2;

                int courseCount = 1;
                MySqlDataReader coursesID = sqlcmd1.ExecuteReader();

                while (coursesID.Read())
                {
                    string courseName = coursesID.GetValue(0).ToString();
                    coursesNameArray[courseCount - 1] = coursesID.GetValue(0).ToString();

                    switch (courseCount)
                    {
                        case 1:
                            addCourse(course1, courseName);
                            break;
                        case 2:
                            addCourse(course2, courseName);
                            break;
                        case 3:
                            addCourse(course3, courseName);
                            break;
                        case 4:
                            addCourse(course4, courseName);
                            break;
                        case 5:
                            addCourse(course5, courseName);
                            break;
                        case 6:
                            addCourse(course6, courseName);
                            break;
                    }
                    courseCount++;
                }

                

            }
            catch (MySqlException ex)
            {
                System.Console.Write("there's an sql exception");
            }
            conn.Close();

        }

        protected void UploadButton_Click(Object sender, EventArgs e)
        {
            selectedCourseName = coursesNameArray[CoursesTable.SelectedIndex];
            string Email = Request.QueryString["Parameter"].ToString();

            string filename = Path.GetFileName(pdfNotes.PostedFile.FileName);
            string contentType = pdfNotes.PostedFile.ContentType;

            if (contentType == "application/pdf")
            {
                MySqlConnection conn = new MySqlConnection(connstr);
                conn.Open();

                string cmd1 = "SELECT CourseID FROM courses where CourseName = '" + selectedCourseName + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd1,conn);
                string courseID = sqlcmd.ExecuteScalar().ToString();

                string selCourseTakenID = "select CourseTakingID from useraccounts where Email='" + Email + "';";
                sqlcmd.CommandText = selCourseTakenID;
                string coursetakingid = sqlcmd.ExecuteScalar().ToString();
                conn.Close();

                using (Stream fs = pdfNotes.PostedFile.InputStream)
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        byte[] bytes = br.ReadBytes((Int32)fs.Length);
                        using (MySqlConnection con = new MySqlConnection(connstr))
                        {
                            string query = "UPDATE coursetaking SET pdfNotes = @Notes WHERE CourseTakingID = '" + coursetakingid + "' and CourseID = '" + courseID + "';";
                            using (MySqlCommand cmd = new MySqlCommand(query))
                            {
                                cmd.Connection = con;
                                cmd.Parameters.AddWithValue("@Notes", bytes);
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                            }
                        }
                    }
                }
                UploadStatus.Text = "Notes Uploaded";
            }

            else
            {
                UploadStatus.Text = "only pdf files are allowed";
            }


        }
        protected void addCourse(ListItem course, string name)
        {
            course.Text = name;
            course.Enabled = true;
        }

        protected void getImage(byte[] byteArrayIn)
        {
            //return (Bitmap)
            //using (var ms = new MemoryStream(byteArrayIn))
            //{
             //   return Image.FromStream(ms,true);
            //}
        }
    }
}