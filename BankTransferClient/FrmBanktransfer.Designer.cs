
namespace BankTransferClient
{
    partial class FrmBanktransfer
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
            this.gbRequestInformation = new System.Windows.Forms.GroupBox();
            this.lblAccountTotalAmount = new System.Windows.Forms.Label();
            this.lblRequestTotalAmount = new System.Windows.Forms.Label();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cboAccount = new System.Windows.Forms.ComboBox();
            this.lblRequestAccount = new System.Windows.Forms.Label();
            this.txtAccountAddress = new System.Windows.Forms.TextBox();
            this.lblRequestAddress = new System.Windows.Forms.Label();
            this.txtAccountFullName = new System.Windows.Forms.TextBox();
            this.lblRequestFullName = new System.Windows.Forms.Label();
            this.gbReceiverInformation = new System.Windows.Forms.GroupBox();
            this.txtReceiverAddress = new System.Windows.Forms.TextBox();
            this.lblReceiverAddress = new System.Windows.Forms.Label();
            this.txtReceiverFullName = new System.Windows.Forms.TextBox();
            this.lblReceiverFullName = new System.Windows.Forms.Label();
            this.lblReceiverAccountTypeLabel = new System.Windows.Forms.Label();
            this.lblReceiverAccountType = new System.Windows.Forms.Label();
            this.txtReceiverAccountNo = new System.Windows.Forms.TextBox();
            this.lblReceiverAccountNo = new System.Windows.Forms.Label();
            this.gbTransferMoney = new System.Windows.Forms.GroupBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtTransferAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.gbTransactionLog = new System.Windows.Forms.GroupBox();
            this.dgvwTransactionLog = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbRequestInformation.SuspendLayout();
            this.gbReceiverInformation.SuspendLayout();
            this.gbTransferMoney.SuspendLayout();
            this.gbTransactionLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTransactionLog)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRequestInformation
            // 
            this.gbRequestInformation.Controls.Add(this.lblAccountTotalAmount);
            this.gbRequestInformation.Controls.Add(this.lblRequestTotalAmount);
            this.gbRequestInformation.Controls.Add(this.lblAccountType);
            this.gbRequestInformation.Controls.Add(this.cboAccount);
            this.gbRequestInformation.Controls.Add(this.lblRequestAccount);
            this.gbRequestInformation.Controls.Add(this.txtAccountAddress);
            this.gbRequestInformation.Controls.Add(this.lblRequestAddress);
            this.gbRequestInformation.Controls.Add(this.txtAccountFullName);
            this.gbRequestInformation.Controls.Add(this.lblRequestFullName);
            this.gbRequestInformation.Location = new System.Drawing.Point(18, 18);
            this.gbRequestInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRequestInformation.Name = "gbRequestInformation";
            this.gbRequestInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbRequestInformation.Size = new System.Drawing.Size(450, 263);
            this.gbRequestInformation.TabIndex = 0;
            this.gbRequestInformation.TabStop = false;
            this.gbRequestInformation.Text = "Request Information";
            // 
            // lblAccountTotalAmount
            // 
            this.lblAccountTotalAmount.AutoSize = true;
            this.lblAccountTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAccountTotalAmount.Location = new System.Drawing.Point(171, 218);
            this.lblAccountTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountTotalAmount.Name = "lblAccountTotalAmount";
            this.lblAccountTotalAmount.Size = new System.Drawing.Size(19, 20);
            this.lblAccountTotalAmount.TabIndex = 8;
            this.lblAccountTotalAmount.Text = "0";
            // 
            // lblRequestTotalAmount
            // 
            this.lblRequestTotalAmount.AutoSize = true;
            this.lblRequestTotalAmount.Location = new System.Drawing.Point(57, 218);
            this.lblRequestTotalAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestTotalAmount.Name = "lblRequestTotalAmount";
            this.lblRequestTotalAmount.Size = new System.Drawing.Size(104, 20);
            this.lblRequestTotalAmount.TabIndex = 7;
            this.lblRequestTotalAmount.Text = "Total Amount";
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.ForeColor = System.Drawing.Color.Blue;
            this.lblAccountType.Location = new System.Drawing.Point(304, 175);
            this.lblAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(92, 20);
            this.lblAccountType.TabIndex = 6;
            this.lblAccountType.Text = "Visa Debit";
            // 
            // cboAccount
            // 
            this.cboAccount.FormattingEnabled = true;
            this.cboAccount.Location = new System.Drawing.Point(171, 171);
            this.cboAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboAccount.Name = "cboAccount";
            this.cboAccount.Size = new System.Drawing.Size(122, 28);
            this.cboAccount.TabIndex = 5;
            this.cboAccount.SelectedValueChanged += new System.EventHandler(this.cboAccount_SelectedValueChanged);
            // 
            // lblRequestAccount
            // 
            this.lblRequestAccount.AutoSize = true;
            this.lblRequestAccount.Location = new System.Drawing.Point(88, 175);
            this.lblRequestAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestAccount.Name = "lblRequestAccount";
            this.lblRequestAccount.Size = new System.Drawing.Size(68, 20);
            this.lblRequestAccount.TabIndex = 4;
            this.lblRequestAccount.Text = "Account";
            // 
            // txtAccountAddress
            // 
            this.txtAccountAddress.Location = new System.Drawing.Point(171, 69);
            this.txtAccountAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountAddress.Multiline = true;
            this.txtAccountAddress.Name = "txtAccountAddress";
            this.txtAccountAddress.Size = new System.Drawing.Size(268, 90);
            this.txtAccountAddress.TabIndex = 3;
            // 
            // lblRequestAddress
            // 
            this.lblRequestAddress.AutoSize = true;
            this.lblRequestAddress.Location = new System.Drawing.Point(94, 74);
            this.lblRequestAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestAddress.Name = "lblRequestAddress";
            this.lblRequestAddress.Size = new System.Drawing.Size(68, 20);
            this.lblRequestAddress.TabIndex = 2;
            this.lblRequestAddress.Text = "Address";
            // 
            // txtAccountFullName
            // 
            this.txtAccountFullName.Location = new System.Drawing.Point(171, 29);
            this.txtAccountFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAccountFullName.Name = "txtAccountFullName";
            this.txtAccountFullName.Size = new System.Drawing.Size(268, 26);
            this.txtAccountFullName.TabIndex = 1;
            // 
            // lblRequestFullName
            // 
            this.lblRequestFullName.AutoSize = true;
            this.lblRequestFullName.Location = new System.Drawing.Point(81, 34);
            this.lblRequestFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestFullName.Name = "lblRequestFullName";
            this.lblRequestFullName.Size = new System.Drawing.Size(80, 20);
            this.lblRequestFullName.TabIndex = 0;
            this.lblRequestFullName.Text = "Full Name";
            // 
            // gbReceiverInformation
            // 
            this.gbReceiverInformation.Controls.Add(this.txtReceiverAddress);
            this.gbReceiverInformation.Controls.Add(this.lblReceiverAddress);
            this.gbReceiverInformation.Controls.Add(this.txtReceiverFullName);
            this.gbReceiverInformation.Controls.Add(this.lblReceiverFullName);
            this.gbReceiverInformation.Controls.Add(this.lblReceiverAccountTypeLabel);
            this.gbReceiverInformation.Controls.Add(this.lblReceiverAccountType);
            this.gbReceiverInformation.Controls.Add(this.txtReceiverAccountNo);
            this.gbReceiverInformation.Controls.Add(this.lblReceiverAccountNo);
            this.gbReceiverInformation.Location = new System.Drawing.Point(489, 18);
            this.gbReceiverInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReceiverInformation.Name = "gbReceiverInformation";
            this.gbReceiverInformation.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbReceiverInformation.Size = new System.Drawing.Size(450, 263);
            this.gbReceiverInformation.TabIndex = 1;
            this.gbReceiverInformation.TabStop = false;
            this.gbReceiverInformation.Text = "Receiver Information";
            // 
            // txtReceiverAddress
            // 
            this.txtReceiverAddress.Location = new System.Drawing.Point(171, 138);
            this.txtReceiverAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverAddress.Multiline = true;
            this.txtReceiverAddress.Name = "txtReceiverAddress";
            this.txtReceiverAddress.Size = new System.Drawing.Size(268, 90);
            this.txtReceiverAddress.TabIndex = 7;
            // 
            // lblReceiverAddress
            // 
            this.lblReceiverAddress.AutoSize = true;
            this.lblReceiverAddress.Location = new System.Drawing.Point(94, 143);
            this.lblReceiverAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAddress.Name = "lblReceiverAddress";
            this.lblReceiverAddress.Size = new System.Drawing.Size(68, 20);
            this.lblReceiverAddress.TabIndex = 6;
            this.lblReceiverAddress.Text = "Address";
            // 
            // txtReceiverFullName
            // 
            this.txtReceiverFullName.Location = new System.Drawing.Point(171, 98);
            this.txtReceiverFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverFullName.Name = "txtReceiverFullName";
            this.txtReceiverFullName.Size = new System.Drawing.Size(268, 26);
            this.txtReceiverFullName.TabIndex = 5;
            // 
            // lblReceiverFullName
            // 
            this.lblReceiverFullName.AutoSize = true;
            this.lblReceiverFullName.Location = new System.Drawing.Point(81, 103);
            this.lblReceiverFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverFullName.Name = "lblReceiverFullName";
            this.lblReceiverFullName.Size = new System.Drawing.Size(80, 20);
            this.lblReceiverFullName.TabIndex = 4;
            this.lblReceiverFullName.Text = "Full Name";
            // 
            // lblReceiverAccountTypeLabel
            // 
            this.lblReceiverAccountTypeLabel.AutoSize = true;
            this.lblReceiverAccountTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAccountTypeLabel.ForeColor = System.Drawing.Color.Blue;
            this.lblReceiverAccountTypeLabel.Location = new System.Drawing.Point(166, 74);
            this.lblReceiverAccountTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAccountTypeLabel.Name = "lblReceiverAccountTypeLabel";
            this.lblReceiverAccountTypeLabel.Size = new System.Drawing.Size(114, 20);
            this.lblReceiverAccountTypeLabel.TabIndex = 3;
            this.lblReceiverAccountTypeLabel.Text = "Account type";
            // 
            // lblReceiverAccountType
            // 
            this.lblReceiverAccountType.AutoSize = true;
            this.lblReceiverAccountType.Location = new System.Drawing.Point(51, 74);
            this.lblReceiverAccountType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAccountType.Name = "lblReceiverAccountType";
            this.lblReceiverAccountType.Size = new System.Drawing.Size(106, 20);
            this.lblReceiverAccountType.TabIndex = 2;
            this.lblReceiverAccountType.Text = "Account Type";
            // 
            // txtReceiverAccountNo
            // 
            this.txtReceiverAccountNo.Location = new System.Drawing.Point(171, 29);
            this.txtReceiverAccountNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReceiverAccountNo.Name = "txtReceiverAccountNo";
            this.txtReceiverAccountNo.Size = new System.Drawing.Size(268, 26);
            this.txtReceiverAccountNo.TabIndex = 1;
            this.txtReceiverAccountNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountNoReceiver_KeyDown);
            // 
            // lblReceiverAccountNo
            // 
            this.lblReceiverAccountNo.AutoSize = true;
            this.lblReceiverAccountNo.Location = new System.Drawing.Point(66, 34);
            this.lblReceiverAccountNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceiverAccountNo.Name = "lblReceiverAccountNo";
            this.lblReceiverAccountNo.Size = new System.Drawing.Size(92, 20);
            this.lblReceiverAccountNo.TabIndex = 0;
            this.lblReceiverAccountNo.Text = "Account No";
            // 
            // gbTransferMoney
            // 
            this.gbTransferMoney.Controls.Add(this.btnTransfer);
            this.gbTransferMoney.Controls.Add(this.txtReason);
            this.gbTransferMoney.Controls.Add(this.lblReason);
            this.gbTransferMoney.Controls.Add(this.txtTransferAmount);
            this.gbTransferMoney.Controls.Add(this.lblAmount);
            this.gbTransferMoney.Location = new System.Drawing.Point(18, 291);
            this.gbTransferMoney.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTransferMoney.Name = "gbTransferMoney";
            this.gbTransferMoney.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTransferMoney.Size = new System.Drawing.Size(921, 134);
            this.gbTransferMoney.TabIndex = 2;
            this.gbTransferMoney.TabStop = false;
            this.gbTransferMoney.Text = "Transfer money";
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(314, 89);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(112, 35);
            this.btnTransfer.TabIndex = 4;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(627, 29);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(268, 93);
            this.txtReason.TabIndex = 3;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(490, 45);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(65, 20);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Reason";
            // 
            // txtTransferAmount
            // 
            this.txtTransferAmount.Location = new System.Drawing.Point(153, 45);
            this.txtTransferAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTransferAmount.Name = "txtTransferAmount";
            this.txtTransferAmount.Size = new System.Drawing.Size(271, 26);
            this.txtTransferAmount.TabIndex = 1;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(63, 49);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount:";
            // 
            // gbTransactionLog
            // 
            this.gbTransactionLog.Controls.Add(this.dgvwTransactionLog);
            this.gbTransactionLog.Location = new System.Drawing.Point(18, 434);
            this.gbTransactionLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTransactionLog.Name = "gbTransactionLog";
            this.gbTransactionLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTransactionLog.Size = new System.Drawing.Size(921, 198);
            this.gbTransactionLog.TabIndex = 3;
            this.gbTransactionLog.TabStop = false;
            this.gbTransactionLog.Text = "Transaction log";
            // 
            // dgvwTransactionLog
            // 
            this.dgvwTransactionLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwTransactionLog.Location = new System.Drawing.Point(20, 31);
            this.dgvwTransactionLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvwTransactionLog.Name = "dgvwTransactionLog";
            this.dgvwTransactionLog.RowHeadersWidth = 62;
            this.dgvwTransactionLog.Size = new System.Drawing.Size(892, 158);
            this.dgvwTransactionLog.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 642);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(826, 642);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmBanktransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 692);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbTransactionLog);
            this.Controls.Add(this.gbTransferMoney);
            this.Controls.Add(this.gbReceiverInformation);
            this.Controls.Add(this.gbRequestInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBanktransfer";
            this.Text = "Banktransfer";
            this.Load += new System.EventHandler(this.Banktransfer_Load);
            this.gbRequestInformation.ResumeLayout(false);
            this.gbRequestInformation.PerformLayout();
            this.gbReceiverInformation.ResumeLayout(false);
            this.gbReceiverInformation.PerformLayout();
            this.gbTransferMoney.ResumeLayout(false);
            this.gbTransferMoney.PerformLayout();
            this.gbTransactionLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwTransactionLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRequestInformation;
        private System.Windows.Forms.GroupBox gbReceiverInformation;
        private System.Windows.Forms.GroupBox gbTransferMoney;
        private System.Windows.Forms.GroupBox gbTransactionLog;
        private System.Windows.Forms.Label lblAccountTotalAmount;
        private System.Windows.Forms.Label lblRequestTotalAmount;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cboAccount;
        private System.Windows.Forms.Label lblRequestAccount;
        private System.Windows.Forms.TextBox txtAccountAddress;
        private System.Windows.Forms.Label lblRequestAddress;
        private System.Windows.Forms.TextBox txtAccountFullName;
        private System.Windows.Forms.Label lblRequestFullName;
        private System.Windows.Forms.TextBox txtReceiverAddress;
        private System.Windows.Forms.Label lblReceiverAddress;
        private System.Windows.Forms.TextBox txtReceiverFullName;
        private System.Windows.Forms.Label lblReceiverFullName;
        private System.Windows.Forms.Label lblReceiverAccountTypeLabel;
        private System.Windows.Forms.Label lblReceiverAccountType;
        private System.Windows.Forms.TextBox txtReceiverAccountNo;
        private System.Windows.Forms.Label lblReceiverAccountNo;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtTransferAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.DataGridView dgvwTransactionLog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnClose;
    }
}