<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="WebApp.StudentForm" %>

    <!DOCTYPE html>
    <html>

    <head>
        <title>Student Registration</title>
    </head>

    <body>

        <form id="form1" runat="server">

            <h2>Insert Student Data</h2>

            Name:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />

            Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />

            <br /><br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>

            <hr />

            <h2>Student List</h2>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </form>

    </body>

    </html>