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
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolBook
{
    public partial class Homepage : System.Web.UI.Page
    {
        string connstr = @"Data Source=localhost; Database=school_book_db; User Id=root; Password=password1";

        protected void Page_Load(object sender, EventArgs e)
        {
            string Email = Request.QueryString["Parameter"].ToString();
            string FullName = getUserFullName(Email);
            Fname.InnerHtml = FullName;
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