using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
                    //DropDownList To DropDownList  Cascading
    public partial class WebForm2 : System.Web.UI.Page
    {
        string k = ConfigurationManager.ConnectionStrings["cs"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                getdataDDL();
            }
        }
        protected void DDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(k);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("select name from emps where doj='"+DDD.SelectedItem.Text+"'", con);
               
                /* SqlCommand cmd = new SqlCommand("proc_cascadingg", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@doj", DDD.SelectedItem.Text);*/
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds,"emps");
                DropDownList2.DataSource = ds;
                DropDownList2.DataTextField = "name";
                DropDownList2.DataBind();
                
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
        }
        public void getdataDDL()
        {
            SqlConnection con = new SqlConnection(k);
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("proc_DDL_gett", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "emps");
                DDD.DataSource = ds;
                DDD.DataTextField = "doj";
                DDD.DataValueField = "age";
                DDD.DataBind();
                DDD.Items.Insert(0, "--SELECT--");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

      
    }
}