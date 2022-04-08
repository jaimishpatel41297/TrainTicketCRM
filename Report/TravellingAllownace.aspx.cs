using DevExpress.XtraPrinting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Configuration;

public partial class Report_TravellingAllownace : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ConnectionString.ToString());
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];
        string Report_Name = Request.QueryString["Report_Name"];

        if (Report_Name != null && Report_Name == "TAReport" && ID != null)
        {
            CustomSqlQuery Query = new CustomSqlQuery();
            Query.Name = "CustomSqlQuery";
            Query.Sql = "select ta.*,tt.Name from TaMAster ta, TTMaster as tt where ta.TTId=tt.Id and ta.id=" + ID;

            TravellingAllowanceReport Servicememo1 = new TravellingAllowanceReport();

            Servicememo1.sqlDataSource1.Queries[0] = Query;

            using (MemoryStream ms = new MemoryStream())
            {
                Servicememo1.ExportToPdf(ms, new PdfExportOptions() { ShowPrintDialogOnOpen = true });
                WriteDocumentToResponse(ms.ToArray(), "pdf", true, "Report.pdf");
            }
        }
    }

    void WriteDocumentToResponse(byte[] documentData, string format, bool isInline, string fileName)
    {
        string contentType;
        string disposition = (isInline) ? "inline" : "attachment";

        switch (format.ToLower())
        {
            case "xls":
                contentType = "application/vnd.ms-excel";
                break;
            case "xlsx":
                contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                break;
            case "mht":
                contentType = "message/rfc822";
                break;
            case "html":
                contentType = "text/html";
                break;
            case "txt":
            case "csv":
                contentType = "text/plain";
                break;
            case "png":
                contentType = "image/png";
                break;
            default:
                contentType = String.Format("application/{0}", format);
                break;
        }

        Response.Clear();
        Response.ContentType = "application/pdf";
        Response.AddHeader("Content-Disposition", String.Format("{0}; filename={1}", disposition, fileName));
        Response.BinaryWrite(documentData);
        Response.End();
    }
}