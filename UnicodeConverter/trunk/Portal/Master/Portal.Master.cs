using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hajloo.FOSS.UnicodeConverter.Framework;

namespace Hajloo.FOSS.UnicodeConverter.Web.UI.Master
{
    public partial class Portal : MasterBase
    {
        private string _directionality;
        public string Directionality {
        get {
                if (String.IsNullOrEmpty(_directionality)) {
                    _directionality = ((string)GetGlobalResourceObject("CommonResources", "ApplicationDirection")).ToLower();
                }
                return _directionality;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}
