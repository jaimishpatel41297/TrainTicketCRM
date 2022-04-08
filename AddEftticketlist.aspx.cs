using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addeftticketlist : System.Web.UI.Page
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
            qry = "select distinct em.*,tt.Name as ttname from ExcessFairRecieptMaster em,TTMaster tt where em.TTId=tt.Id ";

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
        DataTable dt = D.GetData("select * from ExcessFairRecieptMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtdate.Text = dt.Rows[0]["Date"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["Date"].ToString()).ToString("yyyy-MM-dd") : "";
            txtstname.Text = dt.Rows[0]["StationName"].ToString();
            txtmr.Text = dt.Rows[0]["MRNo"].ToString();
            txtamt.Text = dt.Rows[0]["Amount"].ToString();
            txtutsno.Text = dt.Rows[0]["UTSNo"].ToString();
            txtfrmeft.Text = dt.Rows[0]["FromEFTNo"].ToString();
            txttoeft.Text = dt.Rows[0]["ToEFTNo"].ToString();
            txtre.Text = dt.Rows[0]["Remark"].ToString();
            ddltt.SelectedValue = dt.Rows[0]["TTId"].ToString();
        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from ExcessFairRecieptMaster where Id=" + id);

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
            string qry = "insert into ExcessFairRecieptMaster (Date,StationName,MRNo,Amount,UTSNo,FromEFTNo,ToEFTNo,Remark,TTId) values('" + txtdate.Text + "','" + txtstname.Text + "','" + txtmr.Text + "','" + txtamt.Text + "','" + txtutsno.Text + "','" + txtfrmeft.Text + "','" + txttoeft.Text + "','" + txtre.Text + "','" + ddltt.SelectedValue + "')";

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
        txtstname.Text = "";
        txtmr.Text = "";
        txtamt.Text = "";
        txtutsno.Text = "";
        txtfrmeft.Text = "";
        txttoeft.Text = "";
        txtre.Text = "";
        ddltt.SelectedValue = "0";
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);
        cmd.Connection = cn;
        string qry = "update ExcessFairRecieptMaster set Date='" + txtdate.Text + "',StationName='" + txtstname.Text + "',MRNo='" + txtmr.Text + "',Amount='" + txtamt.Text + "',UTSNo='" + txtutsno.Text + "',FromEFTNo='" + txtfrmeft.Text + "',ToEFTNo='" + txttoeft.Text + "',Remark='" + txtre.Text + "',TTId='" + ddltt.SelectedValue + "' where Id='" + lbSubmit.CommandArgument + "'";
        cmd.CommandText = qry;
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
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
 
}