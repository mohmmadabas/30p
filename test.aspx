<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="mohmmadabas.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
                    message = "wrong information \n";
                }
                if (lname == '')
                {
                    IsOk = false;
                    message = "wrong information \n";
                }
                if (email == '')
                {
                    IsOk = false;
                    message = "wrong information \n";
                }
                if (pass1 != pass2)
                {
                    IsOk = false;
                    message += "wrong pass \n";
                }
                if (!IsOk)
                {
                    document.getElementById("messagex").innerText = message;
                    event.preventDefault();
                }
            }
            </script>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">

    <!-- JavaScript Bundle with Popper -->
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p" crossorigin="anonymous"></script>
    <style>
        .footer{
            position:fixed;
            left:0;
            bottom: 0;
            width: 100%;
            background-color: lightgray;
            color: black;
            text-align: center;
            font-size: 16px;

        }
    </style>
</head>
<body>
    <nav class="navbar navbar-expand-lg navbar-light bg-light">
  <div class="container-fluid">
    <a class="navbar-brand" style="color:gold" href="#">House Pro</a>
    <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
      <span class="navbar-toggler-icon"></span>
    </button>
    <div class="collapse navbar-collapse" id="navbarSupportedContent">
      <ul class="navbar-nav me-auto mb-2 mb-lg-0">
        <li class="nav-item">
          <a class="nav-link active" aria-current="page" href="Home.aspx">Home</a>
        </li>
        <li class="nav-item">
          <a class="nav-link" href="buy.aspx">BUY</a>
            <li class="nav-item">
          <a class="nav-link" href="sell.aspx">SELL</a>
                <li class="nav-item">
          <a class="nav-link" href="Rent.aspx">RENT</a>
                    <li class="nav-item">
                        <div id="usertable" runat="server">
                            <a class="nav-link" href="Usertable.aspx">USERTABLE</a>
                        </div>
        </li>
        <li class="nav-item dropdown">
          <a class="nav-link dropdown-toggle" href="#" id="navbarDropdown" role="button" data-bs-toggle="dropdown" aria-expanded="false">
            Dropdown
          </a>
          <ul class="dropdown-menu" aria-labelledby="navbarDropdown">
            <li><a class="dropdown-item" href="#">Action</a></li>
            <li><a class="dropdown-item" href="#">Another action</a></li>
            <li><hr class="dropdown-divider"></li>
            <li><a class="dropdown-item" href="#">Something else here</a></li>
          </ul>
        </li>
        <li class="nav-item">
          <a class="nav-link disabled">Disabled</a>
        </li>
      </ul>
      <form class="d-flex">         
            <%=log %>
      </form>
    </div>
  </div>
</nav>
    <form id="form1" runat="server">
        <div>
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
        </div>
        <div class="footer">
            <h2>Made By Mohmmad Abas</h2>
        </div>
    </form>
</body>
</html>
