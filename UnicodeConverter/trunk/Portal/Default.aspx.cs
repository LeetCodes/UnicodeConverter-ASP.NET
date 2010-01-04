using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hajloo.FOSS.UnicodeConverter.Framework;

namespace Hajloo.FOSS.UnicodeConverter.Web.UI
{
    public partial class Default : PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
                Initialization();
        }

        private void Initialization()
        {
            VisibleContent("UnicodeInformation");
            ApplyArrowForActiveLink("UnicodeInformation");
        }

        private void VisibleContent(string name)
        {
            AboutControl.Visible = false;
            UnicodeInformationControl.Visible = false;
            ConvertToUnicode.Visible = false;
            ConvertFromUnicode.Visible = false;
            StandardsControl.Visible = false;
            HelpAndHowToControl.Visible = false;

            if (name == "Standards") StandardsControl.Visible = true;
            if (name == "ConvertFromUnicode") ConvertFromUnicode.Visible = true;
            if (name == "ConvertToUnicode") ConvertToUnicode.Visible = true;
            if (name == "UnicodeInformation") UnicodeInformationControl.Visible = true;
            if (name == "About") AboutControl.Visible = true;
            if (name == "HelpAndHowTo") HelpAndHowToControl.Visible = true;
        }

        private void ApplyArrowForActiveLink(string linkName)
        {
            lnbAbout.CssClass = "SideLink";
            lnbConvertFromUnicode.CssClass = "SideLink";
            lnbConvertToUnicode.CssClass = "SideLink";
            lnbHelpAndHowTo.CssClass = "SideLink";
            lnbStandards.CssClass = "SideLink";
            lnbUnicodeInformation.CssClass = "SideLink";

            if (linkName == "About") lnbAbout.CssClass = "SideLinkActive";
            if (linkName == "ConvertFromUnicode") lnbConvertFromUnicode.CssClass = "SideLinkActive";
            if (linkName == "ConvertToUnicode") lnbConvertToUnicode.CssClass = "SideLinkActive";
            if (linkName == "HelpAndHowTo") lnbHelpAndHowTo.CssClass = "SideLinkActive";
            if (linkName == "Standards") lnbStandards.CssClass = "SideLinkActive";
            if (linkName == "UnicodeInformation") lnbUnicodeInformation.CssClass = "SideLinkActive";
        }

        protected void lnbConvertToUnicode_Click(object sender, EventArgs e)
        {
            VisibleContent("ConvertToUnicode");
            ApplyArrowForActiveLink("ConvertToUnicode");
        }

        protected void lnbConvertFromUnicode_Click(object sender, EventArgs e)
        {
            VisibleContent("ConvertFromUnicode");
            ApplyArrowForActiveLink("ConvertFromUnicode");
        }

        protected void lnbUnicodeInformation_Click(object sender, EventArgs e)
        {
            VisibleContent("UnicodeInformation");
            ApplyArrowForActiveLink("UnicodeInformation");
        }

        protected void lnbStandards_Click(object sender, EventArgs e)
        {
            VisibleContent("Standards");
            ApplyArrowForActiveLink("Standards");
        }

        protected void lnbHelpAndHowTo_Click(object sender, EventArgs e)
        {
            VisibleContent("HelpAndHowTo");
            ApplyArrowForActiveLink("HelpAndHowTo");
        }

        protected void lnbAbout_Click(object sender, EventArgs e)
        {
            VisibleContent("About");
            ApplyArrowForActiveLink("About");
        }
    }
}