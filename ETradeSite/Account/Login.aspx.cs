using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Web;
using System.Web.UI;
using ETradeSite;
using System.Data.SqlClient;

public partial class Account_Login : Page
{
    SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-F5538JTD;Initial Catalog=Website;User ID=sa;Password=1234");
    protected void Page_Load(object sender, EventArgs e)
        {
            RegisterHyperLink.NavigateUrl = "Register";
            OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

    protected void LogIn(object sender, EventArgs e)
    {
        string Username = UserName.Text, UserPassword = Password.Text;
        con.Open();
        SqlCommand sqlCommand = new SqlCommand("exec UsersLogin_Sp'" + Username + "','" + UserPassword + "'", con);
        SqlDataReader oku = sqlCommand.ExecuteReader();

        if (oku.Read())
        {
            Session["Kullanici"] = oku["Username"].ToString();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kullanıcı Giriş Başarılı');", true);
            Response.Redirect("../Products.aspx");
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('Kullanıcı Giriş Başarısız');", true);
        }

        con.Close();

    }
}