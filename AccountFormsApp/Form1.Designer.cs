namespace AccountFormsApp
{
    partial class Form1
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
            this.txtBox_AcctName = new System.Windows.Forms.TextBox();
            this.lbl_AcctName = new System.Windows.Forms.Label();
            this.lstBox_CurrentAccts = new System.Windows.Forms.ListBox();
            this.lbl_currentAccts = new System.Windows.Forms.Label();
            this.txtBox_Balance = new System.Windows.Forms.TextBox();
            this.btn_AddAcct = new System.Windows.Forms.Button();
            this.lbl_AcctBalance = new System.Windows.Forms.Label();
            this.txtBox_Deposit = new System.Windows.Forms.TextBox();
            this.txtBox_Withdrawal = new System.Windows.Forms.TextBox();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_Withdrawal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox_AcctName
            // 
            this.txtBox_AcctName.Location = new System.Drawing.Point(40, 47);
            this.txtBox_AcctName.Name = "txtBox_AcctName";
            this.txtBox_AcctName.Size = new System.Drawing.Size(100, 20);
            this.txtBox_AcctName.TabIndex = 0;
            this.txtBox_AcctName.TextChanged += new System.EventHandler(this.txtBox_AcctName_TextChanged);
            // 
            // lbl_AcctName
            // 
            this.lbl_AcctName.AutoSize = true;
            this.lbl_AcctName.Location = new System.Drawing.Point(37, 31);
            this.lbl_AcctName.Name = "lbl_AcctName";
            this.lbl_AcctName.Size = new System.Drawing.Size(103, 13);
            this.lbl_AcctName.TabIndex = 1;
            this.lbl_AcctName.Text = "New Account Name";
            this.lbl_AcctName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lstBox_CurrentAccts
            // 
            this.lstBox_CurrentAccts.FormattingEnabled = true;
            this.lstBox_CurrentAccts.Location = new System.Drawing.Point(40, 164);
            this.lstBox_CurrentAccts.Name = "lstBox_CurrentAccts";
            this.lstBox_CurrentAccts.Size = new System.Drawing.Size(120, 95);
            this.lstBox_CurrentAccts.TabIndex = 2;
            this.lstBox_CurrentAccts.SelectedIndexChanged += new System.EventHandler(this.lstBox_CurrentAccts_SelectedIndexChanged);
            // 
            // lbl_currentAccts
            // 
            this.lbl_currentAccts.AutoSize = true;
            this.lbl_currentAccts.Location = new System.Drawing.Point(40, 145);
            this.lbl_currentAccts.Name = "lbl_currentAccts";
            this.lbl_currentAccts.Size = new System.Drawing.Size(89, 13);
            this.lbl_currentAccts.TabIndex = 3;
            this.lbl_currentAccts.Text = "Current Accounts";
            // 
            // txtBox_Balance
            // 
            this.txtBox_Balance.Location = new System.Drawing.Point(322, 86);
            this.txtBox_Balance.Name = "txtBox_Balance";
            this.txtBox_Balance.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Balance.TabIndex = 4;
            // 
            // btn_AddAcct
            // 
            this.btn_AddAcct.Location = new System.Drawing.Point(40, 83);
            this.btn_AddAcct.Name = "btn_AddAcct";
            this.btn_AddAcct.Size = new System.Drawing.Size(100, 23);
            this.btn_AddAcct.TabIndex = 5;
            this.btn_AddAcct.Text = "Add Account";
            this.btn_AddAcct.UseVisualStyleBackColor = true;
            this.btn_AddAcct.Click += new System.EventHandler(this.btn_AddAcct_Click);
            // 
            // lbl_AcctBalance
            // 
            this.lbl_AcctBalance.AutoSize = true;
            this.lbl_AcctBalance.Location = new System.Drawing.Point(322, 67);
            this.lbl_AcctBalance.Name = "lbl_AcctBalance";
            this.lbl_AcctBalance.Size = new System.Drawing.Size(89, 13);
            this.lbl_AcctBalance.TabIndex = 6;
            this.lbl_AcctBalance.Text = "Account Balance";
            // 
            // txtBox_Deposit
            // 
            this.txtBox_Deposit.Location = new System.Drawing.Point(322, 180);
            this.txtBox_Deposit.Name = "txtBox_Deposit";
            this.txtBox_Deposit.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Deposit.TabIndex = 7;
            // 
            // txtBox_Withdrawal
            // 
            this.txtBox_Withdrawal.Location = new System.Drawing.Point(322, 216);
            this.txtBox_Withdrawal.Name = "txtBox_Withdrawal";
            this.txtBox_Withdrawal.Size = new System.Drawing.Size(100, 20);
            this.txtBox_Withdrawal.TabIndex = 8;
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.Location = new System.Drawing.Point(322, 161);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(43, 13);
            this.lbl_Amount.TabIndex = 9;
            this.lbl_Amount.Text = "Amount";
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(226, 178);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(75, 23);
            this.btn_Deposit.TabIndex = 10;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // btn_Withdrawal
            // 
            this.btn_Withdrawal.Location = new System.Drawing.Point(226, 214);
            this.btn_Withdrawal.Name = "btn_Withdrawal";
            this.btn_Withdrawal.Size = new System.Drawing.Size(75, 23);
            this.btn_Withdrawal.TabIndex = 11;
            this.btn_Withdrawal.Text = "Withdrawal";
            this.btn_Withdrawal.UseVisualStyleBackColor = true;
            this.btn_Withdrawal.Click += new System.EventHandler(this.btn_Withdrawal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 320);
            this.Controls.Add(this.btn_Withdrawal);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.txtBox_Withdrawal);
            this.Controls.Add(this.txtBox_Deposit);
            this.Controls.Add(this.lbl_AcctBalance);
            this.Controls.Add(this.btn_AddAcct);
            this.Controls.Add(this.txtBox_Balance);
            this.Controls.Add(this.lbl_currentAccts);
            this.Controls.Add(this.lstBox_CurrentAccts);
            this.Controls.Add(this.lbl_AcctName);
            this.Controls.Add(this.txtBox_AcctName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_AcctName;
        private System.Windows.Forms.Label lbl_AcctName;
        private System.Windows.Forms.ListBox lstBox_CurrentAccts;
        private System.Windows.Forms.Label lbl_currentAccts;
        private System.Windows.Forms.TextBox txtBox_Balance;
        private System.Windows.Forms.Button btn_AddAcct;
        private System.Windows.Forms.Label lbl_AcctBalance;
        private System.Windows.Forms.TextBox txtBox_Deposit;
        private System.Windows.Forms.TextBox txtBox_Withdrawal;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_Withdrawal;
    }
}

