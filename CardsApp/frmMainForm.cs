using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardsApp
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private frmBuyCard _BuyCard = null;
        private frmPurchasedCards _PurchasedCards = null;  
        private bool _IsLoggedIn = clsGlobal.CurrentClient != null;

        private void _SetAccountInfo()
        {

            lbUsername.Text = clsGlobal.CurrentClient.Username;
            lbBalance.Text = clsGlobal.CurrentClient.Balance.ToString();

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {

            _SetAccountInfo();  

        }

        private void btnBuyCard_Click(object sender, EventArgs e)
        {

            _BuyCard = new frmBuyCard(); 
            _BuyCard.ShowDialog();
            _SetAccountInfo();

        }

        private void btnPurchasedCards_Click(object sender, EventArgs e)
        {

            _PurchasedCards = new frmPurchasedCards();  
            _PurchasedCards.ShowDialog();   

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل تريد حقًا تسجيل الخروج ؟", "تأكيد تسجيل الخروج",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("! تسجيل الخروج ناجح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsGlobal.CurrentClient = null;
                _IsLoggedIn = false;
                this.Close();
            }
            else
            {
                return;
            }

        }

        private void frmMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (_IsLoggedIn)
            {
                MessageBox.Show(".يرجى تسجيل الخروج قبل إغلاق الشاشة", "مطلوب تسجيل الخروج", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }

        }

    }
   
}
