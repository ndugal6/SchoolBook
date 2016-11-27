<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Updateprofile.aspx.cs" Inherits="SchoolBook.Updateprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    Phone Number:&nbsp;
<asp:TextBox ID="PhoneNumber" runat="server" OnTextChanged="PhoneNumber_TextChanged" Width="200px"></asp:TextBox>
<br />
Full Name:&nbsp;
<asp:TextBox ID="FullName" runat="server" OnTextChanged="FullName_TextChanged" Width="200px"></asp:TextBox>
    <br />
    <asp:Button ID="UpateProfileButton" runat="server" Text="Update Profile" OnClick="UpateProfileButton_Click" />
<br />
</asp:Content>
