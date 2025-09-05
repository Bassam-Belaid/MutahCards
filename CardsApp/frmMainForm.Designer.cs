namespace CardsApp
{
    partial class frmMainForm
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
            this.btnPurchasedCards = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuyCard = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.gbxAccountInfo = new System.Windows.Forms.GroupBox();
            this.lbBalance = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbUN = new System.Windows.Forms.Label();
            this.gbxAccountInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPurchasedCards
            // 
            this.btnPurchasedCards.BackColor = System.Drawing.Color.DarkGray;
            this.btnPurchasedCards.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchasedCards.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPurchasedCards.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchasedCards.Location = new System.Drawing.Point(679, 247);
            this.btnPurchasedCards.Name = "btnPurchasedCards";
            this.btnPurchasedCards.Size = new System.Drawing.Size(236, 78);
            this.btnPurchasedCards.TabIndex = 13;
            this.btnPurchasedCards.Text = "البطاقات التي اشتريتها";
            this.btnPurchasedCards.UseVisualStyleBackColor = false;
            this.btnPurchasedCards.Click += new System.EventHandler(this.btnPurchasedCards_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 64);
            this.label1.TabIndex = 11;
            this.label1.Text = "مرحبًا بك في برنامج بطاقات المتاح";
            // 
            // btnBuyCard
            // 
            this.btnBuyCard.BackColor = System.Drawing.Color.DarkGray;
            this.btnBuyCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuyCard.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuyCard.Font = new System.Drawing.Font("Arial Unicode MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyCard.Location = new System.Drawing.Point(679, 141);
            this.btnBuyCard.Name = "btnBuyCard";
            this.btnBuyCard.Size = new System.Drawing.Size(236, 78);
            this.btnBuyCard.TabIndex = 12;
            this.btnBuyCard.Text = "شراء بطاقة";
            this.btnBuyCard.UseVisualStyleBackColor = false;
            this.btnBuyCard.Click += new System.EventHandler(this.btnBuyCard_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(679, 351);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(236, 78);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "تسجيل خروج";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // gbxAccountInfo
            // 
            this.gbxAccountInfo.Controls.Add(this.lbBalance);
            this.gbxAccountInfo.Controls.Add(this.lbUsername);
            this.gbxAccountInfo.Controls.Add(this.lbB);
            this.gbxAccountInfo.Controls.Add(this.lbUN);
            this.gbxAccountInfo.Font = new System.Drawing.Font("Arial Unicode MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAccountInfo.Location = new System.Drawing.Point(153, 218);
            this.gbxAccountInfo.Name = "gbxAccountInfo";
            this.gbxAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbxAccountInfo.Size = new System.Drawing.Size(284, 137);
            this.gbxAccountInfo.TabIndex = 24;
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
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(945, 519);
            this.Controls.Add(this.gbxAccountInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnPurchasedCards);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBuyCard);
            this.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMainForm";
            this.Text = "Main Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainForm_FormClosing);
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.gbxAccountInfo.ResumeLayout(false);
            this.gbxAccountInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPurchasedCards;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuyCard;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.GroupBox gbxAccountInfo;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbUN;
    }
}