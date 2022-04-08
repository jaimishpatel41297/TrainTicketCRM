using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Eftticketlist : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Bindddl();
        }
    }
    private void Bindddl()
    {
        try
        {
            DataTable dt1 = D.GetDataTable("select * from ttmaster where IsSquadHead='true'");
            if (dt1.Rows.Count > 0)
            {
                ddlselectsqd.DataTextField = "Name";
                ddlselectsqd.DataValueField = "Id";
                ddlselectsqd.DataSource = dt1;
                ddlselectsqd.DataBind();
                ddlselectsqd.Items.Insert(0, new ListItem("Select TTSquad", "0"));
            }
        }
        catch (Exception e1)
        {
            Response.Write("<script>alert(" + e1.Message + ")</script>");
        }
    }
    private void BindData()
    {
        try
        {
            string qry = "";
            if (ddlselectsqd.SelectedValue != "0")
            {
                if (ddlttname.SelectedValue == "0")
                    qry = "select distinct em.*,tt.Name as ttname from ExcessFairRecieptMaster em,TTMaster tt where em.TTId=tt.Id and em.TTId IN (select Id from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue + ");";
                else
                    qry = "select distinct em.*,tt.Name as ttname from ExcessFairRecieptMaster em,TTMaster tt where em.TTId=tt.Id and em.TTId IN (" + ddlttname.SelectedValue + ");";
            }

            DataTable dt = D.GetDataTable(qry);
            if (dt.Rows.Count > 0)
            {
                gv.DataSource = dt;
                gv.DataBind();
            }
            else
            {
                dt = null;
                gv.DataSource = dt;
                gv.DataBind();
            }
        }
        catch (Exception ex)
        {
        }
    }
    protected void ddlselectsqd_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataTable dt1 = D.GetDataTable("select * from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue);
            if (dt1.Rows.Count > 0)
            {
                ddlttname.DataTextField = "Name";
                ddlttname.DataValueField = "Id";
                ddlttname.DataSource = dt1;
                ddlttname.DataBind();
                ddlttname.Items.Insert(0, new ListItem("All", "0"));
                BindData();
            }
            else
            {
                ddlttname.Items.Clear();
                BindData();
            }
        }
        catch (Exception e1)
        {

        }
    }
    protected void ddlttname_SelectedIndexChanged(object sender, EventArgs e)
    {
        BindData();
    }
}
