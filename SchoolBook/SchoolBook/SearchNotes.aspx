<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchNotes.aspx.cs" Inherits="SchoolBook.SearchNotes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">
<style>
    .mydatagrid
{
	width: 80%;
	border: solid 2px black;
	min-width: 80%;
}
.header
{
	background-color: #646464;
	font-family: Arial;
	color: White;
	border: none 0px transparent;
	height: 25px;
	text-align: center;
	font-size: 16px;
}

.rows
{
	background-color: #fff;
	font-family: Arial;
	font-size: 14px;
	color: #000;
	min-height: 25px;
	text-align: left;
	border: none 0px transparent;
}
.rows:hover
{
	background-color: #ff8000;
	font-family: Arial;
	color: #fff;
	text-align: left;
}
.selectedrow
{
	background-color: #ff8000;
	font-family: Arial;
	color: #fff;
	font-weight: bold;
	text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS  **/
{
	background-color: Transparent;
	padding: 5px 5px 5px 5px;
	color: #fff;
	text-decoration: none;
	font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS  HOVER STYLES**/
{
	background-color: #000;
	color: #fff;
}
    .mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/ {
        background-color: #c9c9c9;
        color: #000;
        padding: 5px 5px 5px 5px;
    }

.mydatagrid td
{
	padding: 5px;
}
.mydatagrid th
{
	padding: 5px;
}
.linkbtncss{
    color:red;
}
</style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
    <h2>Search For Notes</h2>
   <h3>Select a course from the drop down list, courses are only displayed according to the university registered.</h3>
    <lable>Course: </lable> 
<asp:DropDownList ID = "ddlCourses" runat="server" >
</asp:DropDownList>
    <asp:Button ID="SearchBtn" runat="server" onclick="Find_Click" Text="Find" />
    
    <div style="height:50px"></div>
    <asp:GridView ID="NotesGrid" runat="server" AutoGenerateColumns="false" CssClass="mydatagrid"
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows">
    <Columns>
        <asp:BoundField DataField="Email" HeaderText="Submitted By" />
        <asp:TemplateField ItemStyle-HorizontalAlign="Center" FooterStyle-CssClass="linkbtncss">
            <ItemTemplate>
                <asp:LinkButton ID="lnkView" runat="server" Text="View" OnClick="View" CommandArgument='<%# Eval("CourseTakingID") %>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView> 
    <asp:Literal ID="ltEmbed" runat="server" /> 

</asp:Content>
