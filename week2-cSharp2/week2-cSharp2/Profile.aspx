<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="week2_cSharp2.Profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <!-- Bootstrap 5 CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEJ6A+6TQe6e+YfRfdD1LBzoIqzVpxgZk56rGz8E5l+rUWeLmrRqlnx1k5q+N" crossorigin="anonymous">
    <!-- MDB UI Kit CSS CDN (for Material Design) -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.css" />
    <script src="https://cdnjs.cloudflare.com/ajax/libs/mdb-ui-kit/6.3.0/mdb.min.js"></script>

    <style>
        /*body{*/
        /*            align-content:center;
            justify-content:center;*/
        /*background-color:gray;
        }*/
        .profileForm {
            background-color: white;
            box-shadow: 0.4vw 0.4vw 0.9vw gray;
            margin-top: 10vw;
            margin-left: 35vw;
            width: 30vw;
            padding: 1vw 1vw;
            border-radius: 1vw;
        }

        #btnEditProfile {
            background-color: black;
            box-shadow: 0.1vw 0.1vw 0.2vw gray;
            color: white;
            border-radius: 0.2vw;
            height:2vw;
/*            margin-left: 20vw;*/
        }

            #btnEditProfile:hover {
                box-shadow: 0.4vw 0.4vw 0.9vw gray;
                background-color: black;
            }
            .ttt{
                display:flex;
                flex-direction:row;
                justify-content:space-between;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="profileForm">
            <div class="ttt">
                <h2>Your Profile</h2>
                <asp:Button ID="btnEditProfile" runat="server" Text="Edit Profile" OnClick="btnEditProfile_Click" />
            </div>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label><br />

            <p><strong>Name:</strong>
                <asp:Label ID="lblName" runat="server"></asp:Label></p><hr />
            <p><strong>Email:</strong>
                <asp:Label ID="lblEmail" runat="server"></asp:Label></p><hr />
            <p><strong>Password:</strong>
                <asp:Label ID="lblPassword" runat="server"></asp:Label></p><hr />
            <p><strong>Gender:</strong>
                <asp:Label ID="lblGender" runat="server"></asp:Label></p><hr />
            <p><strong>Date of Birth:</strong>
                <asp:Label ID="lblDob" runat="server"></asp:Label></p>

        </div>
    </form>
</body>
</html>





            <%--<div class="mb-3">
                <label for="email" class="form-label">Email address</label>
                <asp:TextBox ID="email" runat="server"  class="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="name" class="form-label">Name</label>
                <asp:TextBox ID="name" runat="server"  class="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="pass" class="form-label">Password</label>
                <asp:TextBox ID="pass" runat="server"  class="form-control"></asp:TextBox>
            </div>
            
            <button type="submit" class="sub btn btn-primary">Submit</button>--%>