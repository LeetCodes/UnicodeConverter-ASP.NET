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
using System.Windows.Shapes;
using Hajloo.FOSS.UnicodeConverter.Windows.UI.Forms.Modules;

namespace Hajloo.FOSS.UnicodeConverter.UI.Forms
{
    /// <summary>
    /// Interaction logic for MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void frmMain_Loaded(object sender, RoutedEventArgs e)
        {
            ConvertToUnicode frmToUnicode = new ConvertToUnicode();
            ToUnicode.Content = frmToUnicode;
            Thickness position = new Thickness(179, 42, 0, 0);
            imgSpecifier.Margin = position;
        }

        private void lnkConvertToUnicode_Click(object sender, RoutedEventArgs e)
        {
            ConvertToUnicode frmToUnicode = new ConvertToUnicode();
            ToUnicode.Content = frmToUnicode;
            Thickness position = new Thickness(179, 42, 0, 0);
            imgSpecifier.Margin = position;
        }

        private void lnkConvertFromUnicode_Click(object sender, RoutedEventArgs e)
        {
            ConvertFromUnicode frmFromUnicode = new ConvertFromUnicode();
            ToUnicode.Content = frmFromUnicode;
            Thickness position = new Thickness(179, 82, 0, 0);
            imgSpecifier.Margin = position;
        }

        private void lnkUnicodeInformation_Click(object sender, RoutedEventArgs e)
        {
            UnicodeInformation frmInformation = new UnicodeInformation();
            ToUnicode.Content = frmInformation;
            Thickness position = new Thickness(179, 122, 0, 0);
            imgSpecifier.Margin = position;
        }

        private void lnkHelp_Click(object sender, RoutedEventArgs e)
        {
            Thickness position = new Thickness(179, 322, 0, 0);
            imgSpecifier.Margin = position;
            
        }

        private void lnkAbout_Click(object sender, RoutedEventArgs e)
        {
            About frmAbout = new About();
            ToUnicode.Content = frmAbout;
            Thickness position = new Thickness(179, 362, 0, 0);
            imgSpecifier.Margin = position;
        }

        private void lnkStandard_Click(object sender, RoutedEventArgs e)
        {
            Standards frmStandards = new Standards();
            ToUnicode.Content = frmStandards;
            Thickness position = new Thickness(179, 162, 0, 0);
            imgSpecifier.Margin = position;
        }
    }
}
