/****************************************************************************************/
/*
/* FILE NAME: Homepage.aspx.cs
/*
/* DESCRIPTION: Contains the welcome page after user login, loaded from masterpage
/*
/* REFERENCE: -Nil-
/*
/* DATE         BY              CHANGE       DESCRIPTION
/* ========     =======         ======       =============
/* 10/20/2016   Steffano soh    Creation     File Creation & Creation of getUserFullName() function   
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
    public partial class Homepage : System.Web.UI.Page
    {
        string Email;
        string StdyGrpID;
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        StringBuilder table = new StringBuilder();
        StringBuilder coursetable = new StringBuilder(); 

        protected void Page_Load(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            string FullName = getUserFullName(Email);
            Fname.InnerHtml = "Welcome, " + FullName;

            Email = Request.QueryString["Parameter"].ToString();


            MySqlConnection conn = new MySqlConnection(connstr);

            table.Append("<table class='responstable'>");
            table.Append("<tr><th> Venue </th><th> Date / Time </th><th> Tutor Email </th><th> Course </th></tr> ");

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
                    table.Append("</tr>");
                }
                table.Append("</table>");
                StdyGrpTbl.Controls.Add(new Literal { Text = table.ToString() });

            }
            catch (MySqlException ex)
            {

            }
            conn.Close();

            coursetable.Append("<table class='responstable'>");
            coursetable.Append("<tr><th> Course Name </th><th> Course Credit </th><th> Professor </th></tr> ");

            try
            {
                conn.Open();
                string cmd = "select * from useraccounts inner join coursetaking on useraccounts.CourseTakingID = coursetaking.CourseTakingID inner join courses on coursetaking.CourseID = courses.CourseID where coursetaking.CourseID != '0' and useraccounts.Email = '" + Email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                MySqlDataReader courseData = sqlcmd.ExecuteReader();
                while (courseData.Read())
                {
                    coursetable.Append("<tr>");
                    coursetable.Append("<td>" + courseData.GetValue(15).ToString() + "</td>");
                    coursetable.Append("<td>" + courseData.GetValue(16).ToString() + "</td>");
                    coursetable.Append("<td>" + courseData.GetValue(17).ToString() + "</td>");
                    coursetable.Append("</tr>");
                }
                coursetable.Append("</table>");
                CourseTbl.Controls.Add(new Literal { Text = coursetable.ToString() });

            }
            catch (MySqlException ex)
            {

            }
            conn.Close();
        }


        /**
        * Creates a MySQL Connection to retrieve User's Full Name Based on Email(argument) provided on login.
        *
        * @Creates full name type string
        * @Created MySqlConnection with connstr as input credentials
        * @open connection executes SQL Statement and stores returned scalar result(parse-ed as string) as fullname
        * @close Connection and return fullname
        */
        public string getUserFullName(string Email)
        {
            string fullname = null;
            MySqlConnection conn = new MySqlConnection(connstr);

            try
            {
                conn.Open();
                string cmd = "SELECT FullName FROM useraccounts WHERE Email = '" + Email + "';";
                MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);
                fullname = (string)sqlcmd.ExecuteScalar();
            }
            catch (MySqlException ex)
            {

            }
            conn.Close();
            return fullname;
        }
    }
}