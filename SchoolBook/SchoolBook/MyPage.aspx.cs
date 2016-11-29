using System;
using System.Text.RegularExpressions;
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

namespace SchoolBook
{

    public partial class MyPage : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        string email;
        string emailPattern = @"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$";
        static string[] coursesNameArray = new string[6];
        static string[] tutorsArray = new string[6];
        string[] hourArray = { "00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23" };
        string[] minArray = { "00", "15", "30", "45" };
        protected void Page_Load(object sender, EventArgs e)
        {


            MySqlConnection conn = new MySqlConnection(connstr);
            tutorsArray[0] = "None";
            email = Request.QueryString["Parameter"].ToString();


            try
            {
                conn.Open();
                string cmd1 = "select CourseTakingID from useraccounts where email = '" + email + "'";
                MySqlCommand sqlcmd1 = new MySqlCommand(cmd1, conn);
                string courseTakenID = sqlcmd1.ExecuteScalar().ToString();
                //string cmd2 = "select * from CourseTaking where CourseTakingId = '" + courseTakenID + "'";
                string cmd2 = "select CourseName from CourseTaking inner join courses on coursetaking.courseid = courses.courseid where courses.CourseID != '0' and CourseTakingId = '" + courseTakenID + "'";
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
                coursesID.Close();
            }
            catch (MySqlException ex)
            {
                System.Console.Write("there's an sql exception");
            }

            conn.Close();

        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                Error.Visible = false;
                conn.Open();
                string time = hourArray[HourList.SelectedIndex] + ":" + minArray[MinuteList.SelectedIndex] + ":00";
                string date1 = Calendar1.SelectedDate.ToString();

                string[] dateComponents = date1.Split(' ');
                string[] lessDates = dateComponents[0].Split('/');
                string month = lessDates[0];
                if (month.Length == 1) { month = '0' + month; }
                string day = lessDates[1];
                if (day.Length == 1) { day = '0' + day; }
                string year = lessDates[2];
                string completeDate = year + '-' + day + '-' + month + ' ' + time;

                string venueName = LocationBox.Text.ToString();
                string venueAddress = AddressBox.Text.ToString() + ", " + CityBox.Text.ToString() + "," + StateBox.Text.ToString();
                string stdyGroupCourse = coursesNameArray[CoursesTable.SelectedIndex];
                string cmd1 = "select * from courses where CourseName = '" + stdyGroupCourse + "'";
                string groupCourseID = "";
                string groupUniversityID = "";
                string tutor = tutorsArray[TutorBox.SelectedIndex];
                string size = groupSize.Text;
                MySqlCommand sqlcmd1 = new MySqlCommand(cmd1, conn);
                MySqlDataReader courseInfo = sqlcmd1.ExecuteReader();
                if (courseInfo.Read())
                {
                    groupCourseID = courseInfo.GetValue(0).ToString();
                    groupUniversityID = courseInfo.GetValue(1).ToString();
                }
                else
                {
                    ///Something handling an error should go here
                }
                courseInfo.Close();
                string dateTime = date1 + time;
                string completeVenue = venueName + venueAddress;
                sqlcmd1.CommandText = "SELECT max(StudyGrpID) FROM studygroup";
                int newstdygrpid = Int32.Parse(sqlcmd1.ExecuteScalar().ToString());
                newstdygrpid += 1;
                sqlcmd1.CommandText = "INSERT into studygroup VALUES ('" + newstdygrpid + "','" + email + "','" + completeVenue + "','" +
                    tutor + "',' 1','" + size + "','" + completeDate + "','" + groupUniversityID + "','" + groupCourseID + "', 'T')";
                sqlcmd1.ExecuteNonQuery();
                Response.Redirect("Homepage.aspx?Parameter=" + email);
            }

            catch (Exception ex)
            {
                RegexUtilities reg = new RegexUtilities();

                Console.WriteLine(ex.ToString());
                Error.Visible = true;
            }

            //MISSING SQL UPDATE FUNCTION BITCH
            conn.Close();

        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            SelectTutorLabel.Visible = true;
            TutorBox.Visible = true;
            MySqlConnection conn = new MySqlConnection(connstr);
            updateTutor(Tutor1, "No Tutors Available");
            try
            {
                conn.Open();
                string groupCourse = coursesNameArray[TutorBox.SelectedIndex];
                string getTutorEmailCmd = "select CourseID from courses where CourseName = '" + groupCourse + "'";
                MySqlCommand sqlcmd1 = new MySqlCommand(getTutorEmailCmd, conn);
                string courseTakenID = sqlcmd1.ExecuteScalar().ToString();
                string getTutorsCmd = "select * from coursetaken where CourseID = '" + courseTakenID + "'";
                sqlcmd1.CommandText = getTutorsCmd;

                MySqlDataReader tutors = sqlcmd1.ExecuteReader();
                int tutorCount = 1;
                while (tutors.Read())
                {
                    string tutName = tutors.GetValue(4).ToString();
                    tutorsArray[tutorCount - 1] = tutName;
                    switch (tutorCount)
                    {
                        case 1:
                            updateTutor(Tutor1, tutName);
                            break;
                        case 2:
                            updateTutor(Tutor2, tutName);
                            break;
                        case 3:
                            updateTutor(Tutor3, tutName);
                            break;
                        case 4:
                            updateTutor(Tutor4, tutName);
                            break;
                        case 5:
                            updateTutor(Tutor5, tutName);
                            break;
                    }
                    tutorCount++;
                }
                tutors.Close();
                if (tutorCount == 1)
                {
                    updateTutor(Tutor1, "No Tutors Available");
                    tutorsArray[tutorCount - 1] = "Nobody";
                }
            }
            catch
            {

            }

        }

        protected void updateTutor(ListItem tutor, string name)
        {
            tutor.Enabled = true;
            tutor.Text = name;
        }

        protected void addCourse(ListItem course, string name)
        {
            course.Text = name;
            course.Enabled = true;
        }
    }
}