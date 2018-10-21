using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for sqlConn
/// </summary>
public class SqlConn
{
    SqlConnection conn = new SqlConnection();
    //public DataTable dt = new DataTable();
    public string err_Msg = "";
	public SqlConn()
	{
        conn.ConnectionString = ConfigurationManager.ConnectionStrings["housieConnectionString"].ConnectionString;
	}
    
    public bool Execute(SqlCommand command)
    {
        try
        {
            command.Connection = conn;
            if (conn.State != ConnectionState.Open) conn.Open();
            command.ExecuteNonQuery();
            if (conn.State != ConnectionState.Closed) conn.Close();
            return true;
        }
        catch (Exception ex)
        {
            err_Msg =  ex.Message;
            return false;
        }
        finally
        {
            conn.Close();
        }
    }

    public DataTable Populate(SqlCommand command)
    {
        try
        {
            command.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            if (conn.State != ConnectionState.Open) conn.Open();
            da.Fill(dt);
            if (conn.State != ConnectionState.Closed) conn.Close();
            return dt;
        }
        catch (Exception ex)
        {
            err_Msg =  ex.Message;
            return null;
        }
        finally
        {
            conn.Close();
        }
    }
}