using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddEft : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            Bindtt();
        }
    }

    private void Bindtt()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from TTMaster");
            if (dt.Rows.Count > 0)
            {
                ddltt.DataTextField = "Name";
                ddltt.DataValueField = "Id";
                ddltt.DataSource = dt;
                ddltt.DataBind();
                ddltt.Items.Insert(0, new ListItem("Select TT Name", "0"));
            }
            DataTable dt1 = D.GetDataTable("select * from chargereasonmaster");
            if (dt1.Rows.Count > 0)
            {
                ddlreson.DataTextField = "Name";
                ddlreson.DataValueField = "Id";
                ddlreson.DataSource = dt1;
                ddlreson.DataBind();
                ddlreson.Items.Insert(0, new ListItem("Select Reason", "0"));
            }
            DataTable dt2 = D.GetDataTable("select * from trainclassmaster");
            if (dt2.Rows.Count > 0)
            {
                ddlclass.DataTextField = "ClassName";
                ddlclass.DataValueField = "Id";
                ddlclass.DataSource = dt2;
                ddlclass.DataBind();
                ddlclass.Items.Insert(0, new ListItem("Select Class", "0"));

                ddlavailcls.DataTextField = "ClassName";
                ddlavailcls.DataValueField = "Id";
                ddlavailcls.DataSource = dt2;
                ddlavailcls.DataBind();
                ddlavailcls.Items.Insert(0, new ListItem("Select Class", "0"));
            }
        }
        catch (Exception e1)
        {

        }
    }

    private void BindData()
    {
        try
        {
            string qry = "";
            qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id ";

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
    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from ExcessFairMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtdate.Text = dt.Rows[0]["Date"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["Date"].ToString()).ToString("yyyy-MM-dd") : "";
            txteftno.Text = dt.Rows[0]["EFTNo"].ToString();
            txtclton.Text = dt.Rows[0]["CollectedOn"].ToString();
            txttrainno.Text = dt.Rows[0]["TrainNo"].ToString();
            txtfrmst.Text = dt.Rows[0]["FromStation"].ToString();
            txttost.Text = dt.Rows[0]["ToStation"].ToString();
            txtticketno.Text = dt.Rows[0]["TicketNo"].ToString();
            txtweight.Text = dt.Rows[0]["Weight"].ToString();
            txtweightcrg.Text = dt.Rows[0]["WeightCharge"].ToString();
            txtfaramt.Text = dt.Rows[0]["FareAmount"].ToString();
            txtexcchrg.Text = dt.Rows[0]["ExcessCharge"].ToString();
            txttlt.Text = dt.Rows[0]["Total"].ToString();
            txtcgst.Text = dt.Rows[0]["CGST"].ToString();
            txtsgst.Text = dt.Rows[0]["SGST"].ToString();
            txtigst.Text = dt.Rows[0]["IGST"].ToString();
            txtugst.Text = dt.Rows[0]["UGST"].ToString();
            txttltgst.Text = dt.Rows[0]["TotalwithGST"].ToString();
            txtstname.Text = dt.Rows[0]["StationName"].ToString();
            txtpassname.Text = dt.Rows[0]["Passengers"].ToString();
            txtavailfrm.Text = dt.Rows[0]["AvlFromStation"].ToString();
            txtavailto.Text = dt.Rows[0]["AvlToStation"].ToString();
            ddlavailcls.SelectedValue = dt.Rows[0]["AvlClassId"] != System.DBNull.Value ? dt.Rows[0]["AvlClassId"].ToString() : "0";
            ddlreson.SelectedValue = dt.Rows[0]["ReasonId"].ToString();
            ddltt.SelectedValue = dt.Rows[0]["TTId"].ToString();
            ddlclass.SelectedValue = dt.Rows[0]["ClassId"].ToString();
        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from ExcessFairMaster where Id=" + id);

            divSuccess.Visible = true;
            divError.Visible = false;

            BindData();
        }
        catch (Exception ex)
        {
            divError.Visible = true;
            divSuccess.Visible = false;
        }
    }
    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        try
        {

            string qry = "insert into ExcessFairMaster (Date,EFTNo,CollectedOn,TrainNo,FromStation,ToStation,TicketNo,Weight,WeightCharge,FareAmount,ExcessCharge,Total,CGST,SGST,IGST,UGST,TotalwithGST,StationName,Passengers,AvlFromStation,AvlToStation,AvlClassId,ReasonId,TTId,ClassId,Ismodified) values('" + txtdate.Text + "','" + txteftno.Text + "','" + txtclton.Text + "','" + txttrainno.Text + "','" + txtfrmst.Text + "','" + txttost.Text + "','" + txtticketno.Text + "','" + txtweight.Text + "','" + txtweightcrg.Text + "','" + txtfaramt.Text + "','" + txtexcchrg.Text + "','" + txttlt.Text + "','" + txtcgst.Text + "','" + txtsgst.Text + "','" + txtigst.Text + "','" + txtugst.Text + "','" + txttltgst.Text + "','" + txtstname.Text + "','" + txtpassname.Text + "','" + txtavailfrm.Text + "','" + txtavailto.Text + "','" + ddlavailcls.SelectedValue + "','" + ddlreson.SelectedValue + "','" + ddltt.SelectedValue + "','" + ddlclass.SelectedValue + "','" + 0 + "')";

            D.ExecuteQuery(qry);

            BindData();
            Clear();
            divSuccess.Visible = true;
            divError.Visible = false;
        }
        catch (Exception ex)
        {
            divSuccess.Visible = false;
            divError.Visible = true;
        }
    }

    private void Clear()
    {
        txtdate.Text = "";
        txteftno.Text = "";
        txtclton.Text = "";
        txttrainno.Text = "";
        txtfrmst.Text = "";
        txttost.Text = "";
        txtticketno.Text = "";
        txtweight.Text = "";
        txtweightcrg.Text = "";
        txtfaramt.Text = "";
        txtexcchrg.Text = "";
        txttlt.Text = "";
        txtcgst.Text = "";
        txtsgst.Text = "";
        txtigst.Text = "";
        txtugst.Text = "";
        txttltgst.Text = "";
        txtstname.Text = "";
        txtpassname.Text = "";
        txtavailfrm.Text = "";
        txtavailto.Text = "";
        ddlavailcls.SelectedValue = "0";
        ddlreson.SelectedValue = "0";
        ddltt.SelectedValue = "0";
        ddlclass.SelectedValue = "0";
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);

        string qry = "update ExcessFairMaster set Date='" + txtdate.Text + "',EFTNo='" + txteftno.Text + "',CollectedOn='" + txtclton.Text + "',TrainNo='" + txttrainno.Text + "',FromStation='" + txtfrmst.Text + "',ToStation='" + txttost.Text + "',TicketNo='" + txtticketno.Text + "',Weight='" + txtweight.Text + "',WeightCharge='" + txtweightcrg.Text + "',FareAmount='" + txtfaramt.Text + "',ExcessCharge='" + txtexcchrg.Text + "',Total='" + txttlt.Text + "',CGST='" + txtcgst.Text + "',SGST='" + txtsgst.Text + "',IGST='" + txtigst.Text + "',UGST='" + txtugst.Text + "',TotalwithGST='" + txttltgst.Text + "',StationName='" + txtstname.Text + "',Passengers='" + txtpassname.Text + "',AvlFromStation='" + txtavailfrm.Text + "',AvlToStation='" + txtavailto.Text + "',AvlClassId='" + ddlavailcls.SelectedValue + "',ReasonId='" + ddlreson.SelectedValue + "',TTId='" + ddltt.SelectedValue + "',ClassId='" + ddlclass.SelectedValue + "',Ismodified='" + 1 + "',ModifiedDate='" + DateTime.Now.ToString("yyyy-MM-dd") + "' where Id='" + lbSubmit.CommandArgument + "'";

        D.ExecuteQuery(qry);
        BindData();
        Clear();
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
        divSuccess.Visible = true;
        divError.Visible = false;
    }
    protected void lbCancel_Click(object sender, EventArgs e)
    {
        Clear();
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
    }
    protected void IbInfo_Click(object sender, EventArgs e)
    {
        LinkButton lbs = (LinkButton)sender;
        string ids = lbs.CommandArgument;
        Response.Redirect("ViewDetailEft.aspx?Id=" + ids);
    }
}