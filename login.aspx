<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="mohmmadabas.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 <style type="text/css">
        .auto-style1 {
            width: 56px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table border="1">
    <tr>
        <td class="auto-style1">Email</td>
        <td>
            <asp:TextBox ID="email" runat="server" ></asp:TextBox>
        </td>
    </tr>
        <tr>
        <td class="auto-style1">Password</td>
        <td>
            <asp:TextBox type="password" ID="password" runat="server"></asp:TextBox>
        </td>
   </tr>
    <tr>     
        <td class="auto-style1">            
            <asp:Button ID="Button1" runat="server" Text="login" Width="75px" OnClick="Button1_Click" />          
        </td>
    </tr>
</table>
    <a href="test.aspx">sign up</a>
 </asp:Content>
