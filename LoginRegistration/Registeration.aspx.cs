using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class Registeration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*login.Attributes.Add("onclick", "__doPostBack('" + login.UniqueID + "', '')");*/
        }
        public void Register(object sender,EventArgs e)
        {
            Comment.Text = "";
            if (Password.Text != ConfirmPassword.Text)
            {
                Comment.Text = "The Password and Confirm Passord doesn't match\n";

            }
            else 
            {
                try
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
                    con.Open();
                    
                    try
                    {
                        string checkusername = "select UserName from Registration where UserName = @username;";
                        SqlCommand cmd1 = new SqlCommand(checkusername, con);
                        cmd1.Parameters.AddWithValue("@username", UserName.Text);
                        var ans = cmd1.ExecuteScalar();
                        if (ans != null)
                        {
                            Comment.Text = "Give a unique username";

                        }
                        /*if (ans != "")
                        {
                            Comment.Text = "Give a unique username";
                        }*/
                        else
                        {
                            string insert = "insert into Registration (UserName, Password, Email) Values (@username, @password, @email); ";
                            SqlCommand cmd = new SqlCommand(insert, con);
                            cmd.Parameters.AddWithValue("@username", UserName.Text);
                            cmd.Parameters.AddWithValue("@password", Password.Text);
                            cmd.Parameters.AddWithValue("@email", Email.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            Response.Redirect("Login");
                        }
                    }
                    catch(NullReferenceException ex)
                    {
                        string insert = "insert into Registration (UserName, Password, Email, IsActive) Values (@username, @password, @email, 0); ";
                        SqlCommand cmd = new SqlCommand(insert, con);
                        cmd.Parameters.AddWithValue("@username", UserName.Text);
                        cmd.Parameters.AddWithValue("@password", Password.Text);
                        cmd.Parameters.AddWithValue("@email", Email.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Response.Redirect("Login");

                    }
                    
                }
                catch (Exception ex)
                {
                    Comment.Text = ex.Message;
                }
            }

        }

    }
}