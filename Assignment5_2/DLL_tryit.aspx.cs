using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using enc_dec_lib;

namespace Assignment5_2
{
    public partial class DLL_tryit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            encryptLbl.Text = enc_dec_lib.Enc_dec.Encrypt(inputB.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            decryptLbl.Text = enc_dec_lib.Enc_dec.Decrypt(input2B.Text);
        }
    }
}