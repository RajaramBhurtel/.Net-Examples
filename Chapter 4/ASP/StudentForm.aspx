<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentForm.aspx.cs" Inherits="WebApplication1.StudentForm" %>

    <!DOCTYPE html>

    <html>

    <head runat="server">
        <title>Student Registration</title>
    </head>

    <body>

        <form id="form1" runat="server">

            <h2>Student Registration Form</h2>

            <asp:Image ID="imgCollege" runat="server" Width="150" Height="150" ImageUrl="images/college.png" />

            <br /><br />

            Full Name:

            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

            <br /><br />

            Email:

            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>

            <br /><br />

            Gender:

            <asp:RadioButton ID="rbMale" runat="server" GroupName="Gender" Text="Male" />

            <asp:RadioButton ID="rbFemale" runat="server" GroupName="Gender" Text="Female" />

            <br /><br />

            Department:

            <asp:DropDownList ID="ddlDepartment" runat="server">

                <asp:ListItem>Computer Science</asp:ListItem>
                <asp:ListItem>Information Technology</asp:ListItem>
                <asp:ListItem>Business Studies</asp:ListItem>
                <asp:ListItem>Engineering</asp:ListItem>

            </asp:DropDownList>

            <br /><br />

            Hobbies:

            <br />

            <asp:CheckBox ID="chkReading" runat="server" Text="Reading" />

            <asp:CheckBox ID="chkSports" runat="server" Text="Sports" />

            <asp:CheckBox ID="chkMusic" runat="server" Text="Music" />

            <br /><br />

            Country:

            <asp:ListBox ID="lstCountry" runat="server">

                <asp:ListItem>Nepal</asp:ListItem>
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>China</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>

            </asp:ListBox>

            <br /><br />

            <asp:Button ID="btnSave" runat="server" Text="Save Student" OnClick="btnSave_Click" />

            <br /><br />

            <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>

            <br /><br />

            <asp:HyperLink ID="hlGoogle" runat="server" NavigateUrl="https://www.google.com" Text="Visit Google"
                Target="_blank">
            </asp:HyperLink>

            <hr />

            <h3>Inserted Students</h3>

            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>

        </form>

    </body>

    </html>