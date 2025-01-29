<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Seebooks.aspx.cs" Inherits="week2_cSharp2.Seebooks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>See Books</title>
    <!-- Bootstrap 5 CSS CDN -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-KyZXEJ6A+6TQe6e+YfRfdD1LBzoIqzVpxgZk56rGz8E5l+rUWeLmrRqlnx1k5q+N" crossorigin="anonymous">
    <style>
        .table-container {
            margin-top: 50px;
            padding: 20px;
            background-color: #f8f9fa;
            border-radius: 10px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }

        .table {
            width: 100%;
            border: 1px solid #dee2e6;
        }

        .table th,
        .table td {
            border: 1px solid #dee2e6;
            text-align: center;
            vertical-align: middle;
        }

        .thead{
            background-color: #343a40;
            color: #ffffff;
        }

        tbody tr:hover {
            background-color: #f1f1f1;
        }

        .table-title {
            margin-bottom: 20px;
            font-size: 24px;
            font-weight: bold;
            text-align: center;
            color: #495057;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container table-container">
            <h2 class="table-title">Book List</h2>
            <asp:Table ID="BookTable" runat="server" CssClass="table table-striped table-bordered">
                <asp:TableHeaderRow CssClass="thead">
                    <asp:TableHeaderCell>Book ID</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Title</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Author</asp:TableHeaderCell>
                    <asp:TableHeaderCell>Price</asp:TableHeaderCell>
                </asp:TableHeaderRow>
            </asp:Table>
        </div>
    </form>
</body>
</html>
