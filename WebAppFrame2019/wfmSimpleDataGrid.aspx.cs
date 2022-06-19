using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFrame2019
{
    public partial class wfmSimpleDataGrid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddData_Click(object sender, EventArgs e)
        {
            string txtFrmInput = Request.Form[txtInText.UniqueID];
            if(txtFrmInput == "")
            {
                lblMessage.Text = "Please enter data.";
            }
            else
            {
                lblMessage.Text = null;
                DBDAO db = new DBDAO();
                string sqlStmt = "INSERT INTO testtable (remark) VALUES ('"+ db.CleanSQLText(txtFrmInput) +"')";                
                db.QueryDB(sqlStmt);
                sqlStmt = "SELECT * FROM testtable";
                GridView1.DataSource =  db.DsetDB(sqlStmt);
                GridView1.DataBind();
                lblMessage.Text = "Data Added Successfully.";
            }
        }

        protected void btnClearTable_Click(object sender, EventArgs e)
        {
            lblMessage.Text = null;
            DBDAO db = new DBDAO();
            string sqlStmt = "Truncate table testtable";
            db.QueryDB(sqlStmt);
            lblMessage.Text = "Database Table truncated.";
            sqlStmt = "SELECT * FROM testtable";
            GridView1.DataSource = db.DsetDB(sqlStmt);
            GridView1.DataBind();
        }
    }
}