using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFrame2019
{
    public partial class wfmDatePicker : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetDate_Click(object sender, EventArgs e)
        {
            string DatePickerVal = Request.Form[txtDatePicker.UniqueID];
            if(DatePickerVal == "")
            {
                lblWarning.Text = "Please Select a Date.";
            }
            else
            {
                lblWarning.Text = null;
                DateTime DatePickDate = DateTime.ParseExact(DatePickerVal, "MM/dd/yyyy", null);
                string SqlDate = DatePickDate.ToString("dd-MMM-yyyy");
                lblDatePickValue.Text = DatePickerVal;
                lblDateForOracle.Text = SqlDate;
            }
        }
    }
}