using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit;
using System.Collections;

namespace Hajloo.FOSS.UnicodeConverter.Windows.UI.Forms.Modules
{
    /// <summary>
    /// Interaction logic for Standards.xaml
    /// </summary>
    public partial class Standards : UserControl
    {
        public Standards()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Initialization();
            lstCountry.UpdateLayout();
            lstCountry.InvalidateVisual();
        }

        private void Initialization()
        {
            lstCountry.ItemsSource = Functions.GetAllAvailableCountries();
        }

        private void lstCountry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string country = lstCountry.SelectedValue.ToString();
            lblCountry.Content = country;
            lblKeyboardLayout.Content = Functions.GetKeyboardLayout(country);
            lblLicense.Content = Functions.GetLicense(country);
            lblStandardDate.Content = Functions.GetStandardDate(country);
            lblProjectURL.Content = Functions.GetProjectURL(country);
            lblProducer.Content = Functions.GetProducer(country);
            lblReferer.Content = Functions.GetReferer(country);
            lblRefererMail.Content = Functions.GetRefererMail(country);
        }
    }
}
