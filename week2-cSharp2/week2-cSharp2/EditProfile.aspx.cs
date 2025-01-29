using System;
using System.Diagnostics;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace week2_cSharp2
{
    public partial class EditProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                //LoadUserData();
            
        }

        private void LoadUserData()
        {
            
                if (Session["UserEmail"] == null)
                {
                    lblMessage.Text = "No user logged in.";
                    return;
                }

                string email = Session["UserEmail"].ToString().Trim().ToLower();
                string filePath = Server.MapPath("~/data/userdata.txt");

                if (!File.Exists(filePath))
                {
                    lblMessage.Text = "User data file not found.";
                    return;
                }

                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] userData = line.Split(' ');

                    if (userData.Length >= 3 && userData[1].Trim().ToLower() == email)
                    {
                        txtName.Text = userData[0];
                        txtPassword.Text = userData[2];

                        // Ensure the gender dropdown is selected properly
                        if (userData.Length > 3)
                        {
                            ListItem selectedGender = ddlGender.Items.FindByValue(userData[3].Trim());
                            if (selectedGender != null)
                            {
                                ddlGender.SelectedValue = selectedGender.Value;
                            }
                        }

                        txtDob.Text = userData.Length > 4 ? userData[4] : "";
                        return;
                    }
                }

                lblMessage.Text = "User not found.";
           
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Session["UserEmail"] == null)
            {
                lblMessage.Text = "No user logged in.";
                return;
            }

            string email = Session["UserEmail"].ToString().Trim().ToLower();
            Debug.WriteLine("Email: " + email);
            string filePath = Server.MapPath("~/data/userdata.txt");

            if (!File.Exists(filePath))
            {
                lblMessage.Text = "User data file not found.";
                return;
            }

            string[] lines = File.ReadAllLines(filePath);
            bool userUpdated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                Debug.WriteLine("User data line: " + lines[i]);

                string[] userData = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (userData.Length >= 3 && userData[1].Trim().ToLower() == email)
                {
                    // Update user data
                    userData[2] = txtPassword.Text;
                    userData[0] = txtName.Text;

                    if (userData.Length > 3)
                    {
                        userData[3] = ddlGender.SelectedValue;
                    }
                    else
                    {
                        Array.Resize(ref userData, 4);
                        userData[3] = ddlGender.SelectedValue;
                    }

                    if (userData.Length > 4)
                    {
                        userData[4] = txtDob.Text.Trim();
                    }
                    else
                    {
                        Array.Resize(ref userData, 5);
                        userData[4] = txtDob.Text.Trim();
                    }

                    // Save updated data back to the array
                    lines[i] = string.Join(" ", userData);

                    //Console.WriteLine("Email: " + email);
                    //Console.WriteLine("User data line: " + line);
                    userUpdated = true;
                    break;
                }
            }

            if (userUpdated)
            {
                File.WriteAllLines(filePath,lines);
                lblMessage.Text = "Profile updated successfully!";
            }
            else
            {
                lblMessage.Text = "User not found.";
            }
        }


        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}
