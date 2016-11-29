/****************************************************************************************/
/*
/* FILE NAME: site1.Master.cs
/*
/* DESCRIPTION: Contains MasterPage Template information
/*
/* REFERENCE: -Nil-
/*
/* DATE         BY              CHANGE       DESCRIPTION
/* ========     =======         ======       =============
/* 10/20/2016   Steffano soh    Creation     Created the UI without any server-end functionality.   
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

namespace SchoolBook
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        public void RedirectLeaveStudyGrp(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("LeaveStudyGrp.aspx?Parameter=" + Email + "&SGID=" +Email);
        }

        public void RedirectAddcourse(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("AddCourse.aspx?Parameter=" + Email);
        }

        public void RedirectRegtut(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("RegisterAsTutor.aspx?Parameter=" + Email);
        }

        public void RedirectUpdateProfile(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("Updateprofile.aspx?Parameter=" + Email);
        }

        public void RedirectUploadNotes(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("UploadFiles.aspx?Parameter=" + Email);
        }

        public void RedirectSearchNotes(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("SearchNotes.aspx?Parameter=" + Email);
        }

        public void RedirectSearchStdyGrp(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("Find_Join_StudyGroup.aspx?Parameter=" + Email);
        }

        public void RedirectCreateStdyGrp(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("MyPage.aspx?Parameter=" + Email);
        }

        public void RedirectLogout(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            Response.Redirect("Default.aspx");
        }




    }
}