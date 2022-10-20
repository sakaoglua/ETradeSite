using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using ETradeSite;

public partial class Account_Manage : System.Web.UI.Page
{

    protected void Page_Load()
    {
        Session.Clear();
        Response.Redirect("Login.aspx");
    }
}