<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class Connection
{
    SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ConnectionString.ToString());
    public Connection()
    {
    }
    public int GetMaxId(string SqlQuery)
    {
        int id = 0;
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(SqlQuery, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        return id;
    }
    public DataTable GetDataTable(string strqry)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(strqry, cnn);
            cnn.Close();
            cnn.Open();
            cm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            if (msg.Contains("Connection Timeout Expired"))
            {
                HttpContext.Current.Response.Redirect("~/Admin/500.html", false);
            }
            else
            {
                throw new Exception(msg);
            }

        }
        finally
        {
            cnn.Close();
        }
        return dt;
    }
    public void ExecuteQuery(string qry)
    {
        cnn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cnn;
        cmd.CommandText = qry;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }
    public void ExecuteQueryBySP(SqlCommand scmd)
    {
        cnn.Open();
        SqlCommand cmd = scmd;
        cmd.Connection = cnn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }

    public DataTable GetData(string qry)
    {
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cnn.Close();

        }
        catch (Exception ex)
        {

        }
        return dt;

    }
}

public class TTMaster
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string MobileNo { get; set; }
    public Boolean IsSquadHead { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string StationName { get; set; }
    public string SquadHeadName { get; set; }
}

public class ReasonMaster
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ShortCode { get; set; }
}

public class TrainClassMaster
{
    public string Id { get; set; }
    public string Name { get; set; }

}

public class EFTCount
{
    public string weekCount { get; set; }
    public string monthCount { get; set; }

}

public class EFTData
{
    public string Id { get; set; }
    public string EFTNo { get; set; }
    public string Date { get; set; }
    public string CollectedOn { get; set; }
    public string TrainNo { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string TicketNo { get; set; }
    public string Weight { get; set; }
    public string WeightCharge { get; set; }
    public string FareAmount { get; set; }
    public string ExcessCharge { get; set; }
    public string Total { get; set; }
    public string CGST { get; set; }
    public string SGST { get; set; }
    public string IGST { get; set; }
    public string UGST { get; set; }
    public string TotalwithGST { get; set; }
    public string name { get; set; }
    public string ClassName { get; set; }
    public string TTName { get; set; }

    public string StationName { get; set; }
    public string Passengers { get; set; }
    public string AvlFromStation { get; set; }
    public string AvlToStation { get; set; }
    public string AvlClass { get; set; }
    public string GSTNo { get; set; }

}

public class EFTRData
{
    public string Id { get; set; }
    public string StationName { get; set; }
    public string MRNo { get; set; }
    public string Date { get; set; }
    public string Amount { get; set; }
    public string UTSNo { get; set; }
    public string FromEftNo { get; set; }
    public string ToEftNo { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}

public class TAData
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string TrainNo { get; set; }
    public string TimeLeft { get; set; }
    public string TimeArrived { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string Pecentage { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}
public class NDAData
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string TrainNo { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string OnDutyTime { get; set; }
    public string OffDutyTime { get; set; }
    public string DutyHours { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}
public class GeneralDataUser
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TTMaster> Data { get; set; }
}
public class GeneralDataReason
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<ReasonMaster> Data { get; set; }
}
public class GeneralDataTrainClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TrainClassMaster> Data { get; set; }
}
public class GeneralDataEFTClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTData> Data { get; set; }
}

public class GeneralDataEFTRClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTRData> Data { get; set; }
}

public class GeneralDataEFTCount
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTCount> Data { get; set; }
}


public class GeneralDataTAData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TAData> Data { get; set; }
}

public class GeneralDataNDAData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<NDAData> Data { get; set; }
}

public class GeneralData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }

}
public class GeneralData1
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }

}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


public class Connection
{
    SqlConnection cnn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["TTReturn"].ConnectionString.ToString());
    public Connection()
    {
    }
    public int GetMaxId(string SqlQuery)
    {
        int id = 0;
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(SqlQuery, cnn);
            cnn.Open();
            cm.ExecuteNonQuery();
            cnn.Close();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                id = Convert.ToInt32(dt.Rows[0][0].ToString());
            }
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            throw new Exception(msg);
        }
        return id;
    }
    public DataTable GetDataTable(string strqry)
    {
        DataTable dt = new DataTable();
        try
        {
            SqlCommand cm = new SqlCommand(strqry, cnn);
            cnn.Close();
            cnn.Open();
            cm.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
        }
        catch (System.Data.SqlClient.SqlException ex)
        {
            string msg = "Fetch Error:";
            msg += ex.Message;
            if (msg.Contains("Connection Timeout Expired"))
            {
                HttpContext.Current.Response.Redirect("~/Admin/500.html", false);
            }
            else
            {
                throw new Exception(msg);
            }

        }
        finally
        {
            cnn.Close();
        }
        return dt;
    }
    public void ExecuteQuery(string qry)
    {
        cnn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = cnn;
        cmd.CommandText = qry;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }
    public void ExecuteQueryBySP(SqlCommand scmd)
    {
        cnn.Open();
        SqlCommand cmd = scmd;
        cmd.Connection = cnn;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.ExecuteNonQuery();
        cnn.Close();
    }

    public DataTable GetData(string qry)
    {
        DataTable dt = new DataTable();
        try
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand(qry, cnn);
            SqlDataAdapter da = new SqlDataAdapter();
            cmd.ExecuteNonQuery();
            da.SelectCommand = cmd;
            da.Fill(dt);
            cnn.Close();

        }
        catch (Exception ex)
        {

        }
        return dt;

    }
}

public class TTMaster
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string MobileNo { get; set; }
    public Boolean IsSquadHead { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string StationName { get; set; }
    public string SquadHeadName { get; set; }
}

public class ReasonMaster
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string ShortCode { get; set; }
}

public class TrainClassMaster
{
    public string Id { get; set; }
    public string Name { get; set; }

}

public class EFTCount
{
    public string weekCount { get; set; }
    public string monthCount { get; set; }

}

public class EFTData
{
    public string Id { get; set; }
    public string EFTNo { get; set; }
    public string Date { get; set; }
    public string CollectedOn { get; set; }
    public string TrainNo { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string TicketNo { get; set; }
    public string Weight { get; set; }
    public string WeightCharge { get; set; }
    public string FareAmount { get; set; }
    public string ExcessCharge { get; set; }
    public string Total { get; set; }
    public string CGST { get; set; }
    public string SGST { get; set; }
    public string IGST { get; set; }
    public string UGST { get; set; }
    public string TotalwithGST { get; set; }
    public string name { get; set; }
    public string ClassName { get; set; }
    public string TTName { get; set; }

    public string StationName { get; set; }
    public string Passengers { get; set; }
    public string AvlFromStation { get; set; }
    public string AvlToStation { get; set; }
    public string AvlClass { get; set; }
    public string GSTNo { get; set; }

}

public class EFTRData
{
    public string Id { get; set; }
    public string StationName { get; set; }
    public string MRNo { get; set; }
    public string Date { get; set; }
    public string Amount { get; set; }
    public string UTSNo { get; set; }
    public string FromEftNo { get; set; }
    public string ToEftNo { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}

public class TAData
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string TrainNo { get; set; }
    public string TimeLeft { get; set; }
    public string TimeArrived { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string Pecentage { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}
public class NDAData
{
    public string Id { get; set; }
    public string Date { get; set; }
    public string TrainNo { get; set; }
    public string FromStation { get; set; }
    public string ToStation { get; set; }
    public string OnDutyTime { get; set; }
    public string OffDutyTime { get; set; }
    public string DutyHours { get; set; }
    public string Remark { get; set; }
    public string TTName { get; set; }
}
public class GeneralDataUser
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TTMaster> Data { get; set; }
}
public class GeneralDataReason
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<ReasonMaster> Data { get; set; }
}
public class GeneralDataTrainClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TrainClassMaster> Data { get; set; }
}
public class GeneralDataEFTClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTData> Data { get; set; }
}

public class GeneralDataEFTRClass
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTRData> Data { get; set; }
}

public class GeneralDataEFTCount
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<EFTCount> Data { get; set; }
}


public class GeneralDataTAData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<TAData> Data { get; set; }
}

public class GeneralDataNDAData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }
    public List<NDAData> Data { get; set; }
}

public class GeneralData
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }

}
public class GeneralData1
{
    public string MESSAGE { get; set; }
    public string ORIGINAL_ERROR { get; set; }
    public Boolean ERROR_STATUS { get; set; }
    //public int STATUS { get; set; }
    public Boolean RECORDS { get; set; }

}
>>>>>>> 58cb8ea43cf39064a4f8cc3859d9e0195460db3d
