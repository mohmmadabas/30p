<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sign up.aspx.cs" Inherits="mohmmadabas.sign_up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <script type="text/javascript">
            function checkpass()
            {
                var message = "";
                var IsOk = true;
                var pass1 = document.getElementById("password").value;
                var pass2 = document.getElementById("password2").value;
                var fname = document.getElementById("firstname").value;
                var lname = document.getElementById("lastname").value;
                var email = document.getElementById("email").value;
                if (fname == '')
                {
                    IsOk = false;
                    message = "wrong fname";
                }
                if (lname == '')
                {
                    IsOk = false;
                    message = "wrong lname";
                }
                if (email == '')
                {
                    IsOk = false;
                    message = "wrong email";
                }
                if (!IsOk)
                {
                    document.getElementById("messagex").innerText = message;
                    event.preventDefault();
                }
            }
        </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                first name
            </td>
            <td>
                <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                last name
            </td>
            <td>
                <asp:TextBox ID="lastname" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                Email
            </td>
            <td>
                <asp:TextBox ID="email" type="email" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="password" name="password" Type="password" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr>
            <td>
                password
            </td>
            <td>
                <asp:TextBox ID="password2" name="password2" Type="password" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClientClick ="checkpass()" OnClick="Button1_Click1" />             
            </td>
        </tr>
    </table>
    <div id="messagex">
        
    </div>
</asp:Content>
