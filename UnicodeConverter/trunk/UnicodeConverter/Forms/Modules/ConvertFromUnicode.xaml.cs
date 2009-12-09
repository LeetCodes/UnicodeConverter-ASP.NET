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


namespace Hajloo.FOSS.UnicodeConverter.Windows.UI.Forms.Modules
{
    /// <summary>
    /// Interaction logic for ConvertFromUnicode.xaml
    /// </summary>
    public partial class ConvertFromUnicode : UserControl
    {
        public ConvertFromUnicode()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnDecode_Click(object sender, RoutedEventArgs e)
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