<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="week2_cSharp2.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <style>
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }
        nav {
            background-color: #333;
            color: white;
            display: flex;
            justify-content: space-between;
            padding: 10px 20px;
        }
        nav .buttons {
            display: flex;
            gap: 10px;
        }
        nav .buttons button {
            background-color: #007BFF;
            border: none;
            color: white;
            padding: 10px 15px;
            border-radius: 5px;
            cursor: pointer;
        }
        .slider {
            height: 300px;
            background: url('slider-bg.jpg') center/cover no-repeat;
            display: flex;
            justify-content: center;
            align-items: center;
            color: #333;
            font-size: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <nav>
            <div>My Website</div>
            <div class="buttons">
                <button type="button" id="btnSignIn" runat="server">Sign In</button>
                <button type="button" id="btnSignUp" runat="server">Sign Up</button>
            </div>
        </nav>
        <div class="slider">
            <h1>Welcome to My Website</h1>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
