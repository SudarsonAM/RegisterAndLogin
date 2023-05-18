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
    public partial class Read : System.Web.UI.Page
    {
        
        public readonly SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["UserDetails"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("Login");
            }
            if (!IsPostBack)
            {
                var studentData = ShowAll();
                if (studentData != null)
                {
                    StudentDetails.DataSource = studentData;
                    StudentDetails.DataBind();
                }
               
            }

        }
        public List<Student> ShowAll()
        {
            List<Model.Student> studentData = new List<Model.Student>();
            try
            {
                conn.Open();
                string selectAll = "Select * from Student";
                SqlCommand cmd = new SqlCommand(selectAll, conn);
            
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Model.Student student = new Model.Student();
                    student.Id = Convert.ToInt32(reader["id"]);
                    student.StudentName = reader["StudentName"].ToString();
                    student.Course = reader["Course"].ToString();
                    student.Gender = reader["Gender"].ToString();
                    student.Age = Convert.ToInt32(reader["Age"]);
                    /*Response.Write(student.Id);
                    Response.Write(student.StudentName);
                    Response.Write(student.Course);
                    Response.Write(student.Gender);
                    Response.Write(student.Age);*/
                    studentData.Add(student);
                }
                reader.Close();
                conn.Close();
                return studentData;
            }
            catch(Exception ex) 
            {
                Response.Write(ex.Message);
                return null;
            }
        }
        public void EditDetails(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            int id = Convert.ToInt32(btnEdit.CommandArgument);
            Response.Redirect("Edit?id="+id);
          

        }
        public void DeleteDetails(object sender , EventArgs e)
        {
            
            Button btnDelete = (Button)sender;
            int id = Convert.ToInt32(btnDelete.CommandArgument);
            conn.Open();
            string DeleteAll = "Delete from Student where Id="+id;
            SqlCommand cmd = new SqlCommand(DeleteAll, conn);

            cmd.ExecuteNonQuery();
            Response.Redirect("Read");


        }

        public void Back(object sender, EventArgs e)
        {
            Response.Redirect("Home");



        }
    }
}