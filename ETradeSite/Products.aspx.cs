using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F5538JTD;Initial Catalog=Website;User ID=sa;Password=1234");
    protected void Page_Load(object sender, EventArgs e)
    {
        con.Open();
        if (Session["Kullanici"]==null)
        {
            Response.Redirect("Account/Login.aspx");
        }
        else
        {

            GetList();
        }
        con.Close();
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
      
        string productname = TextBox2.Text,productdescription = TextBox3.Text;
        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec Products_Sp'" + productname + "','" + productdescription + "'",con);
        sqlCommand.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kayıt başarılı');",true);
        GetList();
    }
    void GetList()
    {
        SqlCommand sqlCommand = new SqlCommand("exec ProductList_Sp", con);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);
        GridView1.DataSource = dataTable;
        GridView1.DataBind();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        int productid = int.Parse(TextBox1.Text);
        string productname = TextBox2.Text, productdescription = TextBox3.Text;
        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec ProductsUpdate_Sp'" + productid + "','" + productname + "','" + productdescription + "'", con);
        sqlCommand.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Güncelleme başarılı');", true);
        GetList();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        int productid = int.Parse(txt_ara.Text);
        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec ProductsDelete_Sp'" + productid + "'" , con);
        sqlCommand.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kayıt silindi.');", true);
        GetList();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        string productName = txt_ara.Text;

        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec ProductsSearch_Sp'" + productName + "'", con);
        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
        DataTable dataTable = new DataTable();
        dataAdapter.Fill(dataTable);
        GridView1.DataSource = dataTable;
        GridView1.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        
    }
}