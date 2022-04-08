<<<<<<< HEAD
﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for MonthlyReasonReport
/// </summary>
public class MonthlyReasonReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRLine xrLine4;
    private XRLine xrLine6;
    private XRLine xrLine2;
    private XRLine xrLine1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell3;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRLabel xrLabel7;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable42;
    private XRTableRow xrTableRow42;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell136;
    private DetailReportBand DetailReport1;
    private DetailBand Detail2;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceWT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceOT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceHT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceDIFF;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceUBL;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceFoils;
    private ReportFooterBand ReportFooter1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceTT;
    private XRLabel xrLabel8;
    private XRTable xrTable35;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell150;
    private XRTableCell xrTableCell151;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell71;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSTWISE;
    private PageFooterBand PageFooter;
    private XRTable xrTable41;
    private XRTableRow xrTableRow41;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell128;
    private XRTable xrTable40;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell120;
    private XRTable xrTable39;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell100;
    private XRTable xrTable38;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell80;
    private XRTable xrTable37;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell76;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public MonthlyReasonReport()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "MonthlyReasonReport.resx";
            System.Resources.ResourceManager resources = global::Resources.MonthlyReasonReport.ResourceManager;
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery8 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceWT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceOT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceHT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceDIFF = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceUBL = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable42 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.sqlDataSourceFoils = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceTT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable35 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceSTWISE = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrTable41 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable40 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable39 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable38 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable37 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLabel7,
            this.xrTable1,
            this.xrTable4,
            this.xrTable5,
            this.xrTable6,
            this.xrTable7,
            this.xrTable8,
            this.xrTable14,
            this.xrTable13});
            this.Detail.HeightF = 284.2083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 258.8333F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "SR NO";
            this.xrTableCell6.Weight = 1.0901243803361946D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "FROM";
            this.xrTableCell7.Weight = 1.7313759472191375D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "TO";
            this.xrTableCell8.Weight = 2.3999998158772859D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "TOTAL";
            this.xrTableCell9.Weight = 2.8784992462158194D;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 235.8333F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(500.8333F, 23F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "EFT FOILS USED";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "CLASS";
            this.xrTableCell1.Weight = 1.566666717529297D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "FX FARE";
            this.xrTableCell2.Weight = 1.9083332824707027D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "EX CHG";
            this.xrTableCell4.Weight = 1.5250000000000006D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "UBL";
            this.xrTableCell5.Weight = 1.475D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "TOTAL AMT";
            this.xrTableCell3.Weight = 1.6249993896484369D;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 24.5F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "WT";
            this.xrTableCell16.Weight = 1.566666717529297D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.fxfare")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceWT
            // 
            this.sqlDataSourceWT.ConnectionName = "TTReturn";
            this.sqlDataSourceWT.Name = "sqlDataSourceWT";
            customSqlQuery1.Name = "WTSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSourceWT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceWT.ResultSchemaSerializable = resources.GetString("sqlDataSourceWT.ResultSchemaSerializable");
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.exchg")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Weight = 1.5250000000000006D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.ubl")});
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Weight = 1.475D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.TotalGST")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Weight = 1.6249993896484369D;
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 49.5F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseFont = false;
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "OT";
            this.xrTableCell21.Weight = 1.566666717529297D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.fxfare")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceOT
            // 
            this.sqlDataSourceOT.ConnectionName = "TTReturn";
            this.sqlDataSourceOT.Name = "sqlDataSourceOT";
            customSqlQuery2.Name = "OTSqlQuery";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSourceOT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSourceOT.ResultSchemaSerializable = resources.GetString("sqlDataSourceOT.ResultSchemaSerializable");
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.exchg")});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Weight = 1.5250000000000006D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.ubl")});
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Weight = 1.475D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.TotalGST")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Weight = 1.6249993896484369D;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 74.5F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Text = "HT";
            this.xrTableCell26.Weight = 1.566666717529297D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.fxfare")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceHT
            // 
            this.sqlDataSourceHT.ConnectionName = "TTReturn";
            this.sqlDataSourceHT.Name = "sqlDataSourceHT";
            customSqlQuery3.Name = "HTSqlQuery";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSourceHT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSourceHT.ResultSchemaSerializable = resources.GetString("sqlDataSourceHT.ResultSchemaSerializable");
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.exchg")});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Weight = 1.5250000000000006D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.ubl")});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Weight = 1.475D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.TotalGST")});
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Weight = 1.6249993896484369D;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 99F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable7.StylePriority.UseBorders = false;
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Text = "DIFF";
            this.xrTableCell31.Weight = 1.566666717529297D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.fxfare")});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceDIFF
            // 
            this.sqlDataSourceDIFF.ConnectionName = "TTReturn";
            this.sqlDataSourceDIFF.Name = "sqlDataSourceDIFF";
            customSqlQuery4.Name = "DIFFSqlQuery";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSourceDIFF.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSourceDIFF.ResultSchemaSerializable = resources.GetString("sqlDataSourceDIFF.ResultSchemaSerializable");
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.exchg")});
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Weight = 1.5250000000000006D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.ubl")});
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Weight = 1.475D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.TotalGST")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Weight = 1.6249993896484369D;
            // 
            // xrTable8
            // 
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 124F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable8.StylePriority.UseBorders = false;
            this.xrTable8.StylePriority.UseFont = false;
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Text = "UBL";
            this.xrTableCell36.Weight = 1.566666717529297D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.fxfare")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceUBL
            // 
            this.sqlDataSourceUBL.ConnectionName = "TTReturn";
            this.sqlDataSourceUBL.Name = "sqlDataSourceUBL";
            customSqlQuery5.Name = "UBLSqlQuery";
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            this.sqlDataSourceUBL.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5});
            this.sqlDataSourceUBL.ResultSchemaSerializable = resources.GetString("sqlDataSourceUBL.ResultSchemaSerializable");
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.exchg")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 1.5250000000000006D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.ubl")});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Weight = 1.475D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.TotalGST")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Weight = 1.6249993896484369D;
            // 
            // xrTable14
            // 
            this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 173.5F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable14.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable14.StylePriority.UseBorders = false;
            this.xrTable14.StylePriority.UseFont = false;
            this.xrTable14.StylePriority.UseTextAlignment = false;
            this.xrTable14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Text = "TOTAL";
            this.xrTableCell66.Weight = 1.566666717529297D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Weight = 1.9083332824707027D;
            this.xrTableCell67.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell67_BeforePrint);
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Weight = 1.5250000000000006D;
            this.xrTableCell68.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell68_BeforePrint);
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Weight = 1.475D;
            this.xrTableCell69.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell69_BeforePrint);
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.Weight = 1.6249993896484369D;
            this.xrTableCell70.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell70_BeforePrint);
            // 
            // xrTable13
            // 
            this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 148.5F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
            this.xrTable13.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable13.StylePriority.UseBorders = false;
            this.xrTable13.StylePriority.UseFont = false;
            this.xrTable13.StylePriority.UseTextAlignment = false;
            this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Text = "GST";
            this.xrTableCell61.Weight = 1.566666717529297D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Weight = 1.9083332824707027D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Weight = 1.5250000000000006D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Weight = 1.475D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Weight = 1.6249993896484369D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 20F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLine6,
            this.xrLine2,
            this.xrLine1,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14});
            this.PageHeader.HeightF = 129F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine4
            // 
            this.xrLine4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(611.9583F, 79.5F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLine4.StylePriority.UseBorders = false;
            // 
            // xrLine6
            // 
            this.xrLine6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(626.4583F, 106F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLine6.StylePriority.UseBorders = false;
            // 
            // xrLine2
            // 
            this.xrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(63.53809F, 78.5F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(362F, 23F);
            this.xrLine2.StylePriority.UseBorders = false;
            // 
            // xrLine1
            // 
            this.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(93.95831F, 106F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(333.5798F, 23.00001F);
            this.xrLine1.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(810F, 23F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BCT DIVISION";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 27.5F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(810F, 23F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "SUMMARY OF MONTHLY RETURNS BY REASON";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.5F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(67.29163F, 23F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "NAME :";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.00002F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(98.9583F, 22.99999F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "DESG / HQ :";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(552.5F, 68.5F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(67.29163F, 23F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "CODE :";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(552.6667F, 95.00002F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(79.79163F, 22.99999F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "MONTH :";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceTT, "MasterSqlQuery.TTName")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(67.29167F, 68.5F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(358.2464F, 23F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(98.9583F, 94.99998F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(328.5798F, 23F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(609.9583F, 68.5F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceTT, "MasterSqlQuery.This")});
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(625.4583F, 94.99998F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter1});
            this.DetailReport.DataMember = "FoilsSqlQuery";
            this.DetailReport.DataSource = this.sqlDataSourceFoils;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable42});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable42
            // 
            this.xrTable42.BackColor = System.Drawing.Color.Transparent;
            this.xrTable42.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable42.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable42.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable42.Name = "xrTable42";
            this.xrTable42.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow42});
            this.xrTable42.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable42.StylePriority.UseBackColor = false;
            this.xrTable42.StylePriority.UseBorders = false;
            this.xrTable42.StylePriority.UseFont = false;
            this.xrTable42.StylePriority.UseTextAlignment = false;
            this.xrTable42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow42
            // 
            this.xrTableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell129,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell136});
            this.xrTableRow42.Name = "xrTableRow42";
            this.xrTableRow42.Weight = 1D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell129.Summary = xrSummary1;
            this.xrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell129.Weight = 0.40374978050230592D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.FromEFTNo")});
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.Weight = 0.64125049690249614D;
            // 
            // xrTableCell133
            // 
            this.xrTableCell133.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.ToEFTNo")});
            this.xrTableCell133.Name = "xrTableCell133";
            this.xrTableCell133.Weight = 0.88888893975152206D;
            // 
            // xrTableCell136
            // 
            this.xrTableCell136.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.Total")});
            this.xrTableCell136.Name = "xrTableCell136";
            this.xrTableCell136.Weight = 1.0661107828436758D;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2});
            this.DetailReport1.DataMember = "STWISESqlQuery";
            this.DetailReport1.DataSource = this.sqlDataSourceSTWISE;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15});
            this.Detail2.HeightF = 25F;
            this.Detail2.Name = "Detail2";
            // 
            // sqlDataSourceFoils
            // 
            this.sqlDataSourceFoils.ConnectionName = "TTReturn";
            this.sqlDataSourceFoils.Name = "sqlDataSourceFoils";
            customSqlQuery7.Name = "FoilsSqlQuery";
            customSqlQuery7.Sql = "select *,(cast(ToEFTNo as int)-cast(FromEFTNo as int) + 1) as Total from [dbo].[E" +
    "xcessFairRecieptMaster]";
            this.sqlDataSourceFoils.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery7});
            this.sqlDataSourceFoils.ResultSchemaSerializable = resources.GetString("sqlDataSourceFoils.ResultSchemaSerializable");
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrTable35,
            this.xrTable3});
            this.ReportFooter1.HeightF = 102.125F;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.Transparent;
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable3.StylePriority.UseBackColor = false;
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            this.xrTableCell11.Summary = xrSummary2;
            this.xrTableCell11.Text = "TOTAL";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 0.40374978050230592D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Weight = 0.64125049690249614D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Weight = 0.88888893975152206D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.Total")});
            this.xrTableCell14.Name = "xrTableCell14";
            xrSummary3.FormatString = "{0:#}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell14.Summary = xrSummary3;
            this.xrTableCell14.Weight = 1.0661107828436758D;
            // 
            // sqlDataSourceTT
            // 
            this.sqlDataSourceTT.ConnectionName = "TTReturn";
            this.sqlDataSourceTT.Name = "sqlDataSourceTT";
            customSqlQuery6.Name = "MasterSqlQuery";
            customSqlQuery6.Sql = "select tt.Name as TTName,DATENAME(month, GETDATE()) as This from ExcessFairMaster" +
    " efm,TTMaster as tt where efm.TTId=tt.Id and Month(Date)=Month(getdate())";
            this.sqlDataSourceTT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery6});
            this.sqlDataSourceTT.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZVRUIj48VmlldyBOYW1lPSJNYXN0ZXJTcWxRdWVyeSI+P" +
    "EZpZWxkIE5hbWU9IlRUTmFtZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJUaGlzIiBUeXBlP" +
    "SJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 54.12502F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(235.5F, 23F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "STATIONWISE REMITANCE";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable35
            // 
            this.xrTable35.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable35.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77.12498F);
            this.xrTable35.Name = "xrTable35";
            this.xrTable35.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow35});
            this.xrTable35.SizeF = new System.Drawing.SizeF(235.5F, 25F);
            this.xrTable35.StylePriority.UseBorders = false;
            this.xrTable35.StylePriority.UseFont = false;
            this.xrTable35.StylePriority.UseTextAlignment = false;
            this.xrTable35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell150,
            this.xrTableCell151});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Weight = 1D;
            // 
            // xrTableCell150
            // 
            this.xrTableCell150.Name = "xrTableCell150";
            this.xrTableCell150.Text = "STATION";
            this.xrTableCell150.Weight = 4.2157873618418478D;
            // 
            // xrTableCell151
            // 
            this.xrTableCell151.Name = "xrTableCell151";
            this.xrTableCell151.Text = "AMOUNT";
            this.xrTableCell151.Weight = 3.8842120278065897D;
            // 
            // xrTable15
            // 
            this.xrTable15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable15.Name = "xrTable15";
            this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
            this.xrTable15.SizeF = new System.Drawing.SizeF(235.5F, 25F);
            this.xrTable15.StylePriority.UseBorders = false;
            this.xrTable15.StylePriority.UseFont = false;
            this.xrTable15.StylePriority.UseTextAlignment = false;
            this.xrTable15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell71});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "STWISESqlQuery.StationName")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Weight = 4.2157873618418478D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "STWISESqlQuery.Total")});
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Weight = 3.8842120278065897D;
            // 
            // sqlDataSourceSTWISE
            // 
            this.sqlDataSourceSTWISE.ConnectionName = "TTReturn";
            this.sqlDataSourceSTWISE.Name = "sqlDataSourceSTWISE";
            customSqlQuery8.Name = "STWISESqlQuery";
            customSqlQuery8.Sql = "SELECT StationName, SUM(cast(Amount as int)) AS Total FROM ExcessFairRecieptMaste" +
    "r where MONTH(Date) = MONTH(getdate()) GROUP BY StationName";
            this.sqlDataSourceSTWISE.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery8});
            this.sqlDataSourceSTWISE.ResultSchemaSerializable = resources.GetString("sqlDataSourceSTWISE.ResultSchemaSerializable");
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable41,
            this.xrTable40,
            this.xrTable39,
            this.xrTable38,
            this.xrTable37,
            this.xrLabel9,
            this.xrLabel10});
            this.PageFooter.HeightF = 124.4999F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrTable41
            // 
            this.xrTable41.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable41.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 71.09084F);
            this.xrTable41.Name = "xrTable41";
            this.xrTable41.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow41});
            this.xrTable41.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable41.StylePriority.UseBorders = false;
            this.xrTable41.StylePriority.UseFont = false;
            this.xrTable41.StylePriority.UseTextAlignment = false;
            this.xrTable41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow41
            // 
            this.xrTableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell125,
            this.xrTableCell128});
            this.xrTableRow41.Name = "xrTableRow41";
            this.xrTableRow41.Weight = 1D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.StylePriority.UseTextAlignment = false;
            this.xrTableCell125.Text = "MR";
            this.xrTableCell125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell125.Weight = 4.2157864981866053D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.Weight = 3.8842128914618312D;
            // 
            // xrTable40
            // 
            this.xrTable40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable40.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.09084F);
            this.xrTable40.Name = "xrTable40";
            this.xrTable40.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow40});
            this.xrTable40.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable40.StylePriority.UseBorders = false;
            this.xrTable40.StylePriority.UseFont = false;
            this.xrTable40.StylePriority.UseTextAlignment = false;
            this.xrTable40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow40
            // 
            this.xrTableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell105,
            this.xrTableCell120});
            this.xrTableRow40.Name = "xrTableRow40";
            this.xrTableRow40.Weight = 1D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseTextAlignment = false;
            this.xrTableCell105.Text = "EFT CANCELLED FOILS";
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell105.Weight = 4.2157864981866053D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Weight = 3.8842128914618312D;
            // 
            // xrTable39
            // 
            this.xrTable39.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable39.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.59098F);
            this.xrTable39.Name = "xrTable39";
            this.xrTable39.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow39});
            this.xrTable39.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable39.StylePriority.UseBorders = false;
            this.xrTable39.StylePriority.UseFont = false;
            this.xrTable39.StylePriority.UseTextAlignment = false;
            this.xrTable39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow39
            // 
            this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell100});
            this.xrTableRow39.Name = "xrTableRow39";
            this.xrTableRow39.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.Text = "EFT FOILS USED:";
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell85.Weight = 4.2157864981866053D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Weight = 3.8842128914618312D;
            // 
            // xrTable38
            // 
            this.xrTable38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable38.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable38.Name = "xrTable38";
            this.xrTable38.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow38});
            this.xrTable38.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable38.StylePriority.UseBorders = false;
            this.xrTable38.StylePriority.UseFont = false;
            this.xrTable38.StylePriority.UseTextAlignment = false;
            this.xrTable38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow38
            // 
            this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell77,
            this.xrTableCell80});
            this.xrTableRow38.Name = "xrTableRow38";
            this.xrTableRow38.Weight = 1D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = "FORMS USED :";
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell77.Weight = 4.2157864981866053D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Weight = 3.8842128914618312D;
            // 
            // xrTable37
            // 
            this.xrTable37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable37.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 96.09084F);
            this.xrTable37.Name = "xrTable37";
            this.xrTable37.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow37});
            this.xrTable37.SizeF = new System.Drawing.SizeF(388.1483F, 25F);
            this.xrTable37.StylePriority.UseBorders = false;
            this.xrTable37.StylePriority.UseFont = false;
            this.xrTable37.StylePriority.UseTextAlignment = false;
            this.xrTable37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow37
            // 
            this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell76});
            this.xrTableRow37.Name = "xrTableRow37";
            this.xrTableRow37.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "TOTAL";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell10.Weight = 4.2157873618418478D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Weight = 3.8842120278065897D;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(438.3229F, 85.49993F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(159.6666F, 23F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "CTI\'s SIGN";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(645.448F, 85.49993F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(159.6666F, 23F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "TE\'s SIGN";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // MonthlyReasonReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.DetailReport,
            this.DetailReport1,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSourceWT,
            this.sqlDataSourceOT,
            this.sqlDataSourceHT,
            this.sqlDataSourceDIFF,
            this.sqlDataSourceUBL,
            this.sqlDataSourceFoils,
            this.sqlDataSourceTT,
            this.sqlDataSourceSTWISE});
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void xrTableCell67_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell17.Text != "" ? Convert.ToInt32(xrTableCell17.Text) : 0;
        int ot = xrTableCell22.Text != "" ? Convert.ToInt32(xrTableCell22.Text) : 0;
        int ht = xrTableCell27.Text != "" ? Convert.ToInt32(xrTableCell27.Text) : 0;
        int diff = xrTableCell32.Text != "" ? Convert.ToInt32(xrTableCell32.Text) : 0;
        int ubl = xrTableCell37.Text != "" ? Convert.ToInt32(xrTableCell37.Text) : 0;


        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell68_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell18.Text != "" ? Convert.ToInt32(xrTableCell18.Text) : 0;
        int ot = xrTableCell23.Text != "" ? Convert.ToInt32(xrTableCell23.Text) : 0;
        int ht = xrTableCell28.Text != "" ? Convert.ToInt32(xrTableCell28.Text) : 0;
        int diff = xrTableCell33.Text != "" ? Convert.ToInt32(xrTableCell33.Text) : 0;
        int ubl = xrTableCell38.Text != "" ? Convert.ToInt32(xrTableCell38.Text) : 0;


        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell69_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell19.Text != "" ? Convert.ToInt32(xrTableCell19.Text) : 0;
        int ot = xrTableCell24.Text != "" ? Convert.ToInt32(xrTableCell24.Text) : 0;
        int ht = xrTableCell29.Text != "" ? Convert.ToInt32(xrTableCell29.Text) : 0;
        int diff = xrTableCell34.Text != "" ? Convert.ToInt32(xrTableCell34.Text) : 0;
        int ubl = xrTableCell39.Text != "" ? Convert.ToInt32(xrTableCell39.Text) : 0;

        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell70_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell20.Text != "" ? Convert.ToInt32(xrTableCell20.Text) : 0;
        int ot = xrTableCell25.Text != "" ? Convert.ToInt32(xrTableCell25.Text) : 0;
        int ht = xrTableCell30.Text != "" ? Convert.ToInt32(xrTableCell30.Text) : 0;
        int diff = xrTableCell35.Text != "" ? Convert.ToInt32(xrTableCell35.Text) : 0;
        int ubl = xrTableCell40.Text != "" ? Convert.ToInt32(xrTableCell40.Text) : 0;

        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }
}
=======
﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for MonthlyReasonReport
/// </summary>
public class MonthlyReasonReport : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private PageHeaderBand PageHeader;
    private XRLine xrLine4;
    private XRLine xrLine6;
    private XRLine xrLine2;
    private XRLine xrLine1;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRLabel xrLabel11;
    private XRLabel xrLabel12;
    private XRLabel xrLabel13;
    private XRLabel xrLabel14;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell3;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell25;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTableCell xrTableCell30;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell70;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell9;
    private XRLabel xrLabel7;
    private DetailReportBand DetailReport;
    private DetailBand Detail1;
    private XRTable xrTable42;
    private XRTableRow xrTableRow42;
    private XRTableCell xrTableCell129;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell136;
    private DetailReportBand DetailReport1;
    private DetailBand Detail2;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceWT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceOT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceHT;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceDIFF;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceUBL;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceFoils;
    private ReportFooterBand ReportFooter1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceTT;
    private XRLabel xrLabel8;
    private XRTable xrTable35;
    private XRTableRow xrTableRow35;
    private XRTableCell xrTableCell150;
    private XRTableCell xrTableCell151;
    private XRTable xrTable15;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell71;
    public DevExpress.DataAccess.Sql.SqlDataSource sqlDataSourceSTWISE;
    private PageFooterBand PageFooter;
    private XRTable xrTable41;
    private XRTableRow xrTableRow41;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell128;
    private XRTable xrTable40;
    private XRTableRow xrTableRow40;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell120;
    private XRTable xrTable39;
    private XRTableRow xrTableRow39;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell100;
    private XRTable xrTable38;
    private XRTableRow xrTableRow38;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell80;
    private XRTable xrTable37;
    private XRTableRow xrTableRow37;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell76;
    private XRLabel xrLabel9;
    private XRLabel xrLabel10;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public MonthlyReasonReport()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "MonthlyReasonReport.resx";
            System.Resources.ResourceManager resources = global::Resources.MonthlyReasonReport.ResourceManager;
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery5 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery7 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary xrSummary3 = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery6 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery8 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceWT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceOT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceHT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceDIFF = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceUBL = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrLine4 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine6 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable42 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow42 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell129 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.DetailReport1 = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail2 = new DevExpress.XtraReports.UI.DetailBand();
            this.sqlDataSourceFoils = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.ReportFooter1 = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceTT = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable35 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow35 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable15 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.sqlDataSourceSTWISE = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrTable41 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow41 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell128 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable40 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow40 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable39 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow39 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable38 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow38 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable37 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow37 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLabel7,
            this.xrTable1,
            this.xrTable4,
            this.xrTable5,
            this.xrTable6,
            this.xrTable7,
            this.xrTable8,
            this.xrTable14,
            this.xrTable13});
            this.Detail.HeightF = 284.2083F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 258.8333F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "SR NO";
            this.xrTableCell6.Weight = 1.0901243803361946D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "FROM";
            this.xrTableCell7.Weight = 1.7313759472191375D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "TO";
            this.xrTableCell8.Weight = 2.3999998158772859D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "TOTAL";
            this.xrTableCell9.Weight = 2.8784992462158194D;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 235.8333F);
            this.xrLabel7.Multiline = true;
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(500.8333F, 23F);
            this.xrLabel7.StylePriority.UseBorders = false;
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "EFT FOILS USED";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "CLASS";
            this.xrTableCell1.Weight = 1.566666717529297D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "FX FARE";
            this.xrTableCell2.Weight = 1.9083332824707027D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "EX CHG";
            this.xrTableCell4.Weight = 1.5250000000000006D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "UBL";
            this.xrTableCell5.Weight = 1.475D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "TOTAL AMT";
            this.xrTableCell3.Weight = 1.6249993896484369D;
            // 
            // xrTable4
            // 
            this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 24.5F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable4.StylePriority.UseBorders = false;
            this.xrTable4.StylePriority.UseFont = false;
            this.xrTable4.StylePriority.UseTextAlignment = false;
            this.xrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "WT";
            this.xrTableCell16.Weight = 1.566666717529297D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.fxfare")});
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceWT
            // 
            this.sqlDataSourceWT.ConnectionName = "TTReturn";
            this.sqlDataSourceWT.Name = "sqlDataSourceWT";
            customSqlQuery1.Name = "WTSqlQuery";
            customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
            this.sqlDataSourceWT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSourceWT.ResultSchemaSerializable = resources.GetString("sqlDataSourceWT.ResultSchemaSerializable");
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.exchg")});
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Weight = 1.5250000000000006D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.ubl")});
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Weight = 1.475D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceWT, "WTSqlQuery.TotalGST")});
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Weight = 1.6249993896484369D;
            // 
            // xrTable5
            // 
            this.xrTable5.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 49.5F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable5.StylePriority.UseBorders = false;
            this.xrTable5.StylePriority.UseFont = false;
            this.xrTable5.StylePriority.UseTextAlignment = false;
            this.xrTable5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "OT";
            this.xrTableCell21.Weight = 1.566666717529297D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.fxfare")});
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceOT
            // 
            this.sqlDataSourceOT.ConnectionName = "TTReturn";
            this.sqlDataSourceOT.Name = "sqlDataSourceOT";
            customSqlQuery2.Name = "OTSqlQuery";
            customSqlQuery2.Sql = resources.GetString("customSqlQuery2.Sql");
            this.sqlDataSourceOT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSourceOT.ResultSchemaSerializable = resources.GetString("sqlDataSourceOT.ResultSchemaSerializable");
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.exchg")});
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.Weight = 1.5250000000000006D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.ubl")});
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.Weight = 1.475D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceOT, "OTSqlQuery.TotalGST")});
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Weight = 1.6249993896484369D;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 74.5F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable6.StylePriority.UseBorders = false;
            this.xrTable6.StylePriority.UseFont = false;
            this.xrTable6.StylePriority.UseTextAlignment = false;
            this.xrTable6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Text = "HT";
            this.xrTableCell26.Weight = 1.566666717529297D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.fxfare")});
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceHT
            // 
            this.sqlDataSourceHT.ConnectionName = "TTReturn";
            this.sqlDataSourceHT.Name = "sqlDataSourceHT";
            customSqlQuery3.Name = "HTSqlQuery";
            customSqlQuery3.Sql = resources.GetString("customSqlQuery3.Sql");
            this.sqlDataSourceHT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSourceHT.ResultSchemaSerializable = resources.GetString("sqlDataSourceHT.ResultSchemaSerializable");
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.exchg")});
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Weight = 1.5250000000000006D;
            // 
            // xrTableCell29
            // 
            this.xrTableCell29.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.ubl")});
            this.xrTableCell29.Name = "xrTableCell29";
            this.xrTableCell29.Weight = 1.475D;
            // 
            // xrTableCell30
            // 
            this.xrTableCell30.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceHT, "HTSqlQuery.TotalGST")});
            this.xrTableCell30.Name = "xrTableCell30";
            this.xrTableCell30.Weight = 1.6249993896484369D;
            // 
            // xrTable7
            // 
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 99F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable7.StylePriority.UseBorders = false;
            this.xrTable7.StylePriority.UseFont = false;
            this.xrTable7.StylePriority.UseTextAlignment = false;
            this.xrTable7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Text = "DIFF";
            this.xrTableCell31.Weight = 1.566666717529297D;
            // 
            // xrTableCell32
            // 
            this.xrTableCell32.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.fxfare")});
            this.xrTableCell32.Name = "xrTableCell32";
            this.xrTableCell32.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceDIFF
            // 
            this.sqlDataSourceDIFF.ConnectionName = "TTReturn";
            this.sqlDataSourceDIFF.Name = "sqlDataSourceDIFF";
            customSqlQuery4.Name = "DIFFSqlQuery";
            customSqlQuery4.Sql = resources.GetString("customSqlQuery4.Sql");
            this.sqlDataSourceDIFF.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSourceDIFF.ResultSchemaSerializable = resources.GetString("sqlDataSourceDIFF.ResultSchemaSerializable");
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.exchg")});
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Weight = 1.5250000000000006D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.ubl")});
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Weight = 1.475D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceDIFF, "DIFFSqlQuery.TotalGST")});
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Weight = 1.6249993896484369D;
            // 
            // xrTable8
            // 
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(3.051758E-05F, 124F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable8.StylePriority.UseBorders = false;
            this.xrTable8.StylePriority.UseFont = false;
            this.xrTable8.StylePriority.UseTextAlignment = false;
            this.xrTable8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Text = "UBL";
            this.xrTableCell36.Weight = 1.566666717529297D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.fxfare")});
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 1.9083332824707027D;
            // 
            // sqlDataSourceUBL
            // 
            this.sqlDataSourceUBL.ConnectionName = "TTReturn";
            this.sqlDataSourceUBL.Name = "sqlDataSourceUBL";
            customSqlQuery5.Name = "UBLSqlQuery";
            customSqlQuery5.Sql = resources.GetString("customSqlQuery5.Sql");
            this.sqlDataSourceUBL.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery5});
            this.sqlDataSourceUBL.ResultSchemaSerializable = resources.GetString("sqlDataSourceUBL.ResultSchemaSerializable");
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.exchg")});
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 1.5250000000000006D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.ubl")});
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Weight = 1.475D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceUBL, "UBLSqlQuery.TotalGST")});
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Weight = 1.6249993896484369D;
            // 
            // xrTable14
            // 
            this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 173.5F);
            this.xrTable14.Name = "xrTable14";
            this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
            this.xrTable14.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable14.StylePriority.UseBorders = false;
            this.xrTable14.StylePriority.UseFont = false;
            this.xrTable14.StylePriority.UseTextAlignment = false;
            this.xrTable14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Text = "TOTAL";
            this.xrTableCell66.Weight = 1.566666717529297D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Weight = 1.9083332824707027D;
            this.xrTableCell67.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell67_BeforePrint);
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Weight = 1.5250000000000006D;
            this.xrTableCell68.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell68_BeforePrint);
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Weight = 1.475D;
            this.xrTableCell69.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell69_BeforePrint);
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.Weight = 1.6249993896484369D;
            this.xrTableCell70.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrTableCell70_BeforePrint);
            // 
            // xrTable13
            // 
            this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 148.5F);
            this.xrTable13.Name = "xrTable13";
            this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
            this.xrTable13.SizeF = new System.Drawing.SizeF(809.9999F, 25F);
            this.xrTable13.StylePriority.UseBorders = false;
            this.xrTable13.StylePriority.UseFont = false;
            this.xrTable13.StylePriority.UseTextAlignment = false;
            this.xrTable13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Text = "GST";
            this.xrTableCell61.Weight = 1.566666717529297D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Weight = 1.9083332824707027D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Weight = 1.5250000000000006D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Weight = 1.475D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Weight = 1.6249993896484369D;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 20F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 20F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine4,
            this.xrLine6,
            this.xrLine2,
            this.xrLine1,
            this.xrLabel1,
            this.xrLabel2,
            this.xrLabel3,
            this.xrLabel4,
            this.xrLabel5,
            this.xrLabel6,
            this.xrLabel11,
            this.xrLabel12,
            this.xrLabel13,
            this.xrLabel14});
            this.PageHeader.HeightF = 129F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrLine4
            // 
            this.xrLine4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine4.LocationFloat = new DevExpress.Utils.PointFloat(611.9583F, 79.5F);
            this.xrLine4.Name = "xrLine4";
            this.xrLine4.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLine4.StylePriority.UseBorders = false;
            // 
            // xrLine6
            // 
            this.xrLine6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine6.LocationFloat = new DevExpress.Utils.PointFloat(626.4583F, 106F);
            this.xrLine6.Name = "xrLine6";
            this.xrLine6.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLine6.StylePriority.UseBorders = false;
            // 
            // xrLine2
            // 
            this.xrLine2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(63.53809F, 78.5F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(362F, 23F);
            this.xrLine2.StylePriority.UseBorders = false;
            // 
            // xrLine1
            // 
            this.xrLine1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(93.95831F, 106F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(333.5798F, 23.00001F);
            this.xrLine1.StylePriority.UseBorders = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(810F, 23F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BCT DIVISION";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 27.5F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(810F, 23F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "SUMMARY OF MONTHLY RETURNS BY REASON";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 68.5F);
            this.xrLabel3.Multiline = true;
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(67.29163F, 23F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "NAME :";
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 95.00002F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(98.9583F, 22.99999F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.Text = "DESG / HQ :";
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(552.5F, 68.5F);
            this.xrLabel5.Multiline = true;
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(67.29163F, 23F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.Text = "CODE :";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(552.6667F, 95.00002F);
            this.xrLabel6.Multiline = true;
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(79.79163F, 22.99999F);
            this.xrLabel6.StylePriority.UseBorders = false;
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.Text = "MONTH :";
            // 
            // xrLabel11
            // 
            this.xrLabel11.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceTT, "MasterSqlQuery.TTName")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(67.29167F, 68.5F);
            this.xrLabel11.Multiline = true;
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(358.2464F, 23F);
            this.xrLabel11.StylePriority.UseBorders = false;
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(98.9583F, 94.99998F);
            this.xrLabel12.Multiline = true;
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(328.5798F, 23F);
            this.xrLabel12.StylePriority.UseBorders = false;
            this.xrLabel12.StylePriority.UseFont = false;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(609.9583F, 68.5F);
            this.xrLabel13.Multiline = true;
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLabel13.StylePriority.UseBorders = false;
            this.xrLabel13.StylePriority.UseFont = false;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", this.sqlDataSourceTT, "MasterSqlQuery.This")});
            this.xrLabel14.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(625.4583F, 94.99998F);
            this.xrLabel14.Multiline = true;
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(165F, 23F);
            this.xrLabel14.StylePriority.UseBorders = false;
            this.xrLabel14.StylePriority.UseFont = false;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1,
            this.ReportFooter1});
            this.DetailReport.DataMember = "FoilsSqlQuery";
            this.DetailReport.DataSource = this.sqlDataSourceFoils;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable42});
            this.Detail1.HeightF = 25F;
            this.Detail1.Name = "Detail1";
            // 
            // xrTable42
            // 
            this.xrTable42.BackColor = System.Drawing.Color.Transparent;
            this.xrTable42.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable42.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable42.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable42.Name = "xrTable42";
            this.xrTable42.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow42});
            this.xrTable42.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable42.StylePriority.UseBackColor = false;
            this.xrTable42.StylePriority.UseBorders = false;
            this.xrTable42.StylePriority.UseFont = false;
            this.xrTable42.StylePriority.UseTextAlignment = false;
            this.xrTable42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow42
            // 
            this.xrTableRow42.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell129,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell136});
            this.xrTableRow42.Name = "xrTableRow42";
            this.xrTableRow42.Weight = 1D;
            // 
            // xrTableCell129
            // 
            this.xrTableCell129.Name = "xrTableCell129";
            this.xrTableCell129.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0}";
            xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell129.Summary = xrSummary1;
            this.xrTableCell129.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell129.Weight = 0.40374978050230592D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.FromEFTNo")});
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.Weight = 0.64125049690249614D;
            // 
            // xrTableCell133
            // 
            this.xrTableCell133.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.ToEFTNo")});
            this.xrTableCell133.Name = "xrTableCell133";
            this.xrTableCell133.Weight = 0.88888893975152206D;
            // 
            // xrTableCell136
            // 
            this.xrTableCell136.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.Total")});
            this.xrTableCell136.Name = "xrTableCell136";
            this.xrTableCell136.Weight = 1.0661107828436758D;
            // 
            // DetailReport1
            // 
            this.DetailReport1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail2});
            this.DetailReport1.DataMember = "STWISESqlQuery";
            this.DetailReport1.DataSource = this.sqlDataSourceSTWISE;
            this.DetailReport1.Level = 1;
            this.DetailReport1.Name = "DetailReport1";
            // 
            // Detail2
            // 
            this.Detail2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable15});
            this.Detail2.HeightF = 25F;
            this.Detail2.Name = "Detail2";
            // 
            // sqlDataSourceFoils
            // 
            this.sqlDataSourceFoils.ConnectionName = "TTReturn";
            this.sqlDataSourceFoils.Name = "sqlDataSourceFoils";
            customSqlQuery7.Name = "FoilsSqlQuery";
            customSqlQuery7.Sql = "select *,(cast(ToEFTNo as int)-cast(FromEFTNo as int) + 1) as Total from [dbo].[E" +
    "xcessFairRecieptMaster]";
            this.sqlDataSourceFoils.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery7});
            this.sqlDataSourceFoils.ResultSchemaSerializable = resources.GetString("sqlDataSourceFoils.ResultSchemaSerializable");
            // 
            // ReportFooter1
            // 
            this.ReportFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrTable35,
            this.xrTable3});
            this.ReportFooter1.HeightF = 102.125F;
            this.ReportFooter1.Name = "ReportFooter1";
            // 
            // xrTable3
            // 
            this.xrTable3.BackColor = System.Drawing.Color.Transparent;
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(500F, 25F);
            this.xrTable3.StylePriority.UseBackColor = false;
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            this.xrTable3.StylePriority.UseTextAlignment = false;
            this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.StylePriority.UseTextAlignment = false;
            xrSummary2.FormatString = "{0}";
            xrSummary2.Func = DevExpress.XtraReports.UI.SummaryFunc.RecordNumber;
            this.xrTableCell11.Summary = xrSummary2;
            this.xrTableCell11.Text = "TOTAL";
            this.xrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell11.Weight = 0.40374978050230592D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Weight = 0.64125049690249614D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Weight = 0.88888893975152206D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FoilsSqlQuery.Total")});
            this.xrTableCell14.Name = "xrTableCell14";
            xrSummary3.FormatString = "{0:#}";
            xrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            this.xrTableCell14.Summary = xrSummary3;
            this.xrTableCell14.Weight = 1.0661107828436758D;
            // 
            // sqlDataSourceTT
            // 
            this.sqlDataSourceTT.ConnectionName = "TTReturn";
            this.sqlDataSourceTT.Name = "sqlDataSourceTT";
            customSqlQuery6.Name = "MasterSqlQuery";
            customSqlQuery6.Sql = "select tt.Name as TTName,DATENAME(month, GETDATE()) as This from ExcessFairMaster" +
    " efm,TTMaster as tt where efm.TTId=tt.Id and Month(Date)=Month(getdate())";
            this.sqlDataSourceTT.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery6});
            this.sqlDataSourceTT.ResultSchemaSerializable = "PERhdGFTZXQgTmFtZT0ic3FsRGF0YVNvdXJjZVRUIj48VmlldyBOYW1lPSJNYXN0ZXJTcWxRdWVyeSI+P" +
    "EZpZWxkIE5hbWU9IlRUTmFtZSIgVHlwZT0iU3RyaW5nIiAvPjxGaWVsZCBOYW1lPSJUaGlzIiBUeXBlP" +
    "SJTdHJpbmciIC8+PC9WaWV3PjwvRGF0YVNldD4=";
            // 
            // xrLabel8
            // 
            this.xrLabel8.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(0.0001271566F, 54.12502F);
            this.xrLabel8.Multiline = true;
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(235.5F, 23F);
            this.xrLabel8.StylePriority.UseBorders = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "STATIONWISE REMITANCE";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable35
            // 
            this.xrTable35.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable35.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable35.LocationFloat = new DevExpress.Utils.PointFloat(0F, 77.12498F);
            this.xrTable35.Name = "xrTable35";
            this.xrTable35.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow35});
            this.xrTable35.SizeF = new System.Drawing.SizeF(235.5F, 25F);
            this.xrTable35.StylePriority.UseBorders = false;
            this.xrTable35.StylePriority.UseFont = false;
            this.xrTable35.StylePriority.UseTextAlignment = false;
            this.xrTable35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow35
            // 
            this.xrTableRow35.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell150,
            this.xrTableCell151});
            this.xrTableRow35.Name = "xrTableRow35";
            this.xrTableRow35.Weight = 1D;
            // 
            // xrTableCell150
            // 
            this.xrTableCell150.Name = "xrTableCell150";
            this.xrTableCell150.Text = "STATION";
            this.xrTableCell150.Weight = 4.2157873618418478D;
            // 
            // xrTableCell151
            // 
            this.xrTableCell151.Name = "xrTableCell151";
            this.xrTableCell151.Text = "AMOUNT";
            this.xrTableCell151.Weight = 3.8842120278065897D;
            // 
            // xrTable15
            // 
            this.xrTable15.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable15.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable15.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable15.Name = "xrTable15";
            this.xrTable15.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow15});
            this.xrTable15.SizeF = new System.Drawing.SizeF(235.5F, 25F);
            this.xrTable15.StylePriority.UseBorders = false;
            this.xrTable15.StylePriority.UseFont = false;
            this.xrTable15.StylePriority.UseTextAlignment = false;
            this.xrTable15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell71});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "STWISESqlQuery.StationName")});
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Weight = 4.2157873618418478D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "STWISESqlQuery.Total")});
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Weight = 3.8842120278065897D;
            // 
            // sqlDataSourceSTWISE
            // 
            this.sqlDataSourceSTWISE.ConnectionName = "TTReturn";
            this.sqlDataSourceSTWISE.Name = "sqlDataSourceSTWISE";
            customSqlQuery8.Name = "STWISESqlQuery";
            customSqlQuery8.Sql = "SELECT StationName, SUM(cast(Amount as int)) AS Total FROM ExcessFairRecieptMaste" +
    "r where MONTH(Date) = MONTH(getdate()) GROUP BY StationName";
            this.sqlDataSourceSTWISE.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery8});
            this.sqlDataSourceSTWISE.ResultSchemaSerializable = resources.GetString("sqlDataSourceSTWISE.ResultSchemaSerializable");
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable41,
            this.xrTable40,
            this.xrTable39,
            this.xrTable38,
            this.xrTable37,
            this.xrLabel9,
            this.xrLabel10});
            this.PageFooter.HeightF = 124.4999F;
            this.PageFooter.Name = "PageFooter";
            // 
            // xrTable41
            // 
            this.xrTable41.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable41.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable41.LocationFloat = new DevExpress.Utils.PointFloat(0F, 71.09084F);
            this.xrTable41.Name = "xrTable41";
            this.xrTable41.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow41});
            this.xrTable41.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable41.StylePriority.UseBorders = false;
            this.xrTable41.StylePriority.UseFont = false;
            this.xrTable41.StylePriority.UseTextAlignment = false;
            this.xrTable41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow41
            // 
            this.xrTableRow41.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell125,
            this.xrTableCell128});
            this.xrTableRow41.Name = "xrTableRow41";
            this.xrTableRow41.Weight = 1D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.StylePriority.UseTextAlignment = false;
            this.xrTableCell125.Text = "MR";
            this.xrTableCell125.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell125.Weight = 4.2157864981866053D;
            // 
            // xrTableCell128
            // 
            this.xrTableCell128.Name = "xrTableCell128";
            this.xrTableCell128.Weight = 3.8842128914618312D;
            // 
            // xrTable40
            // 
            this.xrTable40.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable40.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable40.LocationFloat = new DevExpress.Utils.PointFloat(0F, 46.09084F);
            this.xrTable40.Name = "xrTable40";
            this.xrTable40.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow40});
            this.xrTable40.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable40.StylePriority.UseBorders = false;
            this.xrTable40.StylePriority.UseFont = false;
            this.xrTable40.StylePriority.UseTextAlignment = false;
            this.xrTable40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow40
            // 
            this.xrTableRow40.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell105,
            this.xrTableCell120});
            this.xrTableRow40.Name = "xrTableRow40";
            this.xrTableRow40.Weight = 1D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.StylePriority.UseTextAlignment = false;
            this.xrTableCell105.Text = "EFT CANCELLED FOILS";
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell105.Weight = 4.2157864981866053D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Weight = 3.8842128914618312D;
            // 
            // xrTable39
            // 
            this.xrTable39.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable39.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable39.LocationFloat = new DevExpress.Utils.PointFloat(0F, 21.59098F);
            this.xrTable39.Name = "xrTable39";
            this.xrTable39.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow39});
            this.xrTable39.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable39.StylePriority.UseBorders = false;
            this.xrTable39.StylePriority.UseFont = false;
            this.xrTable39.StylePriority.UseTextAlignment = false;
            this.xrTable39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow39
            // 
            this.xrTableRow39.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell85,
            this.xrTableCell100});
            this.xrTableRow39.Name = "xrTableRow39";
            this.xrTableRow39.Weight = 1D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.Text = "EFT FOILS USED:";
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell85.Weight = 4.2157864981866053D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Weight = 3.8842128914618312D;
            // 
            // xrTable38
            // 
            this.xrTable38.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable38.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable38.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable38.Name = "xrTable38";
            this.xrTable38.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow38});
            this.xrTable38.SizeF = new System.Drawing.SizeF(388.1482F, 25F);
            this.xrTable38.StylePriority.UseBorders = false;
            this.xrTable38.StylePriority.UseFont = false;
            this.xrTable38.StylePriority.UseTextAlignment = false;
            this.xrTable38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow38
            // 
            this.xrTableRow38.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell77,
            this.xrTableCell80});
            this.xrTableRow38.Name = "xrTableRow38";
            this.xrTableRow38.Weight = 1D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.Text = "FORMS USED :";
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell77.Weight = 4.2157864981866053D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Weight = 3.8842128914618312D;
            // 
            // xrTable37
            // 
            this.xrTable37.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable37.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrTable37.LocationFloat = new DevExpress.Utils.PointFloat(0F, 96.09084F);
            this.xrTable37.Name = "xrTable37";
            this.xrTable37.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow37});
            this.xrTable37.SizeF = new System.Drawing.SizeF(388.1483F, 25F);
            this.xrTable37.StylePriority.UseBorders = false;
            this.xrTable37.StylePriority.UseFont = false;
            this.xrTable37.StylePriority.UseTextAlignment = false;
            this.xrTable37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableRow37
            // 
            this.xrTableRow37.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell76});
            this.xrTableRow37.Name = "xrTableRow37";
            this.xrTableRow37.Weight = 1D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "TOTAL";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell10.Weight = 4.2157873618418478D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Weight = 3.8842120278065897D;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(438.3229F, 85.49993F);
            this.xrLabel9.Multiline = true;
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(159.6666F, 23F);
            this.xrLabel9.StylePriority.UseBorders = false;
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "CTI\'s SIGN";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(645.448F, 85.49993F);
            this.xrLabel10.Multiline = true;
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(159.6666F, 23F);
            this.xrLabel10.StylePriority.UseBorders = false;
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "TE\'s SIGN";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // MonthlyReasonReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageHeader,
            this.DetailReport,
            this.DetailReport1,
            this.PageFooter});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSourceWT,
            this.sqlDataSourceOT,
            this.sqlDataSourceHT,
            this.sqlDataSourceDIFF,
            this.sqlDataSourceUBL,
            this.sqlDataSourceFoils,
            this.sqlDataSourceTT,
            this.sqlDataSourceSTWISE});
            this.Margins = new System.Drawing.Printing.Margins(20, 20, 20, 20);
            this.Version = "15.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private void xrTableCell67_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell17.Text != "" ? Convert.ToInt32(xrTableCell17.Text) : 0;
        int ot = xrTableCell22.Text != "" ? Convert.ToInt32(xrTableCell22.Text) : 0;
        int ht = xrTableCell27.Text != "" ? Convert.ToInt32(xrTableCell27.Text) : 0;
        int diff = xrTableCell32.Text != "" ? Convert.ToInt32(xrTableCell32.Text) : 0;
        int ubl = xrTableCell37.Text != "" ? Convert.ToInt32(xrTableCell37.Text) : 0;


        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell68_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell18.Text != "" ? Convert.ToInt32(xrTableCell18.Text) : 0;
        int ot = xrTableCell23.Text != "" ? Convert.ToInt32(xrTableCell23.Text) : 0;
        int ht = xrTableCell28.Text != "" ? Convert.ToInt32(xrTableCell28.Text) : 0;
        int diff = xrTableCell33.Text != "" ? Convert.ToInt32(xrTableCell33.Text) : 0;
        int ubl = xrTableCell38.Text != "" ? Convert.ToInt32(xrTableCell38.Text) : 0;


        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell69_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell19.Text != "" ? Convert.ToInt32(xrTableCell19.Text) : 0;
        int ot = xrTableCell24.Text != "" ? Convert.ToInt32(xrTableCell24.Text) : 0;
        int ht = xrTableCell29.Text != "" ? Convert.ToInt32(xrTableCell29.Text) : 0;
        int diff = xrTableCell34.Text != "" ? Convert.ToInt32(xrTableCell34.Text) : 0;
        int ubl = xrTableCell39.Text != "" ? Convert.ToInt32(xrTableCell39.Text) : 0;

        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }

    private void xrTableCell70_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        int wt = xrTableCell20.Text != "" ? Convert.ToInt32(xrTableCell20.Text) : 0;
        int ot = xrTableCell25.Text != "" ? Convert.ToInt32(xrTableCell25.Text) : 0;
        int ht = xrTableCell30.Text != "" ? Convert.ToInt32(xrTableCell30.Text) : 0;
        int diff = xrTableCell35.Text != "" ? Convert.ToInt32(xrTableCell35.Text) : 0;
        int ubl = xrTableCell40.Text != "" ? Convert.ToInt32(xrTableCell40.Text) : 0;

        XRTableCell cell = sender as XRTableCell;

        int value = wt + ot + ht + diff + ubl;

        cell.Text = value.ToString();
    }
}
>>>>>>> 58cb8ea43cf39064a4f8cc3859d9e0195460db3d
