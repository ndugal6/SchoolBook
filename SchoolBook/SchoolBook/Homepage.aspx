<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="SchoolBook.Homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
    HomePage
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <h1 id="Fname" runat="server"></h1>
    <h2>Upcoming Study Groups:</h2>
    <asp:PlaceHolder ID ="StdyGrpTbl" runat="server">

    </asp:PlaceHolder>
    <h2>Courses Enrolled</h2>
    <asp:PlaceHolder ID ="CourseTbl" runat="server">

    </asp:PlaceHolder>
</asp:Content>
