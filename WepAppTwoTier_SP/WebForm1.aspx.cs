using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WepAppTwoTier_SP
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Save_Click(object sender, EventArgs e)
        {
            try {
                string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                // string cmdstr = "INSERT INTO Employee(Eno, Ename, Salary) VALUES("+id.Text+",'"+Name.Text+"',"+Salary.Text+")";

                SqlConnection Connection = new SqlConnection(ConnectionString);
                //SqlCommand cmd = new SqlCommand(cmdstr, Connection); 
                //cmd.CommandType = CommandType.Text;
                //SqlCommand cmd = new SqlCommand(cmdstr, Connection);

                SqlCommand cmd = new SqlCommand("Procedure_insertEmployee", Connection); // CALL STORED PROCEDURE
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@ename", Name.Text);
                cmd.Parameters.AddWithValue("@salary", Salary.Text);

                Connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    //  Response.Write("<script LANGUAGE='JavaScript'>alert('Data Saved')</script>");
                    Response.Write("<script>alert('login successful');</script>");
                else
                    Response.Write("<script>alert('Not success');</script>");

                Connection.Close();
            }
            catch (Exception obj) {
                Response.Write($"<script>alert('{obj.Message} ');</script>");
            }
            finally {

            }

        }
    }
}