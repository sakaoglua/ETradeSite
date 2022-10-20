using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using ETradeSite;
using System.Data.SqlClient;

public partial class Account_Register : Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F5538JTD;Initial Catalog=Website;User ID=sa;Password=1234");
    protected void RegisterSave_Click(object sender, EventArgs e)
    {
        string Username = UserName.Text, UserPassword = Password.Text;
        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec UsersRegister_Sp'" + Username + "','" + UserPassword + "'", con);
        sqlCommand.ExecuteNonQuery();
        con.Close();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kullanıcı Kayıt başarılı');", true);
        Response.Redirect("Login.aspx");
    }
}