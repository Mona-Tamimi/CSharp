<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ForStudent.aspx.cs" Inherits="week2_cSharp2.ForStudent" %>

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

        #btnSeeBook, #Button3, #Button2, #Button1 {
            background-color: black;
            box-shadow: 0.1vw 0.1vw 0.2vw gray;
        }

            #btnSeeBook:hover, #Button3:hover, #Button2:hover, #Button1:hover {
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
                    <asp:Button ID="Button3" runat="server" Text="See Books" CssClass="btn btn-primary" OnClick="btnSeeBook_Click" />
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="\img\book.jpg" class="card-img-top" alt="..." />
                <div class="card-body">
                    <h5 class="card-title">Books</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button ID="Button2" runat="server" Text="See Books" CssClass="btn btn-primary" OnClick="btnSeeBook_Click" />
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="\img\book.jpg" class="card-img-top" alt="..." />
                <div class="card-body">
                    <h5 class="card-title">Books</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button ID="Button1" runat="server" Text="See Books" CssClass="btn btn-primary" OnClick="btnSeeBook_Click" />
                </div>
            </div>
            <div class="card" style="width: 18rem;">
                <img src="\img\book.jpg" class="card-img-top" alt="..." />
                <div class="card-body">
                    <h5 class="card-title">Books</h5>
                    <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <asp:Button ID="btnSeeBook" runat="server" Text="See Books" CssClass="btn btn-primary" OnClick="btnSeeBook_Click" />
                </div>
            </div>

        </div>
    </form>
</body>
</html>
