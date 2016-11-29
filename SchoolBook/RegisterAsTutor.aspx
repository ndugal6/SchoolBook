<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterAsTutor.aspx.cs" Inherits="SchoolBook.RegisterAsTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">

   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <div class="divfloat">
    <h2>Register As Tutor</h2>
    <label>Course: </label>
    <asp:DropDownList ID = "ddlCourses" runat="server">
    </asp:DropDownList>
    <br />
    <label>Grade: </label>
    <asp:DropDownList ID="ddlGrade" runat="server">
                <asp:ListItem Text="Select Grade" Value="0"></asp:ListItem>
                <asp:ListItem Text="A+" Value="A+"></asp:ListItem>
                <asp:ListItem Text="A" Value="A"></asp:ListItem>
                <asp:ListItem Text="A-" Value="A-"></asp:ListItem>
                <asp:ListItem Text="B+" Value="B+"></asp:ListItem>
                <asp:ListItem Text="B" Value="B"></asp:ListItem>
                <asp:ListItem Text="B-" Value="B-"></asp:ListItem>
                <asp:ListItem Text="C+" Value="C+"></asp:ListItem>
                <asp:ListItem Text="C" Value="C"></asp:ListItem>
                <asp:ListItem Text="C-" Value="C-"></asp:ListItem>
                <asp:ListItem Text="D+" Value="D+"></asp:ListItem>
                <asp:ListItem Text="D" Value="D"></asp:ListItem>
                <asp:ListItem Text="D-" Value="D-"></asp:ListItem>
                <asp:ListItem Text="F" Value="F"></asp:ListItem>
    </asp:DropDownList><br />
    <label>Results: 
    <asp:FileUpload ID="pdfResult" runat="server" />
    </label><br />
    <asp:Button ID="Register" runat="server" Text="Register as Tutor" OnClick="Register_Click" /> <br />
    <asp:Label Text="" runat="server" ID="lblMessage"></asp:Label>
        </div>
</asp:Content>
