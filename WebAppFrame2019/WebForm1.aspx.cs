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

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile) //Check if fileUpload control contains a file.
            {
                try
                {
                    FileUpload1.SaveAs("C:\\TestUploads\\" + FileUpload1.FileName); //FilePath where you want to store the uploaded file.
                    Label2.Text = "File Uploaded Successfully..! " + FileUpload1.PostedFile.ContentLength + "bytes.";
                }
                catch (Exception ex)
                {
                    Label2.Text = "File Not Uploaded!!" + ex.Message.ToString();
                }
            }
            else
            {
                Label2.Text = "Please Select a File and Upload Again.";
            }
        }

        protected void btnProcess_Click(object sender, EventArgs e)
        {
            string sqlStmt = null;
            string uploadedFilePath = @"C:\TestUploads\expenses.csv";
            //Creating FileInfo
            System.IO.FileInfo fil1 = new System.IO.FileInfo(uploadedFilePath);
            DBDAO db = new DBDAO();
            sqlStmt = "TRUNCATE TABLE trandetail";
            db.QueryDB(sqlStmt);
            if (fil1.Exists)
            {                
                using (var reader = new StreamReader(uploadedFilePath))
                {
                    reader.ReadLine(); //This discards the header line in csv file.
                    string tranDate;
                    string tranAmount;
                    string tranCategory;
                    string tranCompany;
                    string tranRemarks;
                    DateTime sqlDate;
                    string strSqlDate;
                    float floatAmount;

                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        tranDate = values[0];
                        tranAmount = values[1];
                        tranCategory = values[2];
                        tranCompany = values[3];
                        tranRemarks = values[4];
                        sqlDate = DateTime.ParseExact(tranDate.Trim(), "MM/dd/yyyy", null);
                        strSqlDate = sqlDate.ToString("dd-MMM-yyyy");
                        floatAmount = float.Parse(tranAmount.Trim());
                        sqlStmt = " INSERT INTO trandetail ( " +
                            " trandate, tranamount, trancategory, trancompany, tranremarks " +
                            " ) VALUES ( " +
                            " '"+ strSqlDate + "'," +
                            " '"+ floatAmount + "'," +
                            " '"+ db.CleanSQLText(tranCategory) + "'," +
                            " '"+ db.CleanSQLText(tranCompany) + "'," +
                            " '"+ db.CleanSQLText(tranRemarks) + "'" +
                            " ) ";
                        db.QueryDB(sqlStmt);
                        Label2.Text = "Data Values Processed.";
                    }
                }
            }
            else
            {
                Label2.Text = "No file uploaded to process.";
            }
            //File renaming after processing.
            if (fil1.Exists) //Check if file exists in location.
            {
                fil1.MoveTo(@"C:\TestUploads\expense" + DateTime.Now.ToString("ddMMyyyyhhmmss") + ".Done");
                //Move file with a new name. Hence renamed.
            }
        }
    }
}