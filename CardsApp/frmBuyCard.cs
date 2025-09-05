using CardsAppBusinessLayer;
using CodeGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PDFGeneratorApp;

namespace CardsApp
{
    public partial class frmBuyCard : Form
    {
        public frmBuyCard()
        {
            InitializeComponent();
        }

        private clsCard _Card = null;
        private clsCardType _CardType = null;
        private bool _IsDone = false;
        string DesktopPath = "";
        string FilePath = "";
        string UniqueFileName = "";


        private void _FillCardTypesComboBox()
        {
            List<clsCardType> CardTypes = null;

            if ((CardTypes = clsCardType.GetCardTypes()) != null)
            {
                foreach (clsCardType CardType in CardTypes)
                {
                    cbxCardTypes.Items.Add(CardType.CardTypeValue.ToString());
                }
            }
            else
                return;
        }

        private void _FillCardInfo()
        {
            lbCode.Text = clsCode.FormatCode(_Card.CardCode);
            lbCodeType.Text = _CardType.CardTypeValue.ToString();
            lbDate.Text = DateTime.Now.ToString();
        }

        private void _SetAccountInfo()
        {
            lbUsername.Text = clsGlobal.CurrentClient.Username;
            lbBalance.Text = clsGlobal.CurrentClient.Balance.ToString();
        }

        private bool _IsEmptyField()
        {
            return (cbxCardTypes.SelectedIndex == -1);
        }

        private void frmBuyCard_Load(object sender, EventArgs e)
        {
            _FillCardTypesComboBox();
            _SetAccountInfo();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (_IsEmptyField())
            {
                MessageBox.Show(".يرجى اختيار قيمة البطاقة", "مطلوب اختيار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("هل تريد حقًا شراء هذه البطاقة ؟", "تأكيد الشراء",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if ((_CardType = clsCardType.GetCardTypeByValue(decimal.Parse(cbxCardTypes.Text))) != null)
                {
                    if (clsGlobal.CurrentClient.Balance < _CardType.CardTypeValue &&
                        !clsClient.CheckClientBalance(clsGlobal.CurrentClient.ClientID, _CardType.CardTypeValue))
                    {
                        MessageBox.Show(".الرصيد غير كاف لإكمال هذا الشراء", "رصيد غير كاف", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if ((_Card = clsGlobal.CurrentClient.Purchase(_CardType)) != null)
                        _IsDone = true;
                }
            }
            else
                return;

            if (_IsDone)
            {
                MessageBox.Show("!تم الشراء بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _FillCardInfo();
                _SetAccountInfo();
                gbxCardInfo.Visible = true;
                btnPrint.Visible = true;
            }
            else
                MessageBox.Show(".فشل الشراء! يرجى المحاولة مرة أخرى", "فشل الشراء", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_Card != null)
            {
                DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                UniqueFileName = "Card_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";
                FilePath = Path.Combine(DesktopPath, UniqueFileName);
                clsPDFGenerator.CreatePdfWithObject(FilePath, _Card);
                MessageBox.Show("!تم طباعة البطاقة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(".معلومات البطاقة غير متاحة", "فشل الطباعة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}