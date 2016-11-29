<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordResetPage.aspx.cs" Inherits="SchoolBook.PasswordResetPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>SchoolBook-Password Reset</h1>
    <label>New Password: </label> <asp:TextBox ID="newpw" runat="server" TextMode="Password"></asp:TextBox><br />
    <label>Confirm Password: </label> <asp:TextBox ID="confirmnew" runat="server" TextMode="Password"></asp:TextBox><br />
    <asp:Button ID="Submit" Text="Submit" runat="server" OnClick="Submit_Click" /><br />
    <asp:Label Text="" ID="lblmsg" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>
