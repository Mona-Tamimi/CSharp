using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace week2_cSharp2
{
    public partial class SearchEdit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void search_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(bookIdSearch.Text))
            {
                msg.Text = "Please Enter A Book ID";
                msg.Visible = true;
                return;
            }
            else
            {
                msg.Visible = false;
            }

            string file = Server.MapPath("~/data/books.txt");
            string[] books = File.ReadAllLines(file);
            bool bookFound = false;
            foreach (string book in books)
            {
                string[] bookDetails = book.Split(',');
                if (bookDetails[1] == bookIdSearch.Text)
                {

                    id.Visible = true;
                    name.Visible = true;
                    type.Visible = true;
                    level.Visible = true;

                    bookId.Text = bookDetails[0];
                    bookId.Visible = true;

                    bookName.Text = bookDetails[1];
                    bookName.Visible = true;

                    bookType.Text = bookDetails[2];
                    bookType.Visible = true;

                    bookLevel.Text = bookDetails[3];
                    bookLevel.Visible = true;

                    save.Visible = true;
                    bookFound = true;
                    break;
                }
            }
            if (!bookFound)
            {
                msg.Text = "Book not found.";
                msg.Visible = true;
                return;
            }
        }

        protected void save_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/data/books.txt");
            string[] books = File.ReadAllLines(file);
            foreach (string book in books)
            {
                string[] bookDetails = book.Split(',');
                if (bookDetails[1] == bookIdSearch.Text)
                {
                    bookDetails[0] = bookId.Text;

                    bookDetails[1] = bookName.Text;

                    bookDetails[2] = bookType.Text;

                    bookDetails[3] = bookLevel.Text;

                    books[Array.IndexOf(books, book)] = $"{bookDetails[0]},{bookDetails[1]},{bookDetails[2]},{bookDetails[3]}";

                    File.WriteAllLines(file, books);

                    successMsg.Text = "Saved! :)";
                    successMsg.Visible = true;

                    bookId.Text = "";
                    bookName.Text = "";
                    bookType.Text = "";
                    bookLevel.Text = "";
                    bookIdSearch.Text = "";
                }
            }
        }

        protected void see_Click(object sender, EventArgs e)
        {
            Response.Redirect("Seebooks.aspx");
        }
    }
}