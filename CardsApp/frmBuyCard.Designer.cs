namespace CardsApp
{
    partial class frmBuyCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxCardInfo = new System.Windows.Forms.GroupBox();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbCodeType = new System.Windows.Forms.Label();
            this.lbD = new System.Windows.Forms.Label();
            this.lbCT = new System.Windows.Forms.Label();
            this.lbCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCardTypes = new System.Windows.Forms.ComboBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbxAccountInfo = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbUN = new System.Windows.Forms.Label();
            this.gbxCardInfo.SuspendLayout();
            this.gbxAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 64);
            this.label1.TabIndex = 17;
            this.label1.Text = "شراء بطاقة";
            // 
            // gbxCardInfo
            // 
            this.gbxCardInfo.Controls.Add(this.lbDate);
            this.gbxCardInfo.Controls.Add(this.lbCodeType);
            this.gbxCardInfo.Controls.Add(this.lbD);
            this.gbxCardInfo.Controls.Add(this.lbCT);
            this.gbxCardInfo.Controls.Add(this.lbCode);
            this.gbxCardInfo.Controls.Add(this.label3);
            this.gbxCardInfo.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCardInfo.Location = new System.Drawing.Point(165, 287);
            this.gbxCardInfo.Name = "gbxCardInfo";
            this.gbxCardInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxCardInfo.Size = new System.Drawing.Size(616, 222);
            this.gbxCardInfo.TabIndex = 21;
            this.gbxCardInfo.TabStop = false;
            this.gbxCardInfo.Text = "معلومات البطاقة";
            this.gbxCardInfo.Visible = false;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(20, 163);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(0, 25);
            this.lbDate.TabIndex = 5;
            // 
            // lbCodeType
            // 
            this.lbCodeType.AutoSize = true;
            this.lbCodeType.Location = new System.Drawing.Point(20, 108);
            this.lbCodeType.Name = "lbCodeType";
            this.lbCodeType.Size = new System.Drawing.Size(0, 25);
            this.lbCodeType.TabIndex = 4;
            // 
            // lbD
            // 
            this.lbD.AutoSize = true;
            this.lbD.Location = new System.Drawing.Point(532, 163);
            this.lbD.Name = "lbD";
            this.lbD.Size = new System.Drawing.Size(77, 25);
            this.lbD.TabIndex = 3;
            this.lbD.Text = "التاريخ :";
            // 
            // lbCT
            // 
            this.lbCT.AutoSize = true;
            this.lbCT.Location = new System.Drawing.Point(540, 108);
            this.lbCT.Name = "lbCT";
            this.lbCT.Size = new System.Drawing.Size(73, 25);
            this.lbCT.TabIndex = 2;
            this.lbCT.Text = "القيمة :";
            // 
            // lbCode
            // 
            this.lbCode.AutoSize = true;
            this.lbCode.Location = new System.Drawing.Point(20, 54);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(0, 25);
            this.lbCode.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "الكود :";
            // 
            // cbxCardTypes
            // 
            this.cbxCardTypes.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCardTypes.FormattingEnabled = true;
            this.cbxCardTypes.Location = new System.Drawing.Point(415, 200);
            this.cbxCardTypes.Name = "cbxCardTypes";
            this.cbxCardTypes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbxCardTypes.Size = new System.Drawing.Size(231, 36);
            this.cbxCardTypes.TabIndex = 20;
            this.cbxCardTypes.Text = "اختر قيمة البطاقة";
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuy.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.Location = new System.Drawing.Point(165, 192);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(175, 54);
            this.btnBuy.TabIndex = 19;
            this.btnBuy.Text = "شراء";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = ": قيمة البطاقة";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkGray;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPrint.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(12, 455);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(110, 54);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "طباعة";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbxAccountInfo
            // 
            this.gbxAccountInfo.Controls.Add(this.lbBalance);
            this.gbxAccountInfo.Controls.Add(this.lbUsername);
            this.gbxAccountInfo.Controls.Add(this.lbB);
            this.gbxAccountInfo.Controls.Add(this.lbUN);
            this.gbxAccountInfo.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAccountInfo.Location = new System.Drawing.Point(504, 22);
            this.gbxAccountInfo.Name = "gbxAccountInfo";
            this.gbxAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxAccountInfo.Size = new System.Drawing.Size(284, 137);
            this.gbxAccountInfo.TabIndex = 22;
            this.gbxAccountInfo.TabStop = false;
            this.gbxAccountInfo.Text = "معلومات الحساب";
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
            // lbB
            // 
            this.lbB.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.Location = new System.Drawing.Point(185, 91);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(85, 32);
            this.lbB.TabIndex = 5;
            this.lbB.Text = "الرصيد :";
            // 
            // lbUN
            // 
            this.lbUN.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUN.Location = new System.Drawing.Point(118, 40);
            this.lbUN.Name = "lbUN";
            this.lbUN.Size = new System.Drawing.Size(152, 33);
            this.lbUN.TabIndex = 4;
            this.lbUN.Text = "اسم المستخدم :";
            // 
            // frmBuyCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.gbxAccountInfo);
            this.Controls.Add(this.gbxCardInfo);
            this.Controls.Add(this.cbxCardTypes);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmBuyCard";
            this.Text = "Buy Card Form";
            this.Load += new System.EventHandler(this.frmBuyCard_Load);
            this.gbxCardInfo.ResumeLayout(false);
            this.gbxCardInfo.PerformLayout();
            this.gbxAccountInfo.ResumeLayout(false);
            this.gbxAccountInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxCardInfo;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbCodeType;
        private System.Windows.Forms.Label lbD;
        private System.Windows.Forms.Label lbCT;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCardTypes;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox gbxAccountInfo;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbUN;
    }
}