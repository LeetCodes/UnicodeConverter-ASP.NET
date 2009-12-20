using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hajloo.FOSS.UnicodeConverter.Framework;
using Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit;

namespace Hajloo.FOSS.UnicodeConverter.Web.UI.Modules
{
    public partial class ConvertFromUnicode : ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDecode_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;

            if (txtInput.Text.Length > 0)
                for (int i = 0; i < txtInput.Text.Length; i += 4)
                    txtResult.Text += Functions.ConvertHexToUnicode(GetHexCode(txtInput.Text.Substring(i), i)).ToString();
        }

        private string GetHexCode(string hex, int index)
        {
            string code = string.Empty;

            if (hex.Length >= 4)
                code = hex.Substring(0, 4);

            return code;
        }
    }
}