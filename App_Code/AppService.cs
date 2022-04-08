<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Linq;

/// <summary>
/// Summary description for AppService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AppService : System.Web.Services.WebService
{
    string websiteclient = "";
    string website = "";

    SqlConnection cn = new SqlConnection("Data Source=103.87.173.217;Initial Catalog=TTReturn;uid=itfuturz;pwd=MyNewOffice@2020;");
    GetData D = new GetData();
    Connection cc = new Connection();
    public AppService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public void login(string type, string username, string password)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TTMaster> list = new List<TTMaster>();
        List<GeneralDataUser> g = new List<GeneralDataUser>();
        if (type == "login")
        {
            try
            {
                DataTable dt = D.GetDataTable("select tt.*,st.StationName,(select Name from TTMaster where Id=tt.SquadHeadId and IsSquadHead=1) as TTSquadName from TTMaster as tt, StationMaster as st where UserName='" + username + "' and Password='" + password + "'");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataUser data = new GeneralDataUser();
                    TTMaster t = new TTMaster();

                    t.Id = dt.Rows[i]["Id"].ToString();
                    t.Name = dt.Rows[i]["Name"].ToString();
                    t.MobileNo = dt.Rows[i]["MobileNo"].ToString();
                    t.IsSquadHead = Convert.ToBoolean(dt.Rows[i]["IsSquadHead"].ToString());
                    t.UserName = dt.Rows[i]["UserName"].ToString();
                    t.Password = dt.Rows[i]["Password"].ToString();
                    t.StationName = dt.Rows[i]["StationName"].ToString();
                    t.SquadHeadName = dt.Rows[i]["TTSquadName"].ToString();

                    list.Add(t);

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataUser data = new GeneralDataUser();
                    data.MESSAGE = "User not Registered!";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataUser data = new GeneralDataUser();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void ReasonMaster(string type)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<ReasonMaster> list = new List<ReasonMaster>();
        List<GeneralDataReason> g = new List<GeneralDataReason>();
        if (type == "reason")
        {
            try
            {
                DataTable dt = D.GetDataTable("select * from ChargeReasonMaster");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataReason data = new GeneralDataReason();

                    foreach (DataRow dr in dt.Rows)
                    {
                        ReasonMaster r = new ReasonMaster();
                        r.Id = dr["Id"].ToString();
                        r.Name = dr["Name"].ToString();
                        r.ShortCode = dr["ShortCode"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataReason data = new GeneralDataReason();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataReason data = new GeneralDataReason();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void TrainClassMaster(string type)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TrainClassMaster> list = new List<TrainClassMaster>();
        List<GeneralDataTrainClass> g = new List<GeneralDataTrainClass>();
        if (type == "trainclass")
        {
            try
            {
                DataTable dt = D.GetDataTable("select * from TrainClassMaster");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataTrainClass data = new GeneralDataTrainClass();

                    foreach (DataRow dr in dt.Rows)
                    {
                        TrainClassMaster r = new TrainClassMaster();
                        r.Id = dr["Id"].ToString();
                        r.Name = dr["ClassName"].ToString();
                        list.Add(r);
                    }


                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataTrainClass data = new GeneralDataTrainClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataTrainClass data = new GeneralDataTrainClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertExcessFairMaster(string type, string eftno, string date, string collectedon, string trainno, string fromstation, string tostation, string ticketno, string weight, string weightcharge, string fareamount, string excesscharge, string total, string cgst, string sgst, string igst, string ugst, string totalwithtax, string reasonid, string classid, string TTId, string stationName, string passengers, string avlFromStation, string avlToStation, string avlClassId, string ismodified, string modifieddate, string gstno)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "excess")
        {
            try
            {
                string modifyDate = modifieddate != "" ? Convert.ToDateTime(modifieddate).ToString() : "";
                string qry = "insert into ExcessFairMaster(EFTNo,Date,CollectedOn,TrainNo,FromStation,ToStation,TicketNo,Weight,WeightCharge,FareAmount,ExcessCharge,Total,CGST,SGST,IGST,UGST,TotalwithGST,ReasonId,ClassId,TTId,StationName,Passengers,AvlFromStation,AvlToStation,AvlClassId,ismodified,modifieddate,gstno) values('" + eftno + "','" + Convert.ToDateTime(date) + "','" + collectedon + "','" + trainno + "','" + fromstation + "','" + tostation + "','" + ticketno + "','" + weight + "','" + weightcharge + "','" + fareamount + "','" + excesscharge + "','" + total + "','" + cgst + "','" + sgst + "','" + igst + "','" + ugst + "','" + totalwithtax + "','" + reasonid + "','" + classid + "','" + Convert.ToInt32(TTId) + "','" + stationName + "','" + passengers + "','" + avlFromStation + "','" + avlToStation + "','" + Convert.ToInt32(avlClassId) + "'," + ismodified + ",'" + modifyDate + "','" + gstno + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertExcessFairRecieptMaster(string type, string station, string mrno, string date, string amount, string utsno, string fromeftno, string toeftno, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "excessreciept")
        {
            try
            {
                string qry = "insert into ExcessFairRecieptMaster(stationname,mrno,date,amount,utsno,fromeftno,toeftno,TTId) values('" + station + "','" + mrno + "','" + Convert.ToDateTime(date) + "','" + amount + "','" + utsno + "','" + fromeftno + "','" + toeftno + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertTAMaster(string type, string date, string TrainNo, string TimeLeft, string TimeArrived, string FromStation, string ToStation, string Pecentage, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "tamaster")
        {
            try
            {
                string qry = "insert into TAMaster(date,TrainNo,TimeLeft,TimeArrived,FromStation,ToStation,Pecentage,Remark,TTId) values('" + Convert.ToDateTime(date) + "','" + TrainNo + "','" + Convert.ToDateTime(TimeLeft) + "','" + Convert.ToDateTime(TimeArrived) + "','" + FromStation + "','" + ToStation + "','" + Pecentage + "','" + Remark + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertNDAMaster(string type, string date, string TrainNo, string FromStation, string ToStation, string OnDutyTime, string OffDutyTime, string DutyHours, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "ndamaster")
        {
            try
            {
                string qry = "insert into NDAMaster(date,TrainNo,FromStation,ToStation,OnDutyTime,OffDutyTime,DutyHours,Remark,TTId) values('" + Convert.ToDateTime(date) + "','" + TrainNo + "','" + FromStation + "','" + ToStation + "','" + Convert.ToDateTime(OnDutyTime) + "','" + Convert.ToDateTime(OffDutyTime) + "','" + DutyHours + "','" + Remark + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);


                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    public void UpdateExcessFairMaster(string type, string Id, string eftno, string date, string collectedon, string trainno, string fromstation, string tostation, string ticketno, string weight, string weightcharge, string fareamount, string excesscharge, string total, string cgst, string sgst, string igst, string ugst, string totalwithtax, string reasonid, string classid, string TTId, string stationName, string passengers, string avlFromStation, string avlToStation, string avlClassId, string ismodified, string modifieddate, string gstno)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upexcess")
        {
            try
            {
                string qry = "Update table ExcessFairMaster set EFTNo='" + eftno + "',Date='" + Convert.ToDateTime(date) + "',CollectedOn='" + collectedon + "',TrainNo='" + trainno + "',FromStation='" + fromstation + "',ToStation='" + tostation + "',TicketNo='" + ticketno + "',Weight='" + weight + "',WeightCharge='" + weightcharge + "',FareAmount='" + fareamount + "',ExcessCharge='" + excesscharge + "',Total='" + total + "',CGST='" + cgst + "',SGST='" + sgst + "',IGST='" + igst + "',UGST='" + ugst + "',TotalwithGST='" + totalwithtax + "',ReasonId='" + reasonid + "',ClassId='" + classid + "',TTId='" + Convert.ToInt32(TTId) + "',StationName='" + stationName + "',Passengers='" + passengers + "',AvlFromStation='" + avlFromStation + "',AvlToStation='" + avlToStation + "',AvlClassId='" + Convert.ToInt32(avlClassId) + "',ismodified=" + ismodified + ",modifieddate='" + Convert.ToDateTime(modifieddate) + "',gstno='" + gstno + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateExcessFairRecieptMaster(string type, string Id, string station, string mrno, string date, string amount, string utsno, string fromeftno, string toeftno, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upexcessreciept")
        {
            try
            {
                string qry = "Update table ExcessFairRecieptMaster set stationname='" + station + "',mrno='" + mrno + "',date='" + Convert.ToDateTime(date) + "',amount='" + amount + "',utsno='" + utsno + "',fromeftno='" + fromeftno + "',toeftno='" + toeftno + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateTAMaster(string type, string Id, string date, string TrainNo, string TimeLeft, string TimeArrived, string FromStation, string ToStation, string Pecentage, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "uptamaster")
        {
            try
            {
                string qry = "Update table TAMaster set date='" + Convert.ToDateTime(date) + "',TrainNo='" + TrainNo + "',TimeLeft='" + Convert.ToDateTime(TimeLeft) + "',TimeArrived='" + Convert.ToDateTime(TimeArrived) + "',FromStation='" + FromStation + "',ToStation='" + ToStation + "',Pecentage='" + Pecentage + "',Remark='" + Remark + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateNDAMaster(string type, string Id, string date, string TrainNo, string FromStation, string ToStation, string OnDutyTime, string OffDutyTime, string DutyHours, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upndamaster")
        {
            try
            {
                string qry = "Update table NDAMaster set date='" + Convert.ToDateTime(date) + "',TrainNo='" + TrainNo + "',FromStation='" + FromStation + "',ToStation='" + ToStation + "',OnDutyTime='" + Convert.ToDateTime(OnDutyTime).ToShortTimeString() + "',OffDutyTime='" + Convert.ToDateTime(OffDutyTime).ToShortTimeString() + "',DutyHours='" + Convert.ToDateTime(DutyHours).ToShortTimeString() + "',Remark='" + Remark + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully Update !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFMById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTData> list = new List<EFTData>();
        List<GeneralDataEFTClass> g = new List<GeneralDataEFTClass>();
        if (type == "efmbyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("SELECT efm.*,crm.name,tcm.ClassName,tt.Name as TTName,crm.Name,tcm.ClassName,(select classname from TrainclassMaster where Id=avlclassid) as AvlClass FROM ExcessFairMaster efm, ChargeReasonMaster crm, TrainClassMaster tcm, TTMaster tt WHERE efm.ReasonId=crm.Id and efm.ClassId=tcm.Id and efm.TTId=tt.Id and TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataEFTClass data = new GeneralDataEFTClass();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        EFTData r = new EFTData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.EFTNo = dt.Rows[j]["EFTNo"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.CollectedOn = dt.Rows[j]["CollectedOn"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.TicketNo = dt.Rows[j]["TicketNo"].ToString();
                        r.Weight = dt.Rows[j]["Weight"].ToString();
                        r.WeightCharge = dt.Rows[j]["WeightCharge"].ToString();
                        r.FareAmount = dt.Rows[j]["FareAmount"].ToString();
                        r.ExcessCharge = dt.Rows[j]["ExcessCharge"].ToString();
                        r.Total = dt.Rows[j]["Total"].ToString();
                        r.CGST = dt.Rows[j]["CGST"].ToString();
                        r.SGST = dt.Rows[j]["SGST"].ToString();
                        r.IGST = dt.Rows[j]["IGST"].ToString();
                        r.UGST = dt.Rows[j]["UGST"].ToString();
                        r.TotalwithGST = dt.Rows[j]["TotalwithGST"].ToString();
                        r.name = dt.Rows[j]["name"].ToString();
                        r.ClassName = dt.Rows[j]["ClassName"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        r.StationName = dt.Rows[j]["StationName"].ToString();
                        r.Passengers = dt.Rows[j]["Passengers"].ToString();
                        r.AvlFromStation = dt.Rows[j]["AvlFromStation"].ToString();
                        r.AvlToStation = dt.Rows[j]["AvlToStation"].ToString();
                        r.AvlClass = dt.Rows[j]["AvlClass"].ToString();
                        r.GSTNo = dt.Rows[j]["GSTNo"].ToString();

                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTClass data = new GeneralDataEFTClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataEFTClass data = new GeneralDataEFTClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFTrById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTRData> list = new List<EFTRData>();
        List<GeneralDataEFTRClass> g = new List<GeneralDataEFTRClass>();
        if (type == "eftrbyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select efr.*,tt.Name as TTName from ExcessFairRecieptMaster efr,TTMaster tt where efr.TTId=tt.Id and efr.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataEFTRClass data = new GeneralDataEFTRClass();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        EFTRData r = new EFTRData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.StationName = dt.Rows[j]["StationName"].ToString();
                        r.MRNo = dt.Rows[j]["MRNo"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.Amount = dt.Rows[j]["Amount"].ToString();
                        r.UTSNo = dt.Rows[j]["UTSNo"].ToString();
                        r.FromEftNo = dt.Rows[j]["FromEftNo"].ToString();
                        r.ToEftNo = dt.Rows[j]["ToEftNo"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTRClass data = new GeneralDataEFTRClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataEFTRClass data = new GeneralDataEFTRClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetTAById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TAData> list = new List<TAData>();
        List<GeneralDataTAData> g = new List<GeneralDataTAData>();
        if (type == "tabyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select ta.*,tt.Name as TTName from TAMaster ta,TTMaster tt where ta.TTId=tt.Id and ta.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataTAData data = new GeneralDataTAData();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        TAData r = new TAData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.TimeLeft = dt.Rows[j]["TimeLeft"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.TimeArrived = dt.Rows[j]["TimeArrived"].ToString();
                        r.Pecentage = dt.Rows[j]["Pecentage"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataTAData data = new GeneralDataTAData();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataTAData data = new GeneralDataTAData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetNDAById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<NDAData> list = new List<NDAData>();
        List<GeneralDataNDAData> g = new List<GeneralDataNDAData>();
        if (type == "ndabyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select nda.*,tt.Name as TTName from NDAMaster nda,TTMaster tt where nda.TTId=tt.Id and nda.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataNDAData data = new GeneralDataNDAData();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        NDAData r = new NDAData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.OnDutyTime = dt.Rows[j]["OnDutyTime"].ToString();
                        r.OffDutyTime = dt.Rows[j]["OffDutyTime"].ToString();
                        r.DutyHours = dt.Rows[j]["DutyHours"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataNDAData data = new GeneralDataNDAData();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataNDAData data = new GeneralDataNDAData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFMCount(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTCount> list = new List<EFTCount>();
        List<GeneralDataEFTCount> g = new List<GeneralDataEFTCount>();
        if (type == "efmcount")
        {
            try
            {
                DataTable dt = D.GetDataTable("select (SELECT DATEADD(DAY, 2 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))) [Week_Start_Date], (SELECT DATEADD(DAY, 8 -DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))) [Week_End_Date]");
                if (dt.Rows.Count > 0)
                {
                    string startdate = Convert.ToDateTime(dt.Rows[0]["Week_Start_Date"]).ToString("yyyy-MM-dd");
                    string enddate = Convert.ToDateTime(dt.Rows[0]["Week_End_Date"]).ToString("yyyy-MM-dd");

                    EFTCount r = new EFTCount();
                    GeneralDataEFTCount data = new GeneralDataEFTCount();

                    //string qry = "select (select count(*) from ExcessFairMaster where Date between '2019-01-03' and '2019-01-05' and TTId=" + Id + ") WeekCount,(SELECT count(*) FROM ExcessFairMaster WHERE MONTH(Date) = MONTH(getdate()) and TTId=" + Id + ") MonthCount";

                    string qry = "select (select sum(cast(TotalwithGST as decimal)) from ExcessFairMaster where Date between '" + startdate + "' and '" + enddate + "' and TTId=" + Id + ") WeekCount,(SELECT sum(cast(TotalwithGST as decimal)) as Total FROM ExcessFairMaster WHERE MONTH(Date) = MONTH(getdate()) and TTId=" + Id + ") MonthCount";

                    DataTable dts = D.GetDataTable(qry);
                    if (dt.Rows.Count > 0)
                    {
                        r.weekCount = dts.Rows[0]["WeekCount"].ToString();
                        r.monthCount = dts.Rows[0]["MonthCount"].ToString();

                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTCount data = new GeneralDataEFTCount();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataEFTCount data = new GeneralDataEFTCount();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.IO;
using System.Net.NetworkInformation;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Linq;

/// <summary>
/// Summary description for AppService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class AppService : System.Web.Services.WebService
{
    string websiteclient = "";
    string website = "";

    SqlConnection cn = new SqlConnection("Data Source=103.87.173.217;Initial Catalog=TTReturn;uid=itfuturz;pwd=MyNewOffice@2020;");
    GetData D = new GetData();
    Connection cc = new Connection();
    public AppService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }
    [WebMethod]
    public void login(string type, string username, string password)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TTMaster> list = new List<TTMaster>();
        List<GeneralDataUser> g = new List<GeneralDataUser>();
        if (type == "login")
        {
            try
            {
                DataTable dt = D.GetDataTable("select tt.*,st.StationName,(select Name from TTMaster where Id=tt.SquadHeadId and IsSquadHead=1) as TTSquadName from TTMaster as tt, StationMaster as st where UserName='" + username + "' and Password='" + password + "'");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataUser data = new GeneralDataUser();
                    TTMaster t = new TTMaster();

                    t.Id = dt.Rows[i]["Id"].ToString();
                    t.Name = dt.Rows[i]["Name"].ToString();
                    t.MobileNo = dt.Rows[i]["MobileNo"].ToString();
                    t.IsSquadHead = Convert.ToBoolean(dt.Rows[i]["IsSquadHead"].ToString());
                    t.UserName = dt.Rows[i]["UserName"].ToString();
                    t.Password = dt.Rows[i]["Password"].ToString();
                    t.StationName = dt.Rows[i]["StationName"].ToString();
                    t.SquadHeadName = dt.Rows[i]["TTSquadName"].ToString();

                    list.Add(t);

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataUser data = new GeneralDataUser();
                    data.MESSAGE = "User not Registered!";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataUser data = new GeneralDataUser();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void ReasonMaster(string type)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<ReasonMaster> list = new List<ReasonMaster>();
        List<GeneralDataReason> g = new List<GeneralDataReason>();
        if (type == "reason")
        {
            try
            {
                DataTable dt = D.GetDataTable("select * from ChargeReasonMaster");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataReason data = new GeneralDataReason();

                    foreach (DataRow dr in dt.Rows)
                    {
                        ReasonMaster r = new ReasonMaster();
                        r.Id = dr["Id"].ToString();
                        r.Name = dr["Name"].ToString();
                        r.ShortCode = dr["ShortCode"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataReason data = new GeneralDataReason();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataReason data = new GeneralDataReason();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void TrainClassMaster(string type)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TrainClassMaster> list = new List<TrainClassMaster>();
        List<GeneralDataTrainClass> g = new List<GeneralDataTrainClass>();
        if (type == "trainclass")
        {
            try
            {
                DataTable dt = D.GetDataTable("select * from TrainClassMaster");
                if (dt.Rows.Count > 0)
                {
                    GeneralDataTrainClass data = new GeneralDataTrainClass();

                    foreach (DataRow dr in dt.Rows)
                    {
                        TrainClassMaster r = new TrainClassMaster();
                        r.Id = dr["Id"].ToString();
                        r.Name = dr["ClassName"].ToString();
                        list.Add(r);
                    }


                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataTrainClass data = new GeneralDataTrainClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataTrainClass data = new GeneralDataTrainClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertExcessFairMaster(string type, string eftno, string date, string collectedon, string trainno, string fromstation, string tostation, string ticketno, string weight, string weightcharge, string fareamount, string excesscharge, string total, string cgst, string sgst, string igst, string ugst, string totalwithtax, string reasonid, string classid, string TTId, string stationName, string passengers, string avlFromStation, string avlToStation, string avlClassId, string ismodified, string modifieddate, string gstno)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "excess")
        {
            try
            {
                string modifyDate = modifieddate != "" ? Convert.ToDateTime(modifieddate).ToString() : "";
                string qry = "insert into ExcessFairMaster(EFTNo,Date,CollectedOn,TrainNo,FromStation,ToStation,TicketNo,Weight,WeightCharge,FareAmount,ExcessCharge,Total,CGST,SGST,IGST,UGST,TotalwithGST,ReasonId,ClassId,TTId,StationName,Passengers,AvlFromStation,AvlToStation,AvlClassId,ismodified,modifieddate,gstno) values('" + eftno + "','" + Convert.ToDateTime(date) + "','" + collectedon + "','" + trainno + "','" + fromstation + "','" + tostation + "','" + ticketno + "','" + weight + "','" + weightcharge + "','" + fareamount + "','" + excesscharge + "','" + total + "','" + cgst + "','" + sgst + "','" + igst + "','" + ugst + "','" + totalwithtax + "','" + reasonid + "','" + classid + "','" + Convert.ToInt32(TTId) + "','" + stationName + "','" + passengers + "','" + avlFromStation + "','" + avlToStation + "','" + Convert.ToInt32(avlClassId) + "'," + ismodified + ",'" + modifyDate + "','" + gstno + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertExcessFairRecieptMaster(string type, string station, string mrno, string date, string amount, string utsno, string fromeftno, string toeftno, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "excessreciept")
        {
            try
            {
                string qry = "insert into ExcessFairRecieptMaster(stationname,mrno,date,amount,utsno,fromeftno,toeftno,TTId) values('" + station + "','" + mrno + "','" + Convert.ToDateTime(date) + "','" + amount + "','" + utsno + "','" + fromeftno + "','" + toeftno + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertTAMaster(string type, string date, string TrainNo, string TimeLeft, string TimeArrived, string FromStation, string ToStation, string Pecentage, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "tamaster")
        {
            try
            {
                string qry = "insert into TAMaster(date,TrainNo,TimeLeft,TimeArrived,FromStation,ToStation,Pecentage,Remark,TTId) values('" + Convert.ToDateTime(date) + "','" + TrainNo + "','" + Convert.ToDateTime(TimeLeft) + "','" + Convert.ToDateTime(TimeArrived) + "','" + FromStation + "','" + ToStation + "','" + Pecentage + "','" + Remark + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void InsertNDAMaster(string type, string date, string TrainNo, string FromStation, string ToStation, string OnDutyTime, string OffDutyTime, string DutyHours, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "ndamaster")
        {
            try
            {
                string qry = "insert into NDAMaster(date,TrainNo,FromStation,ToStation,OnDutyTime,OffDutyTime,DutyHours,Remark,TTId) values('" + Convert.ToDateTime(date) + "','" + TrainNo + "','" + FromStation + "','" + ToStation + "','" + Convert.ToDateTime(OnDutyTime) + "','" + Convert.ToDateTime(OffDutyTime) + "','" + DutyHours + "','" + Remark + "','" + Convert.ToInt32(TTId) + "')";
                D.ExecuteQuery(qry);


                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    public void UpdateExcessFairMaster(string type, string Id, string eftno, string date, string collectedon, string trainno, string fromstation, string tostation, string ticketno, string weight, string weightcharge, string fareamount, string excesscharge, string total, string cgst, string sgst, string igst, string ugst, string totalwithtax, string reasonid, string classid, string TTId, string stationName, string passengers, string avlFromStation, string avlToStation, string avlClassId, string ismodified, string modifieddate, string gstno)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upexcess")
        {
            try
            {
                string qry = "Update table ExcessFairMaster set EFTNo='" + eftno + "',Date='" + Convert.ToDateTime(date) + "',CollectedOn='" + collectedon + "',TrainNo='" + trainno + "',FromStation='" + fromstation + "',ToStation='" + tostation + "',TicketNo='" + ticketno + "',Weight='" + weight + "',WeightCharge='" + weightcharge + "',FareAmount='" + fareamount + "',ExcessCharge='" + excesscharge + "',Total='" + total + "',CGST='" + cgst + "',SGST='" + sgst + "',IGST='" + igst + "',UGST='" + ugst + "',TotalwithGST='" + totalwithtax + "',ReasonId='" + reasonid + "',ClassId='" + classid + "',TTId='" + Convert.ToInt32(TTId) + "',StationName='" + stationName + "',Passengers='" + passengers + "',AvlFromStation='" + avlFromStation + "',AvlToStation='" + avlToStation + "',AvlClassId='" + Convert.ToInt32(avlClassId) + "',ismodified=" + ismodified + ",modifieddate='" + Convert.ToDateTime(modifieddate) + "',gstno='" + gstno + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateExcessFairRecieptMaster(string type, string Id, string station, string mrno, string date, string amount, string utsno, string fromeftno, string toeftno, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upexcessreciept")
        {
            try
            {
                string qry = "Update table ExcessFairRecieptMaster set stationname='" + station + "',mrno='" + mrno + "',date='" + Convert.ToDateTime(date) + "',amount='" + amount + "',utsno='" + utsno + "',fromeftno='" + fromeftno + "',toeftno='" + toeftno + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateTAMaster(string type, string Id, string date, string TrainNo, string TimeLeft, string TimeArrived, string FromStation, string ToStation, string Pecentage, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "uptamaster")
        {
            try
            {
                string qry = "Update table TAMaster set date='" + Convert.ToDateTime(date) + "',TrainNo='" + TrainNo + "',TimeLeft='" + Convert.ToDateTime(TimeLeft) + "',TimeArrived='" + Convert.ToDateTime(TimeArrived) + "',FromStation='" + FromStation + "',ToStation='" + ToStation + "',Pecentage='" + Pecentage + "',Remark='" + Remark + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void UpdateNDAMaster(string type, string Id, string date, string TrainNo, string FromStation, string ToStation, string OnDutyTime, string OffDutyTime, string DutyHours, string Remark, string TTId)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        List<GeneralData> g = new List<GeneralData>();
        if (type == "upndamaster")
        {
            try
            {
                string qry = "Update table NDAMaster set date='" + Convert.ToDateTime(date) + "',TrainNo='" + TrainNo + "',FromStation='" + FromStation + "',ToStation='" + ToStation + "',OnDutyTime='" + Convert.ToDateTime(OnDutyTime).ToShortTimeString() + "',OffDutyTime='" + Convert.ToDateTime(OffDutyTime).ToShortTimeString() + "',DutyHours='" + Convert.ToDateTime(DutyHours).ToShortTimeString() + "',Remark='" + Remark + "',TTId='" + Convert.ToInt32(TTId) + "' where Id=" + Id;
                D.ExecuteQuery(qry);

                GeneralData data = new GeneralData();
                data.MESSAGE = "Successfully Update !";
                data.ORIGINAL_ERROR = "";
                data.ERROR_STATUS = false;
                data.RECORDS = true;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
            catch (Exception ex)
            {
                GeneralData data = new GeneralData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFMById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTData> list = new List<EFTData>();
        List<GeneralDataEFTClass> g = new List<GeneralDataEFTClass>();
        if (type == "efmbyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("SELECT efm.*,crm.name,tcm.ClassName,tt.Name as TTName,crm.Name,tcm.ClassName,(select classname from TrainclassMaster where Id=avlclassid) as AvlClass FROM ExcessFairMaster efm, ChargeReasonMaster crm, TrainClassMaster tcm, TTMaster tt WHERE efm.ReasonId=crm.Id and efm.ClassId=tcm.Id and efm.TTId=tt.Id and TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataEFTClass data = new GeneralDataEFTClass();
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        EFTData r = new EFTData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.EFTNo = dt.Rows[j]["EFTNo"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.CollectedOn = dt.Rows[j]["CollectedOn"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.TicketNo = dt.Rows[j]["TicketNo"].ToString();
                        r.Weight = dt.Rows[j]["Weight"].ToString();
                        r.WeightCharge = dt.Rows[j]["WeightCharge"].ToString();
                        r.FareAmount = dt.Rows[j]["FareAmount"].ToString();
                        r.ExcessCharge = dt.Rows[j]["ExcessCharge"].ToString();
                        r.Total = dt.Rows[j]["Total"].ToString();
                        r.CGST = dt.Rows[j]["CGST"].ToString();
                        r.SGST = dt.Rows[j]["SGST"].ToString();
                        r.IGST = dt.Rows[j]["IGST"].ToString();
                        r.UGST = dt.Rows[j]["UGST"].ToString();
                        r.TotalwithGST = dt.Rows[j]["TotalwithGST"].ToString();
                        r.name = dt.Rows[j]["name"].ToString();
                        r.ClassName = dt.Rows[j]["ClassName"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        r.StationName = dt.Rows[j]["StationName"].ToString();
                        r.Passengers = dt.Rows[j]["Passengers"].ToString();
                        r.AvlFromStation = dt.Rows[j]["AvlFromStation"].ToString();
                        r.AvlToStation = dt.Rows[j]["AvlToStation"].ToString();
                        r.AvlClass = dt.Rows[j]["AvlClass"].ToString();
                        r.GSTNo = dt.Rows[j]["GSTNo"].ToString();

                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTClass data = new GeneralDataEFTClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataEFTClass data = new GeneralDataEFTClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFTrById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTRData> list = new List<EFTRData>();
        List<GeneralDataEFTRClass> g = new List<GeneralDataEFTRClass>();
        if (type == "eftrbyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select efr.*,tt.Name as TTName from ExcessFairRecieptMaster efr,TTMaster tt where efr.TTId=tt.Id and efr.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataEFTRClass data = new GeneralDataEFTRClass();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        EFTRData r = new EFTRData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.StationName = dt.Rows[j]["StationName"].ToString();
                        r.MRNo = dt.Rows[j]["MRNo"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.Amount = dt.Rows[j]["Amount"].ToString();
                        r.UTSNo = dt.Rows[j]["UTSNo"].ToString();
                        r.FromEftNo = dt.Rows[j]["FromEftNo"].ToString();
                        r.ToEftNo = dt.Rows[j]["ToEftNo"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTRClass data = new GeneralDataEFTRClass();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataEFTRClass data = new GeneralDataEFTRClass();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetTAById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<TAData> list = new List<TAData>();
        List<GeneralDataTAData> g = new List<GeneralDataTAData>();
        if (type == "tabyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select ta.*,tt.Name as TTName from TAMaster ta,TTMaster tt where ta.TTId=tt.Id and ta.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataTAData data = new GeneralDataTAData();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        TAData r = new TAData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.TimeLeft = dt.Rows[j]["TimeLeft"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.TimeArrived = dt.Rows[j]["TimeArrived"].ToString();
                        r.Pecentage = dt.Rows[j]["Pecentage"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataTAData data = new GeneralDataTAData();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataTAData data = new GeneralDataTAData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetNDAById(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<NDAData> list = new List<NDAData>();
        List<GeneralDataNDAData> g = new List<GeneralDataNDAData>();
        if (type == "ndabyid")
        {
            try
            {
                DataTable dt = D.GetDataTable("select nda.*,tt.Name as TTName from NDAMaster nda,TTMaster tt where nda.TTId=tt.Id and nda.TTId=" + Id);
                if (dt.Rows.Count > 0)
                {
                    GeneralDataNDAData data = new GeneralDataNDAData();

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        NDAData r = new NDAData();
                        r.Id = dt.Rows[j]["Id"].ToString();
                        r.Date = dt.Rows[j]["Date"].ToString();
                        r.OnDutyTime = dt.Rows[j]["OnDutyTime"].ToString();
                        r.OffDutyTime = dt.Rows[j]["OffDutyTime"].ToString();
                        r.DutyHours = dt.Rows[j]["DutyHours"].ToString();
                        r.TrainNo = dt.Rows[j]["TrainNo"].ToString();
                        r.FromStation = dt.Rows[j]["FromStation"].ToString();
                        r.ToStation = dt.Rows[j]["ToStation"].ToString();
                        r.Remark = dt.Rows[j]["Remark"].ToString();
                        r.TTName = dt.Rows[j]["TTName"].ToString();
                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataNDAData data = new GeneralDataNDAData();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
            }
            catch (Exception ex)
            {
                GeneralDataNDAData data = new GeneralDataNDAData();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
    [WebMethod]
    public void GetEFMCount(string type, string Id)
    {
        JavaScriptSerializer js = new JavaScriptSerializer();
        int i = 0;
        List<EFTCount> list = new List<EFTCount>();
        List<GeneralDataEFTCount> g = new List<GeneralDataEFTCount>();
        if (type == "efmcount")
        {
            try
            {
                DataTable dt = D.GetDataTable("select (SELECT DATEADD(DAY, 2 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))) [Week_Start_Date], (SELECT DATEADD(DAY, 8 -DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))) [Week_End_Date]");
                if (dt.Rows.Count > 0)
                {
                    string startdate = Convert.ToDateTime(dt.Rows[0]["Week_Start_Date"]).ToString("yyyy-MM-dd");
                    string enddate = Convert.ToDateTime(dt.Rows[0]["Week_End_Date"]).ToString("yyyy-MM-dd");

                    EFTCount r = new EFTCount();
                    GeneralDataEFTCount data = new GeneralDataEFTCount();

                    //string qry = "select (select count(*) from ExcessFairMaster where Date between '2019-01-03' and '2019-01-05' and TTId=" + Id + ") WeekCount,(SELECT count(*) FROM ExcessFairMaster WHERE MONTH(Date) = MONTH(getdate()) and TTId=" + Id + ") MonthCount";

                    string qry = "select (select sum(cast(TotalwithGST as decimal)) from ExcessFairMaster where Date between '" + startdate + "' and '" + enddate + "' and TTId=" + Id + ") WeekCount,(SELECT sum(cast(TotalwithGST as decimal)) as Total FROM ExcessFairMaster WHERE MONTH(Date) = MONTH(getdate()) and TTId=" + Id + ") MonthCount";

                    DataTable dts = D.GetDataTable(qry);
                    if (dt.Rows.Count > 0)
                    {
                        r.weekCount = dts.Rows[0]["WeekCount"].ToString();
                        r.monthCount = dts.Rows[0]["MonthCount"].ToString();

                        list.Add(r);
                    }

                    data.MESSAGE = "Successfully !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = true;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }
                else
                {
                    GeneralDataEFTCount data = new GeneralDataEFTCount();
                    data.MESSAGE = "Wrong Data !";
                    data.ORIGINAL_ERROR = "";
                    data.ERROR_STATUS = false;
                    data.RECORDS = false;
                    data.Data = list;
                    g.Add(data);
                    Context.Response.Write(js.Serialize(g));
                }

            }
            catch (Exception ex)
            {
                GeneralDataEFTCount data = new GeneralDataEFTCount();
                data.MESSAGE = "Failed";
                data.ORIGINAL_ERROR = ex.Message;
                data.ERROR_STATUS = true;
                data.RECORDS = false;
                g.Add(data);
                Context.Response.Write(js.Serialize(g));
            }
        }
    }
}
>>>>>>> 58cb8ea43cf39064a4f8cc3859d9e0195460db3d
