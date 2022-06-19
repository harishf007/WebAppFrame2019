using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppFrame2019
{
    public partial class wfmEncryptnMask : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnMask_Click(object sender, EventArgs e)
        {
            string txtToMask = Request.Form[txtCardNo.UniqueID];
            DataMask dm = new DataMask();
            lblMask.Text = dm.MaskCrdtCrdNo(txtToMask);            
        }

        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            string txtToEncrpt = Request.Form[txtPw.UniqueID];            
            PWOption pw = new PWOption();
            lblEncrypt.Text = pw.SimplEncryptn(txtToEncrpt);
        }
    }
}