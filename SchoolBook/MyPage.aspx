<%@ Import Namespace="System" %>
<%@ Import Namespace="System.Collections.Generic" %>
<%@ Import Namespace="System.Linq" %>
<%@ Import Namespace="System.Web" %>
<%@ Import Namespace="System.Web.UI" %>
<%@ Import Namespace="System.Web.UI.WebControls" %>
<%@ Import Namespace="System.Windows.Forms" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Text" %>
<%@ Import Namespace="MySql.Data.MySqlClient" %>
<%@ Import Namespace="MySql.Data" %>
<%@ Import Namespace="System.Web.UI.HtmlControls" %>
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="SchoolBook.MyPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <script language="C#" runat="server">
        void SubmitBtn_Click(Object send, EventArgs e)
        {

        }
    </script>
    <h1>Create A Study Group</h1>
    <p><asp:Label runat="server" Text="Select A Course"></asp:Label></p>


 
    <p>
        <asp:ListBox ID="CoursesTable" runat="server">
            <asp:ListItem Enabled="false" ID="course1" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="course2" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="course3" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="course4" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="course5" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="course6" runat="server" Text=" " />
        </asp:ListBox>
    </p>
    <p><asp:Label ID="VenueLabel" runat="server" Text="Enter A Venue or Address:" /></p>
    <p><asp:TextBox ID="LocationBox" Text="Location Name" runat="server" />
        <asp:TextBox ID="AddressBox" Text="Address" runat="server" />
        <asp:TextBox ID="CityBox" Text="City" runat="server" />
        <asp:TextBox ID="StateBox" Text="State" runat="server" />
        <br />
        <asp:TextBox ID="groupSize" Text="Max Group Size" runat="server" />
    </p>
    <p><asp:Label ID="DLLabel" Text ="Set Date and Time:" runat="server"/></p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <asp:Label ID="HourLabel" Text="Time:" runat="server" />
        <asp:DropDownList ID="HourList" runat="server">
            <asp:ListItem ID="Hour1" Text="01" runat="server" />
            <asp:ListItem ID="ListItem1" Text="02" runat="server" />
            <asp:ListItem ID="ListItem2" Text="03" runat="server" />
            <asp:ListItem ID="ListItem3" Text="04" runat="server" />
            <asp:ListItem ID="ListItem4" Text="05" runat="server" />
            <asp:ListItem ID="ListItem5" Text="06" runat="server" />
            <asp:ListItem ID="ListItem6" Text="07" runat="server" />
            <asp:ListItem ID="ListItem7" Text="08" runat="server" />
            <asp:ListItem ID="ListItem8" Text="09" runat="server" />
            <asp:ListItem ID="ListItem9" Text="10" runat="server" />
            <asp:ListItem ID="ListItem10" Text="11" runat="server" />
            <asp:ListItem ID="ListItem11" Text="12" runat="server" />
            <asp:ListItem ID="ListItem12" Text="13" runat="server" />
            <asp:ListItem ID="ListItem13" Text="14" runat="server" />
            <asp:ListItem ID="ListItem14" Text="15" runat="server" />
            <asp:ListItem ID="ListItem15" Text="16" runat="server" />
            <asp:ListItem ID="ListItem16" Text="17" runat="server" />
            <asp:ListItem ID="ListItem17" Text="18" runat="server" />
            <asp:ListItem ID="ListItem18" Text="19" runat="server" />
            <asp:ListItem ID="ListItem19" Text="20" runat="server" />
            <asp:ListItem ID="ListItem20" Text="21" runat="server" />
            <asp:ListItem ID="ListItem21" Text="22" runat="server" />
            <asp:ListItem ID="ListItem22" Text="23" runat="server" />
        </asp:DropDownList>
        <asp:Label ID="MinuteLabel" Text=" : " runat="server" />
        <asp:DropDownList ID="MinuteList" runat="server" >
            <asp:ListItem ID="Min00" Text="00" runat="server" />
            <asp:ListItem ID="Min15" Text="15" runat="server" />
            <asp:ListItem ID="Min30" Text="30" runat="server" />
            <asp:ListItem ID="Min45" Text="45" runat="server" />
        </asp:DropDownList>
        
        <asp:Label ID="TimeError" runat="server" Visible="false" Text="Time Error: Please Format as HH:MM:SS "></asp:Label>
    </p>
    <p>
        <asp:Label ID="TutorLabel" Text="Would you Like a Tutor?"  runat="server" />
        <asp:CheckBox ID="CheckBox1" AutoPostBack="true" OnCheckedChanged="CheckBox1_CheckedChanged" runat="server" />
    </p>
    <p>
        
        <asp:Label ID="SelectTutorLabel" Visible="false" Text="Select A Tutor:" runat="server" />
    </p>
    <p>
        <asp:ListBox ID="TutorBox" Visible="false" runat="server" Height="200" Width="200" BackColor="#33CCFF" ForeColor="Blue">
            <asp:ListItem ID="Tutor1" Enabled="true"  runat="server" Text=" " />
            <asp:ListItem ID="Tutor2" Enabled="false" runat="server" Text=" " />
            <asp:ListItem ID="Tutor3" Enabled="false" runat="server" Text=" " />
            <asp:ListItem ID="Tutor4" Enabled="false" runat="server" Text=" " />
            <asp:ListItem ID="Tutor5" Enabled="false" runat="server" Text=" " />
        </asp:ListBox>
    </p>
    <p>
        <asp:Button ID="SubmitButton" Text="Submit" OnClick="SubmitButton_Click" runat="server" />
        <asp:Button ID="CancelButton" Text="Cancel" OnClick="SubmitButton_Click" runat="server" />
        <asp:Label ID="Error" Visible="false" runat="server" Text="Please Correctly fill in all information"></asp:Label>
    </p>
    </asp:Content>
