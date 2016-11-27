<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="RegisterAsTutor.aspx.cs" Inherits="SchoolBook.RegisterAsTutor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Head" runat="server">

    <style>
        .responstable {
            margin: 1em 0;
            width: 100%;
            overflow: hidden;
            background: #FFF;
            color: #024457;
            border-radius: 10px;
            border: 1px solid #167F92;
        }

            .responstable tr {
                border: 1px solid #D9E4E6;
            }

                .responstable tr:nth-child(odd) {
                    background-color: #EAF3F3;
                }

            .responstable th {
                display: none;
                border: 1px solid #FFF;
                background-color: #167F92;
                color: #FFF;
                padding: 1em;
            }

                .responstable th:first-child {
                    display: table-cell;
                    text-align: center;
                }

                .responstable th:nth-child(2) {
                    display: table-cell;
                }

                    .responstable th:nth-child(2) span {
                        display: none;
                    }

                    .responstable th:nth-child(2):after {
                        content: attr(data-th);
                    }

        @media (min-width: 480px) {
            .responstable th:nth-child(2) span {
                display: block;
            }

            .responstable th:nth-child(2):after {
                display: none;
            }
        }

        .responstable td {
            display: block;
            word-wrap: break-word;
            max-width: 7em;
        }

            .responstable td:first-child {
                display: table-cell;
                text-align: center;
                border-right: 1px solid #D9E4E6;
            }

        @media (min-width: 480px) {
            .responstable td {
                border: 1px solid #D9E4E6;
            }
        }

        .responstable th, .responstable td {
            text-align: left;
            margin: .5em 1em;
        }

        @media (min-width: 480px) {
            .responstable th, .responstable td {
                display: table-cell;
                padding: 1em;
            }
        }

        body {
            padding: 0 2em;
            font-family: Arial, sans-serif;
            color: #024457;
            background: #f2f2f2;
        }

        h1 {
            font-family: Verdana;
            font-weight: normal;
            color: #024457;
        }

            h1 span {
                color: #167F92;
            }
    </style>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Body" runat="server">
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

</asp:Content>
