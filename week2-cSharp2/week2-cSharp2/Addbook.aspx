﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Addbook.aspx.cs" Inherits="week2_cSharp2.Addbook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        label {
            margin-right: 50px;
        }

        .input {
            width: 500px;
        }

        #addBook {
            background-color: black;
            box-shadow: 0.1vw 0.1vw 0.2vw gray;
            border:none;
        }

            #addBook:hover {
                box-shadow: 0.4vw 0.4vw 0.9vw gray;
            }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100" style="background-color: gray;">
                <div class="container h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-xl-9">
                            <h1 class="text-white mb-4">Add A Book</h1>
                            <div class="card" style="border-radius: 15px;">
                                <div class="card-body">
                                    <div class="row align-items-center pt-4 pb-3">
                                        <div class="col-md-3 ps-5">
                                            <h6 class="mb-0">Book ID</h6>
                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="bookId" class="input form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                    <hr class="mx-n3">
                                    <div class="row align-items-center py-3">
                                        <div class="col-md-3 ps-5">
                                            <h6 class="mb-0">Title</h6>
                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="bookTitle" class="input form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                    <hr class="mx-n3">
                                    <div class="row align-items-center py-3">
                                        <div class="col-md-3 ps-5">
                                            <h6 class="mb-0">Author</h6>
                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="Author" class="input form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                    <hr class="mx-n3">
                                    <div class="row align-items-center py-3">
                                        <div class="col-md-3 ps-5">
                                            <h6 class="mb-0">Price</h6>
                                        </div>
                                        <div class="col-md-9 pe-5">
                                            <asp:TextBox runat="server" ID="Price" class="input form-control form-control-lg"></asp:TextBox>
                                        </div>
                                    </div>
                                    <hr class="mx-n3">
                                    <div class="px-5 py-4">
                                        <asp:Button runat="server" ID="addBook" Text="Add Book" data-mdb-button-init data-mdb-ripple-init class="btn btn-primary btn-lg" OnClick="addBook_Click" />
                                    </div>
                                    <asp:Label runat="server" ID="successMsg" Visible="false" Style="color: green;"></asp:Label>
                                    <asp:Label runat="server" ID="msg" Visible="false" Style="color: red;"></asp:Label>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>
</html>
