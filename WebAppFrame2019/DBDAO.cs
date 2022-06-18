using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OracleClient;
using System.Configuration;
using System.Data;

namespace WebAppFrame2019
{
    public class DBDAO
    {
        OracleConnection oConDB = null;

        private void setDBConn()
        {
            String conOra = ConfigurationManager.ConnectionStrings["oracleDB"].ConnectionString;
            oConDB = new OracleConnection(conOra);
        }

        public void QueryDB(string sqlStmt)
        {
            setDBConn();
            oConDB.Open();
            OracleCommand cmdSqlStmt = oConDB.CreateCommand();
            cmdSqlStmt.CommandText = sqlStmt;
            cmdSqlStmt.ExecuteNonQuery();
            oConDB.Close();
            oConDB.Dispose();
        }

        public DataTable DtableDB(string sqlStmt)
        {
            setDBConn();
            oConDB.Open();
            OracleCommand cmdSqlStmt = oConDB.CreateCommand();
            cmdSqlStmt.CommandText = sqlStmt;
            cmdSqlStmt.ExecuteNonQuery();
            oConDB.Close();
            OracleDataAdapter dtAdapter = new OracleDataAdapter(cmdSqlStmt);
            DataTable dtTable = new DataTable();
            dtAdapter.Fill(dtTable);
            oConDB.Dispose();
            return dtTable;
        }

        public DataSet DsetDB(string sqlStmt)
        {
            setDBConn();
            oConDB.Open();
            OracleCommand cmdSqlStmt = oConDB.CreateCommand();
            cmdSqlStmt.CommandText = sqlStmt;
            cmdSqlStmt.ExecuteNonQuery();
            oConDB.Close();
            OracleDataAdapter dtAdapter = new OracleDataAdapter(cmdSqlStmt);
            DataSet dtSet = new DataSet();
            dtAdapter.Fill(dtSet);
            oConDB.Dispose();
            return dtSet;
        }

        public string CleanSQLText(string inText)
        {
            inText = inText.Replace("\\", "\\\\");
            inText = inText.Replace("'", "''");
            inText = inText.Replace("\"", "\\\"");
            return inText.Trim();
            
        }
    }
}