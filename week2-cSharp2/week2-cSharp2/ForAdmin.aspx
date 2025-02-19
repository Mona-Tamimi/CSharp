﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForAdmin.aspx.cs" Inherits="week2_cSharp2.ForAdmin" %>

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
     .allcards {
         display: flex;
         flex-direction: row;
         justify-content: space-evenly;
         gap: 2vw;
         margin-top: 3vw;
     }

     .card {
         box-shadow: 0.4vw 0.4vw 0.7vw gray;
     }

     body {
         background-color: gainsboro;
     }

     #Add1, #Add2, #Edit1, #Edit2 {
         background-color: black;
         box-shadow: 0.1vw 0.1vw 0.2vw gray;
     }

         #Add1:hover, #Add2:hover, #Edit1:hover, #Edit2:hover {
             box-shadow: 0.4vw 0.4vw 0.9vw gray;
         }
 </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="allcards">
        <div class="card" style="width: 18rem;">
            <img src="\img\book.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
                <h5 class="card-title">Books</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button ID="Add1" runat="server" Text="Add Books" CssClass="btn btn-primary" OnClick="Add1_Click" />
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="\img\book.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
                <h5 class="card-title">Books</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button ID="Add2" runat="server" Text="Add Books" CssClass="btn btn-primary" OnClick="Add1_Click"/>
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="\img\book.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
                <h5 class="card-title">Books</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button ID="Edit1" runat="server" Text="Edit Books" CssClass="btn btn-primary" OnClick="Edit1_Click" />
            </div>
        </div>
        <div class="card" style="width: 18rem;">
            <img src="\img\book.jpg" class="card-img-top" alt="..." />
            <div class="card-body">
                <h5 class="card-title">Books</h5>
                <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                <asp:Button ID="Edit2" runat="server" Text="Edit Books" CssClass="btn btn-primary" OnClick="Edit1_Click" />
            </div>
        </div>

    </div>
</form>
</body>
</html>
