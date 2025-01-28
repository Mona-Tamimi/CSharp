using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace week2_cSharp2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string file = Server.MapPath("~/data/userdata.txt");

            string[] users = File.ReadAllLines(file);
            using (StreamWriter sw = File.CreateText(file))
            {
                sw.WriteLine("admin admin@gmail.com admin123");
            }

            foreach (var user in users)
            {
                string[] userdata = user.Split(' ');

                if (email == "admin@gmail.com" && password == "admin123")
                {
                    Response.Redirect("signUp.aspx");
                }
                else if (email == userdata[1] && password == userdata[2])
                {
                    //Response.Write("<script>alert('Login Succesfully!');</script>");
                    Response.Redirect("ForStudent.aspx");
                    return;
                }
                
            }
              Response.Write("<script>alert('Invalid email or password!');</script>");
              //Response.Redirect("login.aspx");


        }
    }
}