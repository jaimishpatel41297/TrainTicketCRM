using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddTTDetail : System.Web.UI.Page
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

    private void BindData()
    {
        try
        {
            DataTable dt = D.GetDataTable("select tt.*,(select Name from TTMaster where Id=tt.SquadHeadId) as TTSquadName,sm.StationName as station from TTMaster as tt, StationMaster as sm where tt.StationId=sm.Id");
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
        catch (Exception e1) { }
    }

    private void Binddl()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from StationMaster");
            if (dt.Rows.Count > 0)
            {
                ddlstation.DataTextField = "StationName";
                ddlstation.DataValueField = "Id";
                ddlstation.DataSource = dt;
                ddlstation.DataBind();
                ddlstation.Items.Insert(0, new ListItem("Select Station", "0"));
            }

            DataTable dt1 = D.GetDataTable("select * from ttmaster where IsSquadHead='true'");
            if (dt1.Rows.Count > 0)
            {
                ddlsquad.DataTextField = "Name";
                ddlsquad.DataValueField = "Id";
                ddlsquad.DataSource = dt1;
                ddlsquad.DataBind();
                ddlsquad.Items.Insert(0, new ListItem("Select TTSquad", "0"));
            }
        }
        catch (Exception e1)
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
        DataTable dt = D.GetData("select * from TTMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtName.Text = dt.Rows[0]["Name"].ToString();
            txtno.Text = dt.Rows[0]["MobileNo"].ToString();
            ddlstation.SelectedValue = dt.Rows[0]["StationId"].ToString();
            ddlsquad.SelectedValue = dt.Rows[0]["SquadHeadId"].ToString();
            if (ddlsquad.SelectedValue != "0")
            {
                status.Visible = false;
            }
            else
            {
                status.Visible = true;
            }
            string Status = dt.Rows[0]["IsSquadHead"].ToString();
            txtbrc.Text = dt.Rows[0]["Branch"].ToString();
            txtscl.Text = dt.Rows[0]["Scale"].ToString();
            txtpf.Text = dt.Rows[0]["PFno"].ToString();
            txthq.Text = dt.Rows[0]["HQ"].ToString();
            txtdiv.Text = dt.Rows[0]["Division"].ToString();
            txtahar.Text = dt.Rows[0]["AdharNo"].ToString();
            if (Status == "True")
            {
                ltrdrop.Visible = false;
                status.Checked = true;
            }
            else
            {
                ltrdrop.Visible = true;
                status.Checked = false;
            }
           
        }
    }
    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from TTMaster where Id=" + id);

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
        int st = 1;
        int st1 = 0;
        string qry = "";
        string stationID = ddlstation.SelectedValue;
        string st2 = txtName.Text.Substring(0, 4);
        string st3 = txtahar.Text.Substring(8, 4);
        string username = String.Concat(st2, st3).ToString();
        try
        {
            if (status.Checked == true)
            {
                if (ddlsquad.SelectedValue == "0")
                {
                    qry = "insert into TTMaster (Name,MobileNo,UserName,Password,StationId,SquadHeadId,IsSquadHead,Branch,Scale,Division,PFno,HQ,AdharNo) values('" + txtName.Text + "','" + txtno.Text + "','" + username + "','" + txtahar.Text + "','" + ddlstation.SelectedValue + "','" + 0 + "','" + st + "','" + txtbrc.Text + "','" + txtscl.Text + "','" + txtdiv.Text + "','" + txtpf.Text + "','" + txthq.Text + "','" + txtahar.Text + "')";
                }
                else
                {
                    qry = "insert into TTMaster (Name,MobileNo,UserName,Password,StationId,SquadHeadId,IsSquadHead,Branch,Scale,Division,PFno,HQ,AdharNo) values('" + txtName.Text + "','" + txtno.Text + "','" + username + "','" + txtahar.Text + "','" + ddlstation.SelectedValue + "','" + ddlsquad.SelectedValue + "','" + st + "','" + txtbrc.Text + "','" + txtscl.Text + "','" + txtdiv.Text + "','" + txtpf.Text + "','" + txthq.Text + "','" + txtahar.Text + "')";
                }
            }
            else
            {
                if (ddlsquad.SelectedValue == "0")
                {
                    qry = "insert into TTMaster (Name,MobileNo,UserName,Password,StationId,SquadHeadId,IsSquadHead,Branch,Scale,Division,PFno,HQ,AdharNo) values('" + txtName.Text + "','" + txtno.Text + "','" + username + "','" + txtahar.Text + "','" + ddlstation.SelectedValue + "','" + 0 + "','" + st1 + "','" + txtbrc.Text + "','" + txtscl.Text + "','" + txtdiv.Text + "','" + txtpf.Text + "','" + txthq.Text + "','" + txtahar.Text + "')";
                }
                else
                {
                    qry = "insert into TTMaster (Name,MobileNo,UserName,Password,StationId,SquadHeadId,IsSquadHead,Branch,Scale,Division,PFno,HQ,AdharNo) values('" + txtName.Text + "','" + txtno.Text + "','" + username + "','" + txtahar.Text + "','" + ddlstation.SelectedValue + "','" + ddlsquad.SelectedValue + "','" + st1 + "','" + txtbrc.Text + "','" + txtscl.Text + "','" + txtdiv.Text + "','" + txtpf.Text + "','" + txthq.Text + "','" + txtahar.Text + "')";
                }
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

    private void Clear()
    {
        txtName.Text = "";
        txtno.Text = "";
        ddlstation.SelectedValue = "0";
        ddlsquad.SelectedValue = "0";
        status.Checked = false;
        txtahar.Text = "";
        txtbrc.Text = "";
        txtdiv.Text = "";
        txthq.Text = "";
        txtpf.Text = "";
        txtscl.Text = "";
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        int st = 1;
        int st1 = 0;
        string qry = "";
        string st2 = txtName.Text.Substring(0, 4);
        string st3 = txtahar.Text.Substring(7, 4);
        string username = String.Concat(st2, st3).ToString();
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);

        if (status.Checked == true)
        {
            qry = "update TTMaster set Name='" + txtName.Text + "',MobileNo='" + txtno.Text + "',UserName='" + username + "',StationId='" + ddlstation.SelectedValue + "',SquadHeadId='" + ddlsquad.SelectedValue + "',IsSquadHead='" + st + "',AdharNo='" + txtahar.Text + "',Branch='" + txtbrc.Text + "',Scale='" + txtscl.Text + "',Division='" + txtdiv.Text + "',PFno='" + txtpf.Text + "',HQ='" + txthq.Text + "' where Id='" + lbSubmit.CommandArgument + "'";
        }
        else
        {
            qry = "update TTMaster set Name='" + txtName.Text + "',MobileNo='" + txtno.Text + "',UserName='" + username + "',StationId='" + ddlstation.SelectedValue + "',SquadHeadId='" + ddlsquad.SelectedValue + "',IsSquadHead='" + st1 + "',AdharNo='" + txtahar.Text + "',Branch='" + txtbrc.Text + "',Scale='" + txtscl.Text + "',Division='" + txtdiv.Text + "',PFno='" + txtpf.Text + "',HQ='" + txthq.Text + "' where Id='" + lbSubmit.CommandArgument + "'";
        }
        cmd.Connection = cn;
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

    protected void ddlsquad_SelectedIndexChanged(object sender, EventArgs e)
    {
        string str = ddlsquad.SelectedValue.ToString();
        if (str != "0")
        {
            status.Visible = false;
        }
        else
        {
            status.Visible = true;
        }
    }
    protected void status_CheckedChanged(object sender, EventArgs e)
    {
        if (status.Checked == true)
        {
            ltrdrop.Visible = false;
        }
        else
        {
            ltrdrop.Visible = true;
        }
    }
}