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
    public partial class Standards : ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Initialization();
        }

        private void Initialization()
        {
            lstCountries.DataSource = Functions.GetAllAvailableCountries();
            lstCountries.DataBind();
        }

        protected void lstCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            string country = lstCountries.SelectedValue.ToString();
            lblCountry.Text = country;
            lblKeyboardLayout.Text = Functions.GetKeyboardLayout(country);
            lblLicense.Text = Functions.GetLicense(country);
            lblStandardDate.Text = Functions.GetStandardDate(country);
            lnkProjectURL.NavigateUrl = Functions.GetProjectURL(country);
            lnkProjectURL.Text = Functions.GetProjectURL(country);
            lblProducer.Text = Functions.GetProducer(country);
            lblReferer.Text = Functions.GetReferer(country);
            lblRefererMail.Text = Functions.GetRefererMail(country);
            upResults.Update();
        }
    }
}