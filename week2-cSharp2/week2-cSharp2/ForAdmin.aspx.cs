using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class ForAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Addbook.aspx");
        }

        protected void Edit1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Editbook.aspx");

        }
    }
}