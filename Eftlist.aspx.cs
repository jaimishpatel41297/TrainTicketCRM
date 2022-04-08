using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Eftlist : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        string id = Request.QueryString["Id"] != "" ? Request.QueryString["Id"] : "";
        string type = Request.QueryString["type"] != "" ? Request.QueryString["type"] : "";
        if (!IsPostBack)
        {
            if (id != null && type != null)
            {
                GetSquadHeadByType(id, type);
            }
            else if (id != null && id != null)
            {
                GetSquadHead(id);
            }
            else
            {
                GetSquadData();
            }
        }
    }

    private void GetSquadHeadByType(string Id, string type)
    {
        string qry = "";

        qry = "select * from ttmaster where IsSquadHead='true' and Id=" + Id;
        DataTable dt1 = D.GetDataTable(qry);
        if (dt1.Rows.Count > 0)
        {
            ddlselectsqd.DataTextField = "Name";
            ddlselectsqd.DataValueField = "Id";
            ddlselectsqd.DataSource = dt1;
            ddlselectsqd.SelectedValue = Id;
            ddlselectsqd.DataBind();
        }

        if (ddlselectsqd.SelectedValue != "0" && ddlselectsqd.SelectedValue != "")
            qry = "select * from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue;
        else
            qry = "select * from ttmaster where SquadHeadId=" + Id + " or Id=" + Id;

        DataTable dt2 = D.GetDataTable(qry);
        if (dt2.Rows.Count > 0)
        {
            ddlttname.DataTextField = "Name";
            ddlttname.DataValueField = "Id";
            ddlttname.DataSource = dt2;
            ddlttname.SelectedValue = Id;
            ddlttname.DataBind();
            ddlttname.Items.Insert(0, new ListItem("All", "0"));
        }

        BindData();
    }

    private void GetSquadHead(string Id)
    {
        DataTable dt1 = D.GetDataTable("select * from ttmaster where IsSquadHead='true'");
        if (dt1.Rows.Count > 0)
        {
            ddlselectsqd.DataTextField = "Name";
            ddlselectsqd.DataValueField = "Id";
            ddlselectsqd.DataSource = dt1;
            ddlselectsqd.SelectedValue = Id;
            ddlselectsqd.DataBind();
            ddlselectsqd.Items.Insert(0, new ListItem("Select TTSquad", "0"));
        }

        string qry = "";

        if (ddlselectsqd.SelectedValue != "0" && ddlselectsqd.SelectedValue != "")
            qry = "select * from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue;
        else
            qry = "select * from ttmaster where SquadHeadId=" + Id + " or Id=" + Id;

        DataTable dt2 = D.GetDataTable(qry);
        if (dt2.Rows.Count > 0)
        {
            ddlttname.DataTextField = "Name";
            ddlttname.DataValueField = "Id";
            ddlttname.DataSource = dt2;
            ddlttname.DataBind();
            ddlttname.Items.Insert(0, new ListItem("All", "0"));
        }

        BindData();
    }

    private void GetSquadData()
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

                BindData();
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
                {
                    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (select Id from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue + ");";
                }
                else if (ddlttname.SelectedValue != "0")
                {
                    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (" + ddlttname.SelectedValue + ");";
                }
                else if (ddlselectsqd.SelectedValue != "0")
                {
                    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (select Id from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue + ");";
                }

                //else
                //{
                //    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (" + ddlttname.SelectedValue + ");";
                //}


                //if (ddlttname.SelectedValue == "0")
                //    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (select Id from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue + ");";
                //else if (ddlselectsqd.SelectedValue != "0" && ddlttname.SelectedValue != "0")
                //    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (select Id from ttmaster where SquadHeadId=" + ddlselectsqd.SelectedValue + " or Id=" + ddlselectsqd.SelectedValue + ");";
                //else
                //    qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.TTId IN (" + ddlttname.SelectedValue + ");";
            }
            else
            {
                qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id ";
            }
            if (qry != "")
            {
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
    protected void IbInfo_Click(object sender, EventArgs e)
    {
        LinkButton lbs = (LinkButton)sender;
        string ids = lbs.CommandArgument;
        Response.Redirect("ViewDetailEft.aspx?Id=" + ids);
    }
}

