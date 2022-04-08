using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
public partial class Admin_Default : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
        }

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (ddlUser.SelectedValue == "Super Admin")
        {

            DataTable dt = D.GetDataTable("select * from UserMaster where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'");
            if (dt.Rows.Count > 0)
            {
                Response.Cookies["AdminId"].Value = txtUserName.Text.ToString();
                Session["AdminId"] = "1";
                Response.Redirect("Admindashboard.aspx");
            }
            else
            {
                txtPassword.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Suceess", "alert('Wrong User or Username or Password ');", true);
            }
        }
        else
        {
            DataTable dt = D.GetDataTable("select * from TTMaster where UserName='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'");

            if (dt.Rows.Count > 0)
            {
                Response.Cookies["UserId"].Value = dt.Rows[0]["Id"].ToString();
                Response.Cookies["UserName"].Value = txtUserName.Text.ToString();
                Session["UserId"] = "2";
                Response.Redirect("Userdashboard.aspx");
            }
            else
            {
                txtPassword.Text = "";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Suceess", "alert('Wrong User or Username or Password');", true);
            }
        }
    }
}