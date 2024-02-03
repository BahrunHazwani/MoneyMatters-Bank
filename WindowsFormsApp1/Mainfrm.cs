using Moneymattersbank.Data;
using Moneymattersbank.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneymattersbank
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadAccountType();
        }

        private void LoadAccountType()
        {
            Repository repository = new Repository();
            cmbAccountType.DataSource = repository.GetAccountTypes();
            cmbAccountType.ValueMember = "Id";
            cmbAccountType.DisplayMember = "Value";
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            NewAccountfrm newAccountfrm = new NewAccountfrm();
            newAccountfrm.ShowDialog();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Depositfrm depositfrm = new Depositfrm();
            depositfrm.ShowDialog();
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            Withdrawfrm frm = new Withdrawfrm();
            frm.ShowDialog();
        }

        private void btnViewAccount_Click(object sender, EventArgs e)
        {
            TransactionDetailfrm frm = new TransactionDetailfrm();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
          AccountDetailModel account=  repository.GetAccountDetail(Convert.ToInt64(txtAccountNumber.Text));
            if (account!=null)
            {
                txtName.Text = account.Name;
                txticname.Text = account.IcNumber;
                txtAddress.Text = account.Address;
                txtPhone.Text = account.PhoneNumber;
                txtAccountBalance.Text = account.Balance.ToString("#.##");
                
                switch (account.AccountType)
                {
                    case 1:
                        txtAccountType.Text = "Normal Savings Account";
                        break;

                    case 2:
                        txtAccountType.Text = "Premium Savings Account";
                        break;

                    case 3:
                        txtAccountType.Text = "Current Account";
                        break;
                }

                txtGender.Text = account.Gender;
            }
        }


        private void btnREMOVEACCOUNT_Click(object sender, EventArgs e)
        {
            RemoveAccountfrm frm = new RemoveAccountfrm();
            frm.ShowDialog();
        }

        private void btn_MouscHover(object sender, EventArgs e)
        {
            
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
