using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class Seebooks : System.Web.UI.Page
    {
        protected void ViewBooks()
        {
            string file = Server.MapPath("~/data/books.txt");
            string[] books = File.ReadAllLines(file);

            foreach (string book in books)
            {
                // Split book details
                string[] bookData = book.Split(','); // Assume format: "ID Title Author Price"

                // Create a new TableRow
                TableRow row = new TableRow();

                // Add cells for Book ID, Title, Author, and Price
                foreach (string data in bookData)
                {
                    TableCell cell = new TableCell();
                    cell.Text = data; // Set the text of the cell
                    row.Cells.Add(cell); // Add the cell to the row
                }

                // Add the row to the BookTable
                BookTable.Rows.Add(row);
            }
        }
        //{
        //    string file = Server.MapPath("~/data/books.txt");
        //    string[] books = File.ReadAllLines(file);
        //    foreach (string book in books)
        //    {
        //        string[] bookData = book.Split(' ');
        //        BookTable.InnerHtml += $"<asp:TableRow>\r\n" +
        //        $"<asp:TableCell>3</asp:TableCell>\r\n " +
        //            $"<asp:TableCell>Clean Code</asp:TableCell>\r\n" +
        //            $"<asp:TableCell>Robert C. Martin</asp:TableCell>\r\n" +
        //            $"<asp:TableCell>$35.00</asp:TableCell>\r\n " +
        //            $"</asp:TableRow>";
        //    }
        //}
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewBooks();
            }
        }
    }
}