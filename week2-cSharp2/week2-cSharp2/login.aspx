<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="week2_cSharp2.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- Bootstrap 5 CSS -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEJ6A+6TQe6e+YfRfdD1LBzoIqzVpxgZk56rGz8E5l+rUWeLmrRqlnx1k5q+N" crossorigin="anonymous">
    <!-- MDB UI Kit CSS -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.css" />
    <!-- MDB UI Kit JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container vh-100 d-flex justify-content-center align-items-center">
            <div class="card" style="width: 30rem; border-radius: 15px; box-shadow: 0 5px 15px rgba(0, 0, 0, 0.2);">
                <div class="card-body">
                    <h2 class="text-center mb-4">Login</h2>

                    <!-- Email input -->
                    <div class="form-outline mb-4">
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                        <label class="form-label" runat="server" for="txtEmail">Email address</label>
                    </div>

                    <!-- Password input -->
                    <div class="form-outline mb-4">
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <label class="form-label" runat="server" for="txtPassword">Password</label>
                    </div>

                   

                    <!-- Submit button -->
                    <asp:Button ID="btnSignIn" runat="server" Text="Sign in" CssClass="btn btn-primary btn-block mb-4" OnClick="btnSignIn_Click" />

                   
                </div>
            </div>
        </div>
    </form>
</body>
</html>
