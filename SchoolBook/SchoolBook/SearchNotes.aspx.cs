using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolBook
{
    public partial class SearchNotes : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string Email = Request.QueryString["Parameter"].ToString();
                using (MySqlConnection conn = new MySqlConnection(connstr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("select CourseID, CourseName from courses where courses.CourseID != '0' and courses.UniversityID = (select UniversityID from useraccounts where useraccounts.Email = '" + Email + "');"))
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

        protected void Find_Click(object sender, EventArgs e)
        {
            string courseid = ddlCourses.SelectedValue.ToString();
            string Email = Request.QueryString["Parameter"].ToString();
            using (MySqlConnection con = new MySqlConnection(connstr))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "select Email, coursetaking.CourseTakingID , pdfNotes from coursetaking inner join useraccounts on coursetaking.CourseTakingID = useraccounts.CourseTakingID WHERE CourseID != 0 and CourseID = '" + courseid + "'";
                    cmd.Connection = con;
                    con.Open();
                    NotesGrid.DataSource = cmd.ExecuteReader();
                    NotesGrid.DataBind();
                    con.Close();
                }
            }

        }

        protected void View(object sender, EventArgs e)
        {
            int id = int.Parse((sender as LinkButton).CommandArgument);
            string stringid = id.ToString();
            string pdfFilename = ddlCourses.SelectedItem.ToString() + stringid + DateTime.Now.ToString();
            Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", "pdfviewer.aspx?para1=" + stringid + "&para2=" + pdfFilename));
         
        }
    }

}