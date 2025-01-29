using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
                LoadUserData();
            
            //if (Session["UserEmail"] == null)
            //{
            //    lblMessage.Text = "No user logged in. Session is empty.";
            //    return;
            //}
            //else
            //{
            //    lblMessage.Text = "Session is set with: " + Session["UserEmail"].ToString();
            //}
        }
        private void LoadUserData()
        {
           
                if (Session["UserEmail"] == null)
                {
                    lblMessage.Text = "No user logged in.";
                    return;
                }

                string email = Session["UserEmail"].ToString().Trim().ToLower(); // Ensure case-insensitive comparison
                string filePath = Server.MapPath("~/data/userdata.txt");

                if (!File.Exists(filePath))
                {
                    lblMessage.Text = "User data file not found.";
                    return;
                }

                bool userFound = false;
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] userData = line.Split(' ');

                    if (userData.Length == 3 && userData[1].ToLower() == email) // Case-insensitive check
                    {
                        lblEmail.Text = userData[1];
                        lblPassword.Text = userData[2];
                        lblName.Text = userData[0];
                        lblGender.Text = "Not specified"; // Placeholder (unless added to file)
                        lblDob.Text = "Not specified"; // Placeholder (unless added to file)
                        userFound = true;
                        break;
                    }else if (userData.Length > 3 && userData[1].ToLower() == email)
                {
                    lblEmail.Text = userData[1];
                    lblPassword.Text = userData[2];
                    lblName.Text = userData[0];
                    lblGender.Text = userData[3]; // Placeholder (unless added to file)
                    lblDob.Text = userData[4]; // Placeholder (unless added to file)
                    userFound = true;
                    break;
                }
            }

                if (!userFound)
                    lblMessage.Text = "User not found.";
           
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditProfile.aspx");
        }
    }
}