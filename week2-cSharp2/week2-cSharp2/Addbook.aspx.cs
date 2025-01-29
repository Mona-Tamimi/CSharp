using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class Addbook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            string file = Server.MapPath("~/data/books.txt");

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }

            if (string.IsNullOrEmpty(bookId.Text) || string.IsNullOrEmpty(bookTitle.Text) ||
                string.IsNullOrEmpty(Author.Text) || string.IsNullOrEmpty(Price.Text))
            {
                msg.Text = "Please Fill All Feilds!";
                msg.Visible = true;
                return;
            }

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"{bookId.Text},{bookTitle.Text},{Author.Text},{Price.Text}");
            }

            successMsg.Text = "Book Was Added Successfully!";
            successMsg.Visible = true;
        }
    }
}