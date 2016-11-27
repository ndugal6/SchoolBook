<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TutorRegistration.aspx.cs" Inherits="SchoolBook.TutorRegistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <p style="font-weight: 700">
        <h1>Register As Tutor</h1> 
        <asp:DropDownList ID="RegTutor1" runat="server" OnSelectedIndexChanged="RegTutor1_SelectedIndexChanged">
        </asp:DropDownList>

        <asp:DropDownList ID="RegTutor2" runat="server" OnSelectedIndexChanged="RegTutor2_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
</asp:Content>
