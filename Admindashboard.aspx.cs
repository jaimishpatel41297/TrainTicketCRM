 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Admindashboard : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Binddata();
        }
    }

    private void Binddata()
    {
        string str = "";

        DataTable dt = D.GetDataTable("select *,(select dbo.fnGetTTEFTAmount(id)) as amount from ttmaster where issquadhead = 1");

        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str += " <a href='Eftlist.aspx?Id=" + dt.Rows[i]["Id"].ToString() + "'>" +
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
            ltrreturn.Text = str;
        }

    }
}