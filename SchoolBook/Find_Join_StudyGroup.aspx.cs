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

namespace SchoolBook
{
    public partial class Find_Join_StudyGroup : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        string email;
        static string[] coursesNameArray = new string[6];
        static string[] groupIdArray = new string[6];

        protected void Page_Load(object sender, EventArgs e)
        {


            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            string updating = "UPDATE studygroup set studygroup.Status = 'F' where studygroup.DateTime < Now()";
            MySqlCommand cmd = new MySqlCommand(updating, conn);
            cmd.ExecuteNonQuery();
            email = "test@gmail.com";// Request.QueryString["Parameter"].ToString();

            try
            {
                string cmd1 = "select CourseTakingID from useraccounts where email = '" + email + "'";
                cmd.CommandText = cmd1;
                string courseTakenID = cmd.ExecuteScalar().ToString();
                //string cmd2 = "select * from CourseTaking where CourseTakingId = '" + courseTakenID + "'";
                string cmd2 = "select CourseName from CourseTaking inner join courses on coursetaking.courseid = courses.courseid where CourseTakingId = '" + courseTakenID + "'";
                cmd.CommandText = cmd2;

                int courseCount = 1;
                MySqlDataReader coursesID = cmd.ExecuteReader();

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

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string MyEmail = "test@gmail.com";// Request.QueryString["Parameter"].ToString();

            ResultsTable.Visible = true;
            ResultsLabel.Visible = true;
            MySqlConnection conn = new MySqlConnection(connstr);
            Group1.Text = "No Group Available :( Would you like to create one?";
            Group1.Enabled = true;

            try
            {
                conn.Open();
                string groupCourse = coursesNameArray[CoursesTable.SelectedIndex];
                string getCourseIdCmd = "select CourseID from courses where CourseName = '" + groupCourse + "'";
                MySqlCommand sqlcmd1 = new MySqlCommand(getCourseIdCmd, conn);
                string courseTakenID = sqlcmd1.ExecuteScalar().ToString();
                string getGroupsCmd = "select * from studygroup where Email != '" + MyEmail + "' and StudyGrpSize < StudyGrpMaxSize and CourseID = '" + courseTakenID + "'";
                sqlcmd1.CommandText = getGroupsCmd;


                MySqlDataReader groups = sqlcmd1.ExecuteReader();
                int count = 1;
                while (groups.Read())
                {
                    string details = "Venue: " + groups.GetValue(2).ToString() + " Size: " + groups.GetValue(4).ToString() + " At: " + groups.GetValue(6).ToString();

                    groupIdArray[count - 1] = groups.GetValue(0).ToString();

                    switch (count)
                    {
                        case 1:
                            JoinButton.Visible = true;
                            addGroup(Group1, details);
                            break;
                        case 2:
                            addGroup(Group2, details);
                            break;
                        case 3:
                            addGroup(Group3, details);
                            break;
                        case 4:
                            addGroup(Group4, details);
                            break;
                        case 5:
                            addGroup(Group5, details);
                            break;
                    }
                    count++;
                }
                if (JoinButton.Visible == false)
                {
                    CreateButton.Visible = true;
                }
                groups.Close();
            }
            catch
            {

            }
        }
        protected void addCourse(ListItem course, string name)
        {
            course.Text = name;
            course.Enabled = true;
        }
        protected void addGroup(ListItem group, string name)
        {
            group.Enabled = true;
            group.Text = name;
        }

        protected void JoinButton_Click(object sender, EventArgs e)
        {
            string MyEmail = Request.QueryString["Parameter"].ToString();
            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();
            string groupID = groupIdArray[ResultsTable.SelectedIndex];
            string cmd = "select * from studygroup where StudyGrpId = '" + groupID + "'";
            MySqlCommand groupInfo = new MySqlCommand(cmd, conn);
            MySqlDataReader readIt = groupInfo.ExecuteReader();
            readIt.Read();
            string venue = readIt.GetValue(2).ToString();
            string tutEmail = readIt.GetValue(3).ToString();
            string size = readIt.GetValue(4).ToString();
            string maxsize = readIt.GetValue(5).ToString();
            string dateTime = dateformat(readIt.GetValue(6).ToString());
            string uniId = readIt.GetValue(7).ToString();
            string courseId = readIt.GetValue(8).ToString();
            string status = readIt.GetValue(9).ToString();
            readIt.Close();

            string insertRecord = "INSERT INTO studygroup VALUES ('" + groupID + "','" + MyEmail + "','" + venue + "','" + tutEmail + "','" + size + "','" + maxsize + "','" + dateTime + "','" + uniId + "','" + courseId + "','" + status + "');";
            groupInfo.CommandText = insertRecord;
            groupInfo.ExecuteNonQuery();
            int newgrpsize = Int32.Parse(size) + 1;
            string newgrpsizestring = newgrpsize.ToString();
            string updaterecords = "UPDATE studygroup SET StudyGrpSize = '" + newgrpsizestring + "' WHERE StudyGrpID = '" + groupID + "'";
            groupInfo.CommandText = updaterecords;
            groupInfo.ExecuteNonQuery();

            lblmsg.Visible = true;
            lblmsg.Text = "Sucessfully joined study group!";


        }

        public string dateformat(string date1)
        {
            string[] dateComponents = date1.Split(' ');
            string[] lessDates = dateComponents[0].Split('/');
            string month = lessDates[1];
            string time = date1.Substring(10, 7);
            if (month.Length == 1) { month = '0' + month; }
            string day = lessDates[1];
            if (day.Length == 1) { day = '0' + day; }
            string year = lessDates[2];
            string completeDate = year + '-' + month + '-' + day + ' ' + time;
            return completeDate;
        }

        protected void CreateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyPage.aspx?Parameter=" + email);
        }
    }
}