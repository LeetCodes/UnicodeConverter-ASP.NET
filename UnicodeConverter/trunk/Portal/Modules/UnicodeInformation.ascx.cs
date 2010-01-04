using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hajloo.FOSS.UnicodeConverter.Framework;
using Hajloo.FOSS.UnicodeConverter.EnterpriseAppUnit;
using System.Text;

namespace Hajloo.FOSS.UnicodeConverter.Web.UI.Modules
{
    public partial class UnicodeInformation : ModuleBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Initialization();
        }

        private void Initialization()
        {
            SetBoxLength();
        }

        private void SetBoxLength()
        {
            txtChar.MaxLength = 1;
            txtHexCode.MaxLength = 4;
            txtDecimal.MaxLength = 5;
        }

        protected void btnGetInfotmation_Click(object sender, EventArgs e)
        {
            if (txtChar.Text != string.Empty)
            {
                char input = txtChar.Text[0];
                lblUnicodeName.Text = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtChar.Text))[0]);
                lblUnicodeShape.Text = input.ToString();
                txtDecimal.Text = Functions.GetDecimal(input).ToString();
                txtHexCode.Text = Functions.GetHexCode(input);
                lblUnicodeType.Text = Functions.GetType(input);
                lblUnicodeCategory.Text = Functions.GetCategory(input);
                lblDirectionalityStatus.Text = Functions.GetBiDI(input);
                lblUnicodeRange.Text = Functions.GetUnicodePage(input);
            }
        }

        protected void btnAddToWord_Click(object sender, EventArgs e)
        {
            if (txtChar.Text != string.Empty)
            {
                char input = txtChar.Text[0];
                txtUnicodeHexCodeResult.Text += Functions.GetHexCode(input);
                txtUnicodeTextResult.Text += input.ToString();
            }
        }

        protected void btnGetHexCodeInfo_Click(object sender, EventArgs e)
        {
            if (txtHexCode.Text != string.Empty && txtHexCode.Text.Length == 4)
            {
                char input = Functions.ConvertHexToUnicode(txtHexCode.Text);
                txtChar.Text = input.ToString();
                lblUnicodeName.Text = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtChar.Text))[0]);
                lblUnicodeShape.Text = input.ToString();
                txtDecimal.Text = Functions.GetDecimal(input).ToString();
                lblUnicodeType.Text = Functions.GetType(input);
                lblUnicodeCategory.Text = Functions.GetCategory(input);
                lblDirectionalityStatus.Text = Functions.GetBiDI(input);
                lblUnicodeRange.Text = Functions.GetUnicodePage(input);
            }
        }

        protected void btnGetDecimalInfo_Click(object sender, EventArgs e)
        {
            if (txtDecimal.Text != string.Empty)
            {
                char input = Functions.ConvertDecimalToChar(long.Parse(txtDecimal.Text));
                txtChar.Text = input.ToString();
                lblUnicodeName.Text = Functions.GetName(UnicodeEncoding.BigEndianUnicode.GetChars(UnicodeEncoding.BigEndianUnicode.GetBytes(txtChar.Text))[0]);
                lblUnicodeShape.Text = input.ToString();
                lblUnicodeType.Text = Functions.GetType(input);
                lblUnicodeCategory.Text = Functions.GetCategory(input);
                txtHexCode.Text = Functions.GetHexCode(input);
                lblDirectionalityStatus.Text = Functions.GetBiDI(input);
                lblUnicodeRange.Text = Functions.GetUnicodePage(input);
            }
        }
    }
}