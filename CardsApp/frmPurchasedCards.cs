using CardsAppBusinessLayer;
using CodeGenerator;
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
    public partial class frmPurchasedCards : Form
    {
        public frmPurchasedCards()
        {
            InitializeComponent();
        }

        private void _SetAccountInfo()
        {

            lbUsername.Text = clsGlobal.CurrentClient.Username;
            lbBalance.Text = clsGlobal.CurrentClient.Balance.ToString();

        }

        private void _FillCardInfo()
        {

            lbCode.Text = clsCode.FormatCode(dgvAccountPurchasedCards.CurrentRow.Cells[0].Value.ToString());
            lbCodeType.Text = dgvAccountPurchasedCards.CurrentRow.Cells[1].Value.ToString();
            lbDate.Text = dgvAccountPurchasedCards.CurrentRow.Cells[2].Value.ToString();

        }

        private void _RefreshClientPurchasedCardsList()
        {

            dgvAccountPurchasedCards.DataSource = clsGlobal.CurrentClient.GetAllPurchasedCards();
            dgvAccountPurchasedCards.Columns[0].HeaderText = "كود البطاقة";
            dgvAccountPurchasedCards.Columns[1].HeaderText = "قيمة البطاقة";
            dgvAccountPurchasedCards.Columns[2].HeaderText = "تاريخ الشراء";
            dgvAccountPurchasedCards.Columns[3].HeaderText = "حالة تعبئة";

        }

        private void frmPurchasedCards_Load(object sender, EventArgs e)
        {
            
            _RefreshClientPurchasedCardsList(); 
            _SetAccountInfo();  

        }

        private void dgvAccountPurchasedCards_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            _FillCardInfo();
            gbxCardInfo.Visible = true;

        }
    }
}
