using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginRegistration
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

     
        }
        protected void CheckLogin(object sender, EventArgs e)
        {
            Error.Text = "";
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
                con.Open();
                string checkcmd = "select Password from Registration where UserName = @username;";
                SqlCommand cmd = new SqlCommand(checkcmd,con);
                cmd.Parameters.AddWithValue("@username",UserName.Text);
                string ans=cmd.ExecuteScalar().ToString();
                if(ans != Password.Text) {
                    Error.Text = Error.Text + "Invalid Password\n";
                }
                else
                {
                    Session["username"] = UserName.Text;
                    Response.Redirect("Home");
                }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}