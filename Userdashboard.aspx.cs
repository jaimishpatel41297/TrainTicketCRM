using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Userdashboard : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    HttpCookie cookie;
    protected void Page_Load(object sender, EventArgs e)
    {
        cookie = Request.Cookies["UserId"];
        if (cookie != null)
        {
            if (!IsPostBack)
            {
                Binddata();
            }
        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    private void Binddata()
    {

        string str = "";
        string id = cookie.Value.ToString();
        DataTable dt = D.GetDataTable("select *,(select dbo.fnGetTTEFTAmountById(id)) as amount from ttmaster where SquadHeadId='" + id + "' or Id='" + id + "'");

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                //Response.Cookies["getuser"].Value = dt.Rows[i]["Id"].ToString();
                //Response.Cookies["type"].Value = "user";
                str += " <a href='Eftlist.aspx?Id=" + dt.Rows[i]["Id"].ToString() + "&type=user'>" +
                 "<div class='col-lg-4 col-sm-4 col-xs-12'>" +
                                  "<div class='white-box'>" +
                                      "<h3 class='box-title'>" + dt.Rows[i]["Name"].ToString() + "</h3>" +
                                      "<ul class='list-inline two-part'>" +
                                          "<li class='text-right'><span class='counter'>" + dt.Rows[i]["amount"] + "</span></li>" +
                                   "   </ul>" +
                                  "</div>" +
                           "   </div>" +
                          "</a>";
            }
            ltrreturn1.Text = str;
        }

    }
}