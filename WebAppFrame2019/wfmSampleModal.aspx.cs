using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFrame2019
{
    public partial class wfmSampleModal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Your Desired code should be placed here.
            ScriptManager.RegisterStartupScript(this, GetType(), "Close Modal Popup", "closeModal();", true);
        }
    }
}