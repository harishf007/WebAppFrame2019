using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OracleClient;
using System.Configuration;
using System.IO;

namespace WebAppFrame2019
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        OracleConnection oConDB = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            setConnection();
        }

        private void setConnection()
        {
            String conOra = ConfigurationManager.ConnectionStrings["oracleDB"].ConnectionString;
            oConDB = new OracleConnection(conOra);
            Label1.Text = "Connection Successfull.";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            oConDB.Open();
            string sqlStmt = "INSERT INTO TESTTABLE(remark)VALUES('Test Data Added')";
            OracleCommand cmdSQLStmt = oConDB.CreateCommand();
            cmdSQLStmt.CommandText = sqlStmt;
            cmdSQLStmt.ExecuteNonQuery();
            oConDB.Close();
            Label1.Text = "Data Added.";
            sqlStmt = "Select * from testtable";
            DBDAO db = new DBDAO();
            GridView1.DataSource = db.DsetDB(sqlStmt);
            GridView1.DataBind();
        }
        
    }
}