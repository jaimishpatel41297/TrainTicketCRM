using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddUser : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
            Binddl();
        }
    }

    private void Binddl()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from DivisionMaster");
            if (dt.Rows.Count > 0)
            {
                ddlDivision.DataTextField = "DivisionName";
                ddlDivision.DataValueField = "Id";
                ddlDivision.DataSource = dt;
                ddlDivision.DataBind();
                ddlDivision.Items.Insert(0, new ListItem("Select Division", "0"));
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
            DataTable dt = D.GetDataTable("select um.*,dm.DivisionName as Divison from Usermaster um left join DivisionMaster dm on um.divisionid=dm.id");
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
        catch { }
    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        string qry = "";
        try
        {
            if (ddlrole.SelectedValue == "Super Admin")
            {
                qry = "insert into UserMaster (Name,MobileNo,UserName,Password,Role) values('" + txtName.Text + "','" + txtno.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + ddlrole.SelectedValue + "')";
            }
            else if (ddlrole.SelectedValue == "DCTI")
            {
                 qry="insert into UserMaster (Name,MobileNo,UserName,Password,Role,DivisionId) values('" + txtName.Text + "','" + txtno.Text + "','" + txtusername.Text + "','" + txtpwd.Text + "','" + ddlrole.SelectedValue + "','" + ddlDivision.SelectedValue + "')";
            }

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

    protected void IbCancel_Click(object sender, EventArgs e)
    {
        Clear();
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
    }

    private void Clear()
    {
        txtName.Text = "";
        txtno.Text = "";
        txtpwd.Text = "";
        txtusername.Text = "";
        ddlDivision.SelectedValue = "0";
        ddlrole.SelectedValue = "0";
    }

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(this.GetType(), "CallMyFunction", "ShowpopupUser()", true);
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from UserMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtno.Text = dt.Rows[0]["MobileNo"].ToString();
            txtusername.Text = dt.Rows[0]["UserName"].ToString();
            txtpwd.Text = dt.Rows[0]["Password"].ToString();
            ddlDivision.SelectedValue = dt.Rows[0]["DivisionId"].ToString();
            ddlrole.SelectedValue = dt.Rows[0]["Role"].ToString();
        }
    }

    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from UserMaster where Id=" + id);

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
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);

        cmd.Connection = cn;

        string qry = "update UserMaster set Name='" + txtName.Text + "',MobileNo='" + txtno.Text + "',UserName='" + txtusername.Text + "',Password='" + txtpwd.Text + "',StationId='" + ddlDivision.SelectedValue + "',Role='" + ddlrole.SelectedValue + "' where Id='" + lbSubmit.CommandArgument + "'";
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
    protected void ddlrole_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlrole.SelectedValue == "Super Admin")
        {
            lbdivision.Visible = false;
            ddlDivision.Visible = false;
        }
        else if (ddlrole.SelectedValue == "DCTI")
        {
            lbdivision.Visible = true;
            ddlDivision.Visible = true;
        }
        else
        {
            lbdivision.Visible = false;
            ddlDivision.Visible = false;
        }
    }
}