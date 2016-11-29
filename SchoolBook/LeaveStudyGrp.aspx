<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaveStudyGrp.aspx.cs" Inherits="SchoolBook.LeaveStudyGrp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <h1>Leave Study Group </h1>

    <asp:PlaceHolder ID ="StdyGrpTbl" runat="server">

    </asp:PlaceHolder>
    <h4 id="Message" runat="server" style="color:red"></h4>
</asp:Content>
