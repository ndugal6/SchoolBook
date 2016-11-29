using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolBook
{
    public partial class pdfviewer : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";
        protected void Page_Load(object sender, EventArgs e)
        {
            string stringid = Request.QueryString["para1"].ToString();
            string pdfFilename = Request.QueryString["para2"].ToString();

            MySqlConnection conn = new MySqlConnection(connstr);
            conn.Open();

            string cmd = "select pdfNotes from coursetaking WHERE CourseID != '0' and CourseTakingID = '" + stringid + "'";

            MySqlCommand sqlcmd = new MySqlCommand(cmd, conn);

            byte[] blob = (byte[])sqlcmd.ExecuteScalar();

            if (blob != null)
            {
                Response.ContentType = "application/pdf";
                Response.AddHeader("content-length", blob.Length.ToString());
                Response.BinaryWrite(blob);
            }
        }
    }
}