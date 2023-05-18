using LoginRegistration.Model;
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
    public partial class Edit : System.Web.UI.Page
    {
        protected int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var studentData = getstudentData();
                StudentName.Text = studentData.StudentName;
                Gender.SelectedValue = studentData.Gender;
                Age.Text = studentData.Age.ToString();
                Course.SelectedValue = studentData.Course;
            }
        }
        public Student getstudentData() {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
            conn.Open();
            var x = Request.QueryString["id"];
            if (x != null)
            {
                try
                {
                    id = Convert.ToInt32(x);
                    string getDetail = "Select * from Student where Id=" + id;
                    SqlCommand cmd = new SqlCommand(getDetail, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader != null)
                    {
                        Student student = new Student();
                        while (reader.Read())
                        {
                             
                            student.Id = Convert.ToInt32(reader["id"]);
                            student.StudentName = reader["StudentName"].ToString();
                            student.Gender = reader["Gender"].ToString();
                            student.Age = Convert.ToInt32(reader["Age"].ToString());
                            student.Course = reader["Course"].ToString();

                        }


                        reader.Close();
                        conn.Close();
                        return student;
                      
                    }
                    else
                    {
                        conn.Close();
                        return null;
                    }
                    

                }
                catch
                {
                    conn.Close();
                    Response.Write("error");
                    return null;
                }
            }
            else
            {
                conn.Close();
                Response.Redirect("Login");
                return null;
            }
            
        }
        public void edit(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
            con.Open();
            id = Convert.ToInt32(Request.QueryString["id"]);    
            string update = "Update Student Set StudentName = '" + StudentName.Text + "', Gender = '" + Gender.SelectedValue + "', Age = " + Convert.ToInt32(Age.Text) + ", Course = '" + Course.SelectedValue + "' where Id = "+id+";";
            SqlCommand cmd1 = new SqlCommand(update,con);
          
            cmd1.ExecuteNonQuery();
            //Response.Write(update);
            Response.Redirect("Read");
        }
    }
}