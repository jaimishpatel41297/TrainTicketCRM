using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Addtalist : System.Web.UI.Page
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
            qry = "select distinct ta.*,tt.Name as ttname from TAMaster ta,TTMaster tt where ta.TTId=tt.Id ";

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
        DataTable dt = D.GetData("select * from TAMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtdate.Text = dt.Rows[0]["Date"] != System.DBNull.Value ? Convert.ToDateTime(dt.Rows[0]["Date"].ToString()).ToString("yyyy-MM-dd") : "";
            txtfrm.Text = dt.Rows[0]["FromStation"].ToString();
            txtoff.Text = dt.Rows[0]["TimeLeft"].ToString();
            txton.Text = dt.Rows[0]["TimeArrived"].ToString();
            txtto.Text = dt.Rows[0]["ToStation"].ToString();
            txtre.Text = dt.Rows[0]["Remark"].ToString();
            txttno.Text = dt.Rows[0]["TrainNo"].ToString();
            txtper.Text = dt.Rows[0]["Pecentage"].ToString();
            ddltt.SelectedValue = dt.Rows[0]["TTId"].ToString();
        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from TAMaster where Id=" + id);

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
            DateTime t1 = Convert.ToDateTime(txtoff.Text);
            DateTime t2 = Convert.ToDateTime(txton.Text);
            TimeSpan ts = t1.Subtract(t2);

            //DateTime dTo = Convert.ToDateTime(txtoff.Text);
            //DateTime dFrom = Convert.ToDateTime(txton.Text);

            //int timeDiff = dFrom.Subtract(dTo).Hours;

            txtper.Text = ts.ToString();

            //string qry = "insert into TAMaster (Date,TrainNo,FromStation,ToStation,TimeArrived,TimeLeft,Remark,TTId,Pecentage) values('" + txtdate.Text + "','" + txttno.Text + "','" + txtfrm.Text + "','" + txtto.Text + "','" + txton.Text + "','" + txtoff.Text + "','" + txtre.Text + "','" + ddltt.SelectedValue + "','" + txtper.Text + "')";

            //D.ExecuteQuery(qry);

            BindData();
            //Clear();
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
        txttno.Text = "";
        txtfrm.Text = "";
        txtoff.Text = "";
        txton.Text = "";
        txtto.Text = "";
        txtre.Text = "";
        txtper.Text = "";
        ddltt.SelectedValue = "0";
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);
        DateTime t1 = Convert.ToDateTime(txtoff.Text);
        DateTime t2 = Convert.ToDateTime(txton.Text);
        TimeSpan ts = t1.Subtract(t2);
        cmd.Connection = cn;

        string qry = "update TAMaster set Date='" + txtdate.Text + "',TrainNo='" + txttno.Text + "',FromStation='" + txtfrm.Text + "',ToStation='" + txtto.Text + "',TimeArrived='" + txton.Text + "',TimeLeft='" + txtoff.Text + "',Remark='" + txtre.Text + "',TTId='" + ddltt.SelectedValue + "',Pecentage='" + txtper.Text + "' where Id='" + lbSubmit.CommandArgument + "'";
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