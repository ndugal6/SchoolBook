<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Find_Join_StudyGroup.aspx.cs" Inherits="SchoolBook.Find_Join_StudyGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">

<h1>Search and Join Study Groups!</h1>
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


    
    <p>
        <asp:Button ID="SearchButton" Text="Search!" OnClick="SearchButton_Click" runat="server" />
    </p>
    <p>
        <asp:Label ID="ResultsLabel" Text="Choose one of the following" Visible="false" runat="server" />
        <asp:ListBox ID="ResultsTable" Visible="false" runat="server">
            <asp:ListItem Enabled="false" ID="Group1" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="Group2" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="Group3" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="Group4" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="Group5" runat="server" Text=" " />
            <asp:ListItem Enabled="false" ID="Group6" runat="server" Text=" " />
        </asp:ListBox>
    </p>
    <p>
        <asp:Button ID="JoinButton" Text="Join Group!" Visible="false" OnClick="JoinButton_Click" runat="server" />
        <asp:Button ID="CreateButton" Visible="false" Text="Create Study Group" OnClick="CreateButton_Click" runat="server" />
    </p>
    
    <asp:Label runat="server" Text="" Visible="false" ID="lblmsg"></asp:Label>



</asp:Content>
