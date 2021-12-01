<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Usertable.aspx.cs" Inherits="mohmmadabas.Usertable" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-sm">
        <tr>
            <td>
                <%=st %>
            </td>
        </tr>
    </table>
</asp:Content>
