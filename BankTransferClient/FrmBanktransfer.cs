using BankTransferClient.localhost;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankTransferClient
{
    public partial class FrmBanktransfer : Form
    {
        private BankTransfer bankTransfer = new BankTransfer();
        private ErrorProvider amountErrorProvider;
        public FrmBanktransfer()
        {
            InitializeComponent();
            amountErrorProvider = new ErrorProvider();
            amountErrorProvider.BlinkStyle = ErrorBlinkStyle.AlwaysBlink;
            amountErrorProvider.BlinkRate = 1000;
            amountErrorProvider.SetIconPadding(txtTransferAmount, 2);
            amountErrorProvider.SetIconAlignment(txtTransferAmount, ErrorIconAlignment.MiddleRight);
        }

        public int UserID { get; internal set; }

        private void Banktransfer_Load(object sender, EventArgs e)
        {
            DataTable Accounts = bankTransfer.GetAccountsByUserID(UserID).Tables[0];
            cboAccount.DataSource = Accounts;
            cboAccount.DisplayMember = "AccountID";
            cboAccount.ValueMember = "AccountID";
        }

        private void cboAccount_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int AccountID = (int)cboAccount.SelectedValue;
                DataTable Users = bankTransfer.GetUsersInforByAccounts(AccountID).Tables[0];
                if (Users.Rows.Count > 0)
                {
                    txtAccountFullName.Text = Users.Rows[0]["FullName"].ToString();
                    txtAccountAddress.Text = Users.Rows[0]["Address"].ToString();
                    lblAccountTotalAmount.Text = Users.Rows[0]["TotalAmount"].ToString();
                    lblAccountType.Text = Users.Rows[0]["AccountType"].ToString();
                    getAllTransactionByAccountID(AccountID);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void getAllTransactionByAccountID(int AccountID)
        {
            try
            {
                DataTable Transactions = bankTransfer.GetTransactionLog(AccountID).Tables[0];
                if (Transactions.Rows.Count > 0)
                {
                    dgvwTransactionLog.DataSource = Transactions;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void txtAccountNoReceiver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                if (!string.IsNullOrEmpty(txtReceiverAccountNo.Text))
                {
                    try
                    {
                        int AccountID = int.Parse(txtReceiverAccountNo.Text);
                        DataTable Users = bankTransfer.GetUsersInforByAccounts(AccountID).Tables[0];
                        if (Users.Rows.Count > 0)
                        {
                            txtReceiverFullName.Text = Users.Rows[0]["FullName"].ToString();
                            txtReceiverAddress.Text = Users.Rows[0]["Address"].ToString();
                            lblReceiverAccountTypeLabel.Text = Users.Rows[0]["AccountType"].ToString();
                        } else
                        {
                            MessageBox.Show("Không tìm thấy tài khoản: " + AccountID);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (AmountIsValid())
            {
                amountErrorProvider.SetError(txtTransferAmount, string.Empty);
                int requestID = (int)cboAccount.SelectedValue;
                int receiverID = int.Parse(txtReceiverAccountNo.Text);
                decimal amount = decimal.Parse(txtTransferAmount.Text);
                string reason = txtReason.Text;
                if (bankTransfer.Transfer(requestID, receiverID, amount, reason))
                {
                    MessageBox.Show("Giao dịch thành công!");
                    getAllTransactionByAccountID(requestID);
                } else
                {
                    MessageBox.Show("Giao dịch lỗi!");
                }
            } else
            {
                amountErrorProvider.SetError(txtTransferAmount, "Giá tiền không hợp lệ");
            }
        }

        private bool AmountIsValid()
        {
            decimal amount = 0;
            decimal.TryParse(txtTransferAmount.Text, out amount);
            return amount > 0;
        }
    }
}
