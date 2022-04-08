using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SuperAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request.Cookies["AdminId"] != null)
            {
                //string id = Request.Cookies["AdminId"].Value;
                //string m1 = "<li>" +
                //    "<a href='#' class='waves-effect'><i class='zmdi zmdi-apps zmdi-hc-fw fa fa-plus-square'></i><span class='hide-menu'>&nbsp;&nbsp;View Reports<span class='fa arrow'></span></span></a>" +
                //            "<ul class='nav nav-second-level'>" +
                //                "<li><a href='NightDutyReport.aspx'>View EFT Report</a></li>" +
                //                "<li><a href='PaymentDeposit.aspx'>View EFT Ticket Report</a></li>" +
                //                "<li><a href='ReturnExcessReport.aspx'>View TA Report</a></li>" +
                //               " <li><a href='TravellingAllownace.aspx'>View NDA Report</a></li>" +
                //            "</ul>" +
                //        "</li>";

                //ltrreport.Text = m1;
                admintab.Visible = true;
                usertab.Visible = false;
            }
            else
            {
                if (Request.Cookies["UserId"] != null)
                {
                    string id = Request.Cookies["UserId"].Value;
                    string m1 = "<li>" +
                        "<a href='#' class='waves-effect'><i class='zmdi zmdi-apps zmdi-hc-fw fa fa-plus-square'></i><span class='hide-menu'>&nbsp;&nbsp;View Reports<span class='fa arrow'></span></span></a>" +
                                "<ul class='nav nav-second-level'>" +
                                    "<li><a href='/Report/NightDutyReport.aspx?Report_Name=NDAReport&ID=" + id + "'>View EFT Report</a></li>" +
                                    "<li><a href='/Report/PaymentDeposit.aspx?Report_Name=PDReport&ID=" + id + "'>View EFT Ticket Report</a></li>" +
                                    "<li><a href='/Report/ReturnExcessReport.aspx?Report_Name=ReturnReport&ID=" + id + "'>View TA Report</a></li>" +
                                   " <li><a href='/Report/TravellingAllownace.aspx?Report_Name=TAReport&ID=" + id + "'>View NDA Report</a></li>" +
                                "</ul>" +
                            "</li>";
                    ltrreport.Text = m1;
                    usertab.Visible = true;
                    admintab.Visible = false;
                }
                else
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}
