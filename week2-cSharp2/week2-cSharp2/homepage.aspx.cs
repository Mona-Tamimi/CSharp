using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class homepage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Code executed on page load
        }

        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            // Handle Sign In button click event
            Response.Redirect("SignIn.aspx");
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            // Handle Sign Up button click event
            Response.Redirect("SignUp.aspx");
        }
    }
}