<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchEdit.aspx.cs" Inherits="week2_cSharp2.SearchEdit" %>

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
        #save, #search,#see {
    background-color: black;
    box-shadow: 0.1vw 0.1vw 0.2vw gray;
}

    #search:hover, #save:hover,#see:hover {
        box-shadow: 0.4vw 0.4vw 0.9vw gray;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="ms-3">
                <h4>Edit A Book Information</h4>


                <div class="card-body" id="details">

                    <div class="row align-items-center pt-4 pb-3">
                        <div class="col-md-12 ">

                            <h6 class="mb-2">Search For A Book By Title To Edit:</h6>

                        </div>
                        <br />
                        <div class="col-md-4 pe-3">
                            <asp:TextBox runat="server" ID="bookIdSearch" class="input form-control form-control-lg"></asp:TextBox>

                        </div>
                        <div class="col-md-4 pe-5">
                            <asp:Button runat="server" ID="search" Text="Search" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="search_Click" />
                            <asp:Button runat="server" ID="see" Text="See Books" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="see_Click" />
                        </div>
                    </div>


                    <hr class="mx-n3">

                    <asp:Label runat="server" ID="msg" Visible="false" Style="color: red;"></asp:Label>
                    <!-------------------------------->
                    <div class="row align-items-center py-3">
                        <div class="col-md-3 ps-5">

                            <asp:Label Visible="false" runat="server" ID="id" class="mb-0">Book ID</asp:Label>

                        </div>
                        <div class="col-md-9 pe-5">
                            <asp:TextBox Visible="false" runat="server" ID="bookId" class="input form-control form-control-lg"></asp:TextBox>
                        </div>
                    </div>

                    <div class="row align-items-center py-3">
                        <div class="col-md-3 ps-5">

                            <asp:Label Visible="false" runat="server" ID="name" class="mb-0">Book Title</asp:Label>

                        </div>
                        <div class="col-md-9 pe-5">
                            <asp:TextBox Visible="false" runat="server" ID="bookName" class="input form-control form-control-lg"></asp:TextBox>
                        </div>
                    </div>


                    <div class="row align-items-center py-3">
                        <div class="col-md-3 ps-5">

                            <asp:Label Visible="false" runat="server" ID="type" class="mb-0">Book Author</asp:Label>
                        </div>
                        <div class="col-md-9 pe-5">
                            <asp:TextBox Visible="false" runat="server" ID="bookType" class="input form-control form-control-lg"></asp:TextBox>
                        </div>
                    </div>


                    <div class="row align-items-center py-3">
                        <div class="col-md-3 ps-5">

                            <asp:Label Visible="false" runat="server" ID="level" class="mb-0">Book Price</asp:Label>
                        </div>
                        <div class="col-md-9 pe-5">
                            <asp:TextBox Visible="false" runat="server" ID="bookLevel" class="input form-control form-control-lg"></asp:TextBox>
                        </div>
                    </div>


                    <div class="px-5 py-4">
                        <asp:Button Visible="false" runat="server" ID="save" Text="Save Changes" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="save_Click" />
                    </div>
                    <asp:Label runat="server" ID="successMsg" Visible="false" Style="color: green;"></asp:Label>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
