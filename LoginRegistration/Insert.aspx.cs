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
    public partial class Insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login");
            }

        }
        public void Add(object sender, EventArgs e)
        {
            //Response.Write(StudentName.Text + " " + Gender.Text +" "+Age.Text+" "+Course.SelectedValue);
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
                conn.Open();
                string insertquery = "Insert into Student Values(@name,@gender,@age,@course);";
                SqlCommand cmd = new SqlCommand(insertquery,conn);
                cmd.Parameters.AddWithValue("@name", StudentName.Text);
                cmd.Parameters.AddWithValue("@gender", Gender.SelectedValue);
                cmd.Parameters.AddWithValue("@age", Int32.Parse(Age.Text));
                cmd.Parameters.AddWithValue("@course", Course.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                Response.Redirect("Read");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}