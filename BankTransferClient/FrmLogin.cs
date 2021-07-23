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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BankTransfer bankTransferService = new BankTransfer();
            int UserID = 0;
            if (string.IsNullOrEmpty(txtUsername.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập Username và Password");
            } else
            {
                if (bankTransferService.CheckUserLogin(txtUsername.Text, txtPassword.Text, out UserID))
                {
                    FrmBanktransfer frmBanktransfer = new FrmBanktransfer();
                    frmBanktransfer.UserID = UserID;
                    frmBanktransfer.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", 
                "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
