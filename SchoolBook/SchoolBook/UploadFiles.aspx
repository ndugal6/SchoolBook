<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UploadFiles.aspx.cs" Inherits="SchoolBook.UploadFiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <div class="divfloat">
    <h1>Upload Notes</h1>
    <p><asp:Label runat="server" Text="Choose Course to Upload Files To"></asp:Label></p>
    
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
        
        <asp:FileUpload ID="pdfNotes" runat="server" />
        <br /> <br />
        <asp:button ID="UploadButton" OnClick="UploadButton_Click" text="UploadFile" runat="server"   />
    </p>
    <p>
        <asp:Label ID="UploadStatus" text="Nothing Uploaded yet" runat="server" />
    </p>
    
        </div>

</asp:Content>