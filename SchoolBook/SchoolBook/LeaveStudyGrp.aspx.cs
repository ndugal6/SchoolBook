/****************************************************************************************/
/*
/* FILE NAME: Default.aspx.cs
/*
/* DESCRIPTION: Contains the various functions required by the introductory page: Login, Register , Send-Email , Forget Password
/*
/* REFERENCE: -Nil-
/*
/* DATE         BY              CHANGE       DESCRIPTION
/* ========     =======         ======       =============
/* 10/20/2016   Steffano soh    Creation     Created the file and implemented Functions for Login, Register , Forget Password & UI Creation.   
/*
/*
/*
/****************************************************************************************/

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
    public partial class LeaveStudyGrp : System.Web.UI.Page
    {
        string Email;
        string StdyGrpID;
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        StringBuilder table = new StringBuilder();
        protected void Page_Load(object sender, EventArgs e)
        {

            Email = Request.QueryString["Parameter"].ToString();
            StdyGrpID = Request.QueryString["SGID"].ToString();

            if (Email != StdyGrpID)
            {
                int GrpSize = Int32.Parse(Request.QueryString["Grpsize"]);
                LeaveStdyGrp(StdyGrpID, Email, GrpSize);
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
                    table.Append("<td><a href = 'http://localhost:23240/LeaveStudyGrp.aspx?Parameter=Test@gmail.com&SGID= " +StdyGrpData.GetValue(0).ToString()+"&Grpsize= " +StdyGrpData.GetValue(4).ToString()+"'>Leave</a></td>");
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

        public void LeaveStdyGrp(string StdyGrpid, string Email, int grpsize)
        {

            MySqlConnection conn = new MySqlConnection(connstr);
            grpsize -= 1;
            string NewGrpsize = grpsize.ToString();

            try
            {
                conn.Open();
                string cmd = "DELETE FROM studygroup WHERE StudyGrpId = '" + StdyGrpid + "' and Email ='" + Email + "'";
                string cmd2 = "UPDATE studygroup SET StudyGrpSize = '" + NewGrpsize + "' WHERE StudyGrpID = '" + StdyGrpid + "'";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                sqlcmd.ExecuteNonQuery();
                sqlcmd.CommandText = cmd2;
                sqlcmd.ExecuteNonQuery();
                Message.InnerHtml = "Left Study Group Sucessfully";


            }
            catch (MySqlException ex)
            {
                Message.InnerHtml = ex.ToString();
            }


            conn.Close();
        }
    }
}