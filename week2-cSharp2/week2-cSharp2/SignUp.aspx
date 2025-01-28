<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="week2_cSharp2.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sign Up</title>
   <!-- Bootstrap 5 CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEJ6A+6TQe6e+YfRfdD1LBzoIqzVpxgZk56rGz8E5l+rUWeLmrRqlnx1k5q+N" crossorigin="anonymous">
    <!-- MDB UI Kit CSS CDN (for Material Design) -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.js"></script>
    <style>
        body, html {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <section class="vh-100 bg-image"
            style="background-image: url('https://mdbcdn.b-cdn.net/img/Photos/new-templates/search-box/img4.webp');">
            <div class="mask d-flex align-items-center h-100 gradient-custom-3">
                <div class="container h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-12 col-md-9 col-lg-7 col-xl-6">
                            <div class="card" style="border-radius: 15px;">
                                <div class="card-body p-5">
                                    <h2 class="text-uppercase text-center mb-5">Create an account</h2>

                                    <asp:Panel ID="SignUpForm" runat="server">
                                        <div  class="form-outline mb-4">
                                            <asp:TextBox ID="txtName" CssClass="form-control form-control-lg" runat="server" placeholder="Your Name"></asp:TextBox>
                                            <label class="form-label" for="txtName">Your Name</label>
                                        </div>

                                        <div  class="form-outline mb-4">
                                            <asp:TextBox ID="txtEmail" CssClass="form-control form-control-lg" runat="server" TextMode="Email" placeholder="Your Email"></asp:TextBox>
                                            <label class="form-label" for="txtEmail">Your Email</label>
                                        </div>

                                        <div  class="form-outline mb-4">
                                            <asp:TextBox ID="txtPassword" CssClass="form-control form-control-lg" runat="server" TextMode="Password" placeholder="Password"></asp:TextBox>
                                            <label class="form-label" for="txtPassword">Password</label>
                                        </div>

                                        <div  class="form-outline mb-4">
                                            <asp:TextBox ID="txtRepeatPassword" CssClass="form-control form-control-lg" runat="server" TextMode="Password" placeholder="Repeat your password"></asp:TextBox>
                                            <label class="form-label" for="txtRepeatPassword">Repeat your password</label>
                                        </div>

                                        <div class="form-check d-flex justify-content-center mb-5">
                                            <asp:CheckBox ID="chkTerms" CssClass="form-check-input me-2" runat="server" />
                                            <label class="form-check-label" for="chkTerms">
                                                I agree to all statements in <a href="#!" class="text-body"><u>Terms of service</u></a>
                                            </label>
                                        </div>

                                        <div class="d-flex justify-content-center">
                                            <asp:Button ID="btnRegister" CssClass="btn btn-success btn-block btn-lg gradient-custom-4 text-body" runat="server" Text="Register" OnClick="btnRegister_Click" />
                                        </div>

                                        <p class="text-center text-muted mt-5 mb-0">Have an account? <a href="SignIn.aspx" class="fw-bold text-body"><u>Login here</u></a></p>
                                    </asp:Panel>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>
