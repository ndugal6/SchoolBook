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
    }
}