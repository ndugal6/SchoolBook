
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Web.UI.HtmlControls;

namespace SchoolBook
{
    public partial class JoinStudyGrp : System.Web.UI.Page
    {
        string Email;
        string StdyGrpID;
        string connstr = @"Data Source=localhost; Database=school_book_db; User ID=root; Password=password1";
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {
            Email = Request.QueryString["Parameter"].ToString();
            StdyGrpID = Request.QueryString["SGID"].ToString();

            if (Email != StdyGrpID)
            {
                int GrpSize = Int32.Parse(Request.QueryString["Grpsize"]);
                JoinStdyGrp(StdyGrpID, Email, GrpSize);
            }

            MySqlConnection conn = new MySqlConnection(connstr);

            table.Append("<table class='responstable'>");
            table.Append("<tr><th> Venue </th><th> Date / Time </th><th> Tutor Email </th><th> Course </th><th> Delete </th></tr> ");

            try
            {
                conn.Open();
                string cmd = "SELECT * FROM studygroup inner join courses on studygroup.CourseID = courses.CourseID where studygroup.Email = '" + Email + "'";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                MySqlDataReader StdyGrpData = sqlcmd.ExecuteReader();
                while (StdyGrpData.Read())
                {
                    table.Append("<tr>");
                    table.Append("<td>" + StdyGrpData.GetValue(2).ToString() + "</td>");
                    table.Append("<td>" + StdyGrpData.GetValue(6).ToString() + "</td>");
                    table.Append("<td>" + StdyGrpData.GetValue(3).ToString() + "</td>");
                    table.Append("<td>" + StdyGrpData.GetValue(12).ToString() + "</td>");
                    table.Append("<td><a href = 'http://localhost:23240/LeaveStudyGrp.aspx?Parameter=Test@gmail.com&SGID= " + StdyGrpData.GetValue(0).ToString() + "&Grpsize= " + StdyGrpData.GetValue(4).ToString() + "'>Leave</a></td>");
                    table.Append("</tr>");
                }
                table.Append("</table>");
                StdyGrpTbl.Controls.Add(new Literal { Text = table.ToString() });

            }
            catch (MySqlException ex)
            {

            }
            conn.Close();
        }
        public void JoinStdyGrp(string StdyGrpid, string Email, int grpsize)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            grpsize += 1;
            string NewGrpsize = grpsize.ToString();

            try
            {
                conn.Open();
                string cmd = "JOIN FROM studygroup WHERE StudyGrpID = '" + StdyGrpid + "' and Email" + Email + "'";
                string cmd2 = "UPDATE studygroup SET StudyGrpSize = '" + NewGrpsize + "' WHERE StudyGrpID = '" + StdyGrpid + "'";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                sqlcmd.ExecuteNonQuery();
                sqlcmd.CommandText = cmd2;
                sqlcmd.ExecuteNonQuery();
                Message.InnerHtml = "Joined Study Group Successfully";
            }
           catch (MySqlException ex)
            {
                Message.InnerHtlm = ex.ToString();
            }

            conn.Close();
        }
    }
}