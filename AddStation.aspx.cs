using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class AddStation : System.Web.UI.Page
{
    Connection D = new Connection();
    SqlConnection cn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ToString());
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    private void BindData()
    {
        try
        {
            string qry = "";

            qry = "select * from StationMaster";

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

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = cn;
        cmd.CommandText = "insert into StationMaster(StationName,StationCode) values('" + txtname.Text + "','" + txtcode.Text + "')";
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        BindData();

        divSuccess.Visible = true;
        divError.Visible = false;

        txtname.Text = "";
        txtcode.Text = "";
    }

    protected void lbUpdate_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand();
        cmd.Parameters.AddWithValue("@ID", lbSubmit.CommandArgument);

        cmd.Connection = cn;

        string qry = "update StationMaster set StationName='" + txtname.Text + "',StationCode='" + txtcode.Text + "' where Id='" + lbSubmit.CommandArgument + "'";

        cmd.CommandText = qry;

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();

        txtname.Text = "";
        txtcode.Text = "";

        BindData();
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
        divSuccess.Visible = true;
        divError.Visible = false;
    }

    protected void lbCancel_Click(object sender, EventArgs e)
    {
        Clear();
    }

    private void Clear()
    {
        txtcode.Text = "";
        txtname.Text = "";
        lbUpdate.Visible = false;
        lbSubmit.Visible = true;
    }

    protected void lbEdit_Click(object sender, EventArgs e)
    {
        LinkButton lbs = (LinkButton)sender;
        int ids = Convert.ToInt32(lbs.CommandArgument);
        lbSubmit.CommandArgument = ids.ToString();

        LinkButton lb = (LinkButton)sender;
        int id = Convert.ToInt32(lb.CommandArgument);
        DataTable dt = D.GetData("select * from StationMaster where Id=" + lb.CommandArgument);
        if (dt.Rows.Count > 0)
        {

            lbSubmit.Visible = false;
            lbUpdate.Visible = true;
            lbSubmit.CommandArgument = dt.Rows[0]["Id"].ToString();

            txtname.Text = dt.Rows[0]["StationName"].ToString();
            txtcode.Text = dt.Rows[0]["StationCode"].ToString();

        }
    }

    protected void lbDelete_Click(object sender, EventArgs e)
    {
        try
        {
            LinkButton lb = (LinkButton)sender;
            int id = Convert.ToInt32(lb.CommandArgument.ToString());
            D.ExecuteQuery("delete from StationMaster where Id=" + id);

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
}