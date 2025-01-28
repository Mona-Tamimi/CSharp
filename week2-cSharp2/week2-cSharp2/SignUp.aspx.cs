using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string repeatPassword = txtRepeatPassword.Text;

            if (password == repeatPassword && name != "" && email != "")
            {
                string file = Server.MapPath("data/userdata.txt");

                if (!File.Exists(file))
                {
                    using (StreamWriter sw = File.CreateText(file))
                    {


                        sw.WriteLine($"{name} {email} {password}");


                    }
                }
                else
                {

                    using (StreamWriter sw = new StreamWriter(file, true))
                    {

                        sw.WriteLine($"{name} {email} {password}");

                    }


                }
                    Response.Redirect("login.aspx");


            }
        }
    }
}