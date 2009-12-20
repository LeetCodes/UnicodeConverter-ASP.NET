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
    public partial class ConvertToUnicode : ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            txtResult.Text = string.Empty;
            if (txtInput.Text != string.Empty)
            {
                foreach (char item in txtInput.Text)
                    txtResult.Text += Functions.GetHexCode(item);
            }
        }
    }
}