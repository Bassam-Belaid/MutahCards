namespace CardsApp
{
    partial class frmPurchasedCards
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAccountPurchasedCards = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbCodeType = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.gbxCardInfo = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountPurchasedCards)).BeginInit();
            this.gbxCardInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccountPurchasedCards
            // 
            this.dgvAccountPurchasedCards.AllowUserToAddRows = false;
            this.dgvAccountPurchasedCards.AllowUserToDeleteRows = false;
            this.dgvAccountPurchasedCards.AllowUserToOrderColumns = true;
            this.dgvAccountPurchasedCards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountPurchasedCards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAccountPurchasedCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountPurchasedCards.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountPurchasedCards.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountPurchasedCards.Location = new System.Drawing.Point(55, 176);
            this.dgvAccountPurchasedCards.Name = "dgvAccountPurchasedCards";
            this.dgvAccountPurchasedCards.ReadOnly = true;
            this.dgvAccountPurchasedCards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAccountPurchasedCards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAccountPurchasedCards.Size = new System.Drawing.Size(776, 223);
            this.dgvAccountPurchasedCards.TabIndex = 13;
            this.dgvAccountPurchasedCards.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountPurchasedCards_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 64);
            this.label1.TabIndex = 12;
            this.label1.Text = "البطاقات التي تم شراءها";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(540, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "الكود :";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(20, 54);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 25);
            this.lbCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(540, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "القيمة :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(532, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "التاريخ :";
            // 
            // lbCodeType
            // 
            this.lbCodeType.AutoSize = true;
            this.lbCodeType.Location = new System.Drawing.Point(20, 108);
            this.lbCodeType.Name = "lbCodeType";
            this.lbCodeType.Size = new System.Drawing.Size(0, 25);
            this.lbCodeType.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(20, 163);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 25);
            this.lbDate.TabIndex = 5;
            // 
            // gbxCardInfo
            // 
            this.gbxCardInfo.Controls.Add(this.lbDate);
            this.gbxCardInfo.Controls.Add(this.lbCodeType);
            this.gbxCardInfo.Controls.Add(this.label5);
            this.gbxCardInfo.Controls.Add(this.label6);
            this.gbxCardInfo.Controls.Add(this.lbCode);
            this.gbxCardInfo.Controls.Add(this.label8);
            this.gbxCardInfo.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCardInfo.Location = new System.Drawing.Point(135, 432);
            this.gbxCardInfo.Name = "gbxCardInfo";
            this.gbxCardInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxCardInfo.Size = new System.Drawing.Size(616, 222);
            this.gbxCardInfo.TabIndex = 22;
            this.gbxCardInfo.TabStop = false;
            this.gbxCardInfo.Text = "معلومات البطاقة";
            this.gbxCardInfo.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbBalance);
            this.groupBox1.Controls.Add(this.lbUsername);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(547, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(284, 137);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات الحساب";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(20, 91);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(0, 25);
            this.lbBalance.TabIndex = 7;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(20, 40);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(0, 25);
            this.lbUsername.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "الرصيد :";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(118, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 33);
            this.label7.TabIndex = 4;
            this.label7.Text = "اسم المستخدم :";
            // 
            // frmPurchasedCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(843, 667);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxCardInfo);
            this.Controls.Add(this.dgvAccountPurchasedCards);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmPurchasedCards";
            this.Text = "Purchased Cards Form";
            this.Load += new System.EventHandler(this.frmPurchasedCards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountPurchasedCards)).EndInit();
            this.gbxCardInfo.ResumeLayout(false);
            this.gbxCardInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAccountPurchasedCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCodeType;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.GroupBox gbxCardInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}