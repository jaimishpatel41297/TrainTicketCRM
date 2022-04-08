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

public partial class Report_MonthlyReturnReport : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ConnectionString.ToString());
    Connection cn = new Connection();
    protected void Page_Load(object sender, EventArgs e)
    {
        string ID = Request.QueryString["ID"];
        string Report_Name = Request.QueryString["Report_Name"];

        if (Report_Name != null && Report_Name == "ReturnReport" && ID != null)
        {
            CustomSqlQuery Query = new CustomSqlQuery();
            Query.Name = "MasterSqlQuery";
            Query.Sql = "select tt.Name as TTName,DATENAME(month, GETDATE()) as This from ExcessFairMaster efm,TTMaster as tt where efm.TTId=tt.Id and Month(Date)=Month(getdate()) and efm.TTId=" + ID;

            CustomSqlQuery FCQuery = new CustomSqlQuery();
            FCQuery.Name = "FCSqlQuery";
            FCQuery.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=1 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery AC1Query = new CustomSqlQuery();
            AC1Query.Name = "1ACSqlQuery";
            AC1Query.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=2 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery AC2Query = new CustomSqlQuery();
            AC2Query.Name = "2ACSqlQuery";
            AC2Query.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=3 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery AC3Query = new CustomSqlQuery();
            AC3Query.Name = "3ACSqlQuery";
            AC3Query.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=4 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery CCQuery = new CustomSqlQuery();
            CCQuery.Name = "CCSqlQuery";
            CCQuery.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=5 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery SLQuery = new CustomSqlQuery();
            SLQuery.Name = "SLSqlQuery";
            SLQuery.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=6 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery MEQuery = new CustomSqlQuery();
            MEQuery.Name = "MESqlQuery";
            MEQuery.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=8 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery OrdQuery = new CustomSqlQuery();
            OrdQuery.Name = "OrdSqlQuery";
            OrdQuery.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=9 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery S2Query = new CustomSqlQuery();
            S2Query.Name = "2SSqlQuery";
            S2Query.Sql = "select tt.Name as TTName,tcm.ClassName,sum(cast(FareAmount as int)) as fxfare,sum(cast(ExcessCharge as int)) as exchg,sum(cast(WeightCharge as int)) as ubl,sum(cast(TotalWithGST as decimal)) as TotalGST from ExcessFairMaster efm, TrainClassMaster tcm,TTMaster as tt where efm.ClassId=tcm.Id and efm.TTId=tt.Id and efm.ClassId=7 and efm.TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) group by tcm.ClassName,tt.Name";

            CustomSqlQuery FoilsQuery = new CustomSqlQuery();
            FoilsQuery.Name = "FolisSqlQuery";
            FoilsQuery.Sql = "select *,(cast(ToEFTNo as int)-cast(FromEFTNo as int) + 1) as Total from [dbo].[ExcessFairRecieptMaster] where TTId=" + ID + " and MONTH(Date) = MONTH(getdate())";

            CustomSqlQuery STWISESqlQuery = new CustomSqlQuery();
            STWISESqlQuery.Name = "STWISESqlQuery";
            STWISESqlQuery.Sql = "SELECT StationName, SUM(cast(Amount as int)) AS Total FROM ExcessFairRecieptMaster where TTId=" + ID + " and MONTH(Date) = MONTH(getdate()) GROUP BY StationName ";


            MonthlyReturnReport Servicememo1 = new MonthlyReturnReport();

            Servicememo1.sqlDataSourceTT.Queries[0] = Query;
            Servicememo1.sqlDataSourceFC.Queries[0] = FCQuery;
            Servicememo1.sqlDataSource1AC.Queries[0] = AC1Query;
            Servicememo1.sqlDataSource2AC.Queries[0] = AC2Query;
            Servicememo1.sqlDataSource3AC.Queries[0] = AC3Query;
            Servicememo1.sqlDataSourceCC.Queries[0] = CCQuery;
            Servicememo1.sqlDataSourceSL.Queries[0] = SLQuery;
            Servicememo1.sqlDataSourceME.Queries[0] = MEQuery;
            Servicememo1.sqlDataSourceORD.Queries[0] = OrdQuery;
            Servicememo1.sqlDataSource2S.Queries[0] = S2Query;
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