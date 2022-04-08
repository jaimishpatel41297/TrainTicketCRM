using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class AddMenu : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindMenu();
            Bindddl();
        }
    }
    private void BindMenu()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from MenuMaster");
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
    private void Bindddl()
    {
        try
        {
            DataTable dt = D.GetDataTable("select * from MenuMaster where Parent=0");
            if (dt.Rows.Count > 0)
            {
                ddlMenu.DataTextField = "MenuName";
                ddlMenu.DataValueField = "Id";
                ddlMenu.DataSource = dt;
                ddlMenu.DataBind();
                ddlMenu.Items.Insert(0, new ListItem("Main Menu ", "0"));
            }
        }
        catch (Exception ex)
        {

        }
    }

    protected void lbSubmit_Click(object sender, EventArgs e)
    {
        string qry = "";
        try
        {
            qry = "insert into MenuMaster(MenuName,Url,Parent,SortOrder,IsActive) values('" + txtmenu.Text + "','" + txtUrl.Text + "','" + ddlMenu.SelectedIndex + "','" + txtsort.Text + "','" + chkStatus.Checked + "')";

            D.ExecuteQuery(qry);

            BindMenu();
            Bindddl();
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
        txtmenu.Text = "";
        txtUrl.Text = "";
        ddlMenu.SelectedIndex = 0;
        txtsort.Text = "";
        chkStatus.Checked = false;
    }
    protected void lbUpdate_Click(object sender, EventArgs e)
    {

    }
}