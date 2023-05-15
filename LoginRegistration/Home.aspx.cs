using Microsoft.Ajax.Utilities;
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
    public partial class Home : System.Web.UI.Page
    {
        protected readonly SqlConnection conn= new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
        

        public string ConfiurationManager { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["userId"] == null)
            {
                Response.Redirect("Login");
            }
            
        }
        public void CreateText(object sender, EventArgs args)
        {
            Response.Redirect("/Insert");
        }
        public void GoToRead(object sender,EventArgs e)
        {
            Response.Redirect("Read");
        }
    }
}