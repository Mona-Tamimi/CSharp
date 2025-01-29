<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="week2_cSharp2.EditProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: Arial, sans-serif;
/*            margin: 50px;*/
        }

        .container {
            max-width: 30vw;
            padding: 20px;
            border: 1px solid #ddd;
            border-radius: 8px;
            box-shadow: 2px 2px 10px rgba(0,0,0,0.1);
            margin-left: 30vw;
/*            max-height:50vw !important;*/
        }

        label {
            font-weight: bold;
            display: block;
            margin-top: 10px;
        }

        input, select {
            width: 100%;
            padding: 8px;
            margin-top: 5px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }

        .btn {
            color: white;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            margin-top: 1vw;
            background-color: black;
            box-shadow: 0.1vw 0.1vw 0.2vw gray;
        }

            .btn:hover {
                box-shadow: 0.4vw 0.4vw 0.9vw gray;
            }

        #lblMessage {
            color: red;
            margin-top: 1vw;
        }

        .back-btn {
            background-color: gray;
            margin-top: 1vw;
        }

            .back-btn:hover {
                box-shadow: 0.4vw 0.4vw 0.9vw gray;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Edit Profile</h2>

            <label for="txtName">Name:</label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>

            <label for="txtPassword">Password:</label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

            <label for="ddlGender">Gender:</label>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="Select Gender" Value=""></asp:ListItem>
                <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
            </asp:DropDownList>

            <label for="txtDob">Date of Birth:</label>
            <asp:TextBox ID="txtDob" runat="server" TextMode="Date"></asp:TextBox>

            <asp:Button ID="btnSave" runat="server" Text="Save Changes" CssClass="btn" OnClick="btnSave_Click" />
            <asp:Button ID="btnBack" runat="server" Text="Back to Profile" CssClass="btn back-btn" OnClick="btnBack_Click" />

            <asp:Label ID="lblMessage" runat="server" CssClass="message"></asp:Label>
        </div>
    </form>
</body>
</html>
