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
    /// Interaction logic for UnicodeInformation.xaml
    /// </summary>
    public partial class UnicodeInformation : UserControl
    {
        public UnicodeInformation()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGetInformation_Click(object sender, RoutedEventArgs e)
        {
            if (txtInput.Text != string.Empty)
            {
                char input = txtInput.Text[0];
                lblUnicodeName.Content = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtInput.Text))[0]);
                lblGlyph.Content = input;
                txtDecimalCode.Text = Functions.GetDecimal(input).ToString();
                txtUnicodeCode.Text = Functions.GetHexCode(input);
                lblType.Content = Functions.GetType(input);
                lblCategory.Content = Functions.GetCategory(input);
                lblIsBidirectional.Content = Functions.GetBiDI(input);
                lblUnicodePage.Content = Functions.GetUnicodePage(input);
            }
        }

        private void btnAddToWord_Click(object sender, RoutedEventArgs e)
        {

            if (txtInput.Text != string.Empty)
            {
                char input = txtInput.Text[0];
                txtResultUnicode.Text += Functions.GetHexCode(input);
                txtResultText.Text += input.ToString();
            }
               
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtInput.Text.Length > 0)
                e.Handled = true;
        }

        private void txtInput_GotFocus(object sender, RoutedEventArgs e)
        {
            txtInput.Text = string.Empty;
        }

        private void btnGetHexInfo_Click(object sender, RoutedEventArgs e)
        {
            if (txtUnicodeCode.Text != string.Empty && txtUnicodeCode.Text.Length == 4)
            {
                char input = Functions.ConvertHexToUnicode(txtUnicodeCode.Text);
                txtInput.Text = input.ToString();
                lblUnicodeName.Content = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtInput.Text))[0]);
                lblGlyph.Content = input;
                txtDecimalCode.Text = Functions.GetDecimal(input).ToString();
                lblType.Content = Functions.GetType(input);
                lblCategory.Content = Functions.GetCategory(input);
                lblIsBidirectional.Content = Functions.GetBiDI(input);
                lblUnicodePage.Content = Functions.GetUnicodePage(input);
            }
        }

        private void btnGetDecimalInfo_Click(object sender, RoutedEventArgs e)
        {
            if (txtDecimalCode.Text != string.Empty)
            {
                char input = Functions.ConvertDecimalToChar(long.Parse(txtDecimalCode.Text));
                txtInput.Text = input.ToString();
                lblUnicodeName.Content = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtInput.Text))[0]);
                lblGlyph.Content = input;
                lblType.Content = Functions.GetType(input);
                lblCategory.Content = Functions.GetCategory(input);
                txtUnicodeCode.Text = Functions.GetHexCode(input);
                lblIsBidirectional.Content = Functions.GetBiDI(input);
                lblUnicodePage.Content = Functions.GetUnicodePage(input);
            }
        }
    }
}
