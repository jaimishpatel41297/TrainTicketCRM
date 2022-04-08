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

public partial class Report_MonthlyReasonReport : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ConnectionString.ToString());
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];
        string Report_Name = Request.QueryString["Report_Name"];

        if (Report_Name != null && Report_Name == "ReasonReport" && ID != null)
        {
            CustomSqlQuery Query = new CustomSqlQuery();
            Query.Name = "MasterSqlQuery";
            Query.Sql = "select tt.Name as TTName,DATENAME(month, GETDATE()) as This from ExcessFairMaster efm,TTMaster as tt where efm.TTId=tt.Id and Month(Date)=Month(getdate()) and efm.TTId=" + ID;

            CustomSqlQuery WTSqlQuery = new CustomSqlQuery();
            WTSqlQuery.Name = "WTSqlQuery";
            WTSqlQuery.Sql = "select tt.Name as TTName,crm.ShortCode,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, ChargeReasonMaster crm,TTMaster as tt where efm.ReasonId=crm.Id and efm.TTId=tt.Id and efm.ReasonId=1 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by crm.ShortCode,tt.Name";

            CustomSqlQuery OTSqlQuery = new CustomSqlQuery();
            OTSqlQuery.Name = "OTSqlQuery";
            OTSqlQuery.Sql = "select tt.Name as TTName,crm.ShortCode,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, ChargeReasonMaster crm,TTMaster as tt where efm.ReasonId=crm.Id and efm.TTId=tt.Id and efm.ReasonId=2 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by crm.ShortCode,tt.Name";

            CustomSqlQuery HTSqlQuery = new CustomSqlQuery();
            HTSqlQuery.Name = "HTSqlQuery";
            HTSqlQuery.Sql = "select tt.Name as TTName,crm.ShortCode,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, ChargeReasonMaster crm,TTMaster as tt where efm.ReasonId=crm.Id and efm.TTId=tt.Id and efm.ReasonId=3 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by crm.ShortCode,tt.Name";

            CustomSqlQuery DIFFSqlQuery = new CustomSqlQuery();
            DIFFSqlQuery.Name = "DIFFSqlQuery";
            DIFFSqlQuery.Sql = "select tt.Name as TTName,crm.ShortCode,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, ChargeReasonMaster crm,TTMaster as tt where efm.ReasonId=crm.Id and efm.TTId=tt.Id and efm.ReasonId=4 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by crm.ShortCode,tt.Name";

            CustomSqlQuery UBLSqlQuery = new CustomSqlQuery();
            UBLSqlQuery.Name = "UBLSqlQuery";
            UBLSqlQuery.Sql = "select tt.Name as TTName,crm.ShortCode,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, ChargeReasonMaster crm,TTMaster as tt where efm.ReasonId=crm.Id and efm.TTId=tt.Id and efm.ReasonId=5 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by crm.ShortCode,tt.Name";

            CustomSqlQuery FoilsQuery = new CustomSqlQuery();
            FoilsQuery.Name = "FoilsSqlQuery";
            FoilsQuery.Sql = "select *,(cast(ToEFTNo as int)-cast(FromEFTNo as int) + 1) as Total from [dbo].[ExcessFairRecieptMaster] where TTId=" + ID + " and MONTH(Date) = MONTH(getdate())";

            CustomSqlQuery STWISESqlQuery = new CustomSqlQuery();
            STWISESqlQuery.Name = "STWISESqlQuery";
            STWISESqlQuery.Sql = "SELECT StationName, SUM(cast(Amount as int)) AS Total FROM ExcessFairRecieptMaster where TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) GROUP BY StationName ";


            MonthlyReasonReport Servicememo1 = new MonthlyReasonReport();

            Servicememo1.sqlDataSourceTT.Queries[0] = Query;
            Servicememo1.sqlDataSourceWT.Queries[0] = WTSqlQuery;
            Servicememo1.sqlDataSourceOT.Queries[0] = OTSqlQuery;
            Servicememo1.sqlDataSourceHT.Queries[0] = HTSqlQuery;
            Servicememo1.sqlDataSourceDIFF.Queries[0] = DIFFSqlQuery;
            Servicememo1.sqlDataSourceUBL.Queries[0] = UBLSqlQuery;
            Servicememo1.sqlDataSourceFoils.Queries[0] = FoilsQuery;
            Servicememo1.sqlDataSourceSTWISE.Queries[0] = STWISESqlQuery;

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