using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Default2 : System.Web.UI.Page
{
    SqlConnection sqlcon = new SqlConnection("Server=cec85cc5-243b-4766-8119-a4ec008aea52.sqlserver.sequelizer.com;Database=dbcec85cc5243b47668119a4ec008aea52;User ID=badsichpmartsezn;Password=saPchdsvmBEo4UPUkqENPeDTNWiExu2txT7VFehaPUEYJdPSs4KBNqYnD5wt4V7Y;");
    SqlCommand cmd = new SqlCommand();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

            insertdata();
        }

    }
    public void insertdata()
    {

        

        cmd = new SqlCommand("insert into mytbl(name , address) values('" + Request.QueryString["name"].ToString() + "' , '" + Request.QueryString["address"].ToString()+ "')", sqlcon);
        sqlcon.Open();
        cmd.ExecuteNonQuery();
        sqlcon.Close();
        Response.Write("data saved....");

    }

}