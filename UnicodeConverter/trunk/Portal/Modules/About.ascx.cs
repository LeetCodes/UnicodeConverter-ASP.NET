using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hajloo.FOSS.UnicodeConverter.Framework;

namespace Hajloo.FOSS.UnicodeConverter.Web.UI.Modules
{
    public partial class About : ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Initialization();
        }

        private void Initialization()
        {
            lblDevelopers.Text = "Nasser Hajloo";
            lblProjectManager.Text = "Nasser Hajloo";
            lbleMail.Text = "n.hajloo@gmail.com";
            lnkBlog.Text = "http://Hajloo.wordpress.com";
            lnkBlog.NavigateUrl = "http://Hajloo.wordpress.com";
            lblVersion.Text = "1.0";
            lblLastVersion.Text = "12/09/2009";
            lblProjectHost.Text = "Codeplex";
            lnkProjectURL.Text = "http://Unicode.codeplex.com";
            lnkProjectURL.NavigateUrl = "http://Unicode.codeplex.com";
            lblProjectLicense.Text = "GNU GPL 2.0";
        }
    }
}