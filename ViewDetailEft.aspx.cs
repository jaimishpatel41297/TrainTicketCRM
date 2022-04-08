using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class ViewDetailEft : System.Web.UI.Page
{
    Connection D = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string Id = Request.QueryString["Id"].ToString();

        if (Id != null)
        {
            if (!IsPostBack)
            {
                Binddata();
            }
        }
        else
        {
            Response.Redirect("AddEft.aspx");
        }
    }

    private void Binddata()
    {
        try
        {
            string Id = Request.QueryString["Id"].ToString();
            string qry = "";
            qry = "select distinct em.*,r.Name as reason,c.ClassName as class,tt.Name as ttname from ExcessFairMaster em,ChargeReasonMaster r,TrainClassMaster c,TTMaster tt where c.Id=em.ClassId and r.Id=em.ReasonId and em.TTId=tt.Id and em.Id=" + Id;

            DataTable dt = D.GetDataTable(qry);
            if (dt.Rows.Count > 0)
            {
                ltrcolon.Text = dt.Rows[0]["CollectedOn"].ToString();
                ltrfrmst.Text = dt.Rows[0]["FromStation"].ToString();
                ltrtost.Text = dt.Rows[0]["ToStation"].ToString();
                ltrtickno.Text = dt.Rows[0]["TicketNo"].ToString();
                ltrweigh.Text = dt.Rows[0]["Weight"].ToString();
                ltrweighchr.Text = dt.Rows[0]["WeightCharge"].ToString();
                ltrtotal.Text = dt.Rows[0]["Total"].ToString();
                ltrcgst.Text = dt.Rows[0]["CGST"].ToString();
                ltrsgst.Text = dt.Rows[0]["SGST"].ToString();
                ltrigst.Text = dt.Rows[0]["IGST"].ToString();
                ltrugst.Text = dt.Rows[0]["UGST"].ToString();
                ltrresnam.Text = dt.Rows[0]["reason"].ToString();
                ltrclsname.Text = dt.Rows[0]["class"].ToString();
                ltrstname.Text = dt.Rows[0]["StationName"].ToString();
                ltrpassenger.Text = dt.Rows[0]["Passengers"].ToString();
                ltravlfrmst.Text = dt.Rows[0]["AvlFromStation"].ToString();
                ltravltost.Text = dt.Rows[0]["AvlToStation"].ToString();
                ltravlclsid.Text = dt.Rows[0]["class"].ToString();
                ltrismodi.Text = dt.Rows[0]["Ismodified"].ToString();
                ltrmoddate.Text = Convert.ToDateTime(dt.Rows[0]["ModifiedDate"]).ToString("dd-MM-yyyy");
            } 
        }
        catch (Exception ex)
        {
        }
    }
}