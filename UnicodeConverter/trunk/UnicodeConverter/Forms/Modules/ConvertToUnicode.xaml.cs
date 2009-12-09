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
    /// Interaction logic for ConvertToUnicode.xaml
    /// </summary>
    public partial class ConvertToUnicode : UserControl
    {
        public ConvertToUnicode()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != string.Empty)
            {
                foreach (char item in txtInput.Text)
                    txtResult.Text += Functions.GetHexCode(item);
            }
        }
    }
}
