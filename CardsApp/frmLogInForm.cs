using System;
using System.Windows.Forms;
using CardsAppBusinessLayer;

namespace CardsApp
{
    public partial class frmLogInForm : Form
    {
        public frmLogInForm()
        {
            InitializeComponent();
        }

        private frmMainForm MainForm = null;

        private bool _IsEmptyFields() 
        {

            return string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text);

        }

        private void _EmptyFields()
        {

            txtUsername.Text = string.Empty;    
            txtPassword.Text = string.Empty;       

        }

        private void cbxShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if(cbxShowPassword.Checked)
                txtPassword.UseSystemPasswordChar = false;
            
            else
                txtPassword.UseSystemPasswordChar = true;

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {

            if (_IsEmptyFields()) 
            {

                MessageBox.Show(".يرجى ملء جميع الحقول", "مطلوب إدخال", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if ((clsGlobal.CurrentClient = clsClient.FindClient(txtUsername.Text, txtPassword.Text)) != null)
            {

                MessageBox.Show("!تسجيل الدخول ناجح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainForm = new frmMainForm();
                this.Hide();
                MainForm.ShowDialog();
                this.Show();
                _EmptyFields();

            }

            else

                MessageBox.Show(".فشل تسجيل الدخول! يرجى التحقق من اسم المستخدم وكلمة المرور", "فشل تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}
