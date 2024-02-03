using Moneymattersbank.Data;
using Moneymattersbank.Enum;
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
    public partial class Depositfrm : Form
    {
        public Depositfrm()
        {
            InitializeComponent();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            CreateTransactionModel transactionModel = new CreateTransactionModel();
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Enter Account Number");
                return;
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Enter Amount");
                return;
            }
            else if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("Staff Name");
                return;
            }
            transactionModel.StaffName = txtStaffName.Text;
            transactionModel.AccountNumber =Convert.ToInt64(txtAccountNumber.Text);
            transactionModel.Amount =Convert.ToDecimal(txtAmount.Text);
            transactionModel.CollectionDate = dtCollectionDate.Value;
            transactionModel.TransactionType = (int)TransactionType.Deposite;
          bool result=  repository.CreateTransaction(transactionModel);
            if (result)
            {
                MessageBox.Show("Amount has been Deposited");
            }
            else
            {
                MessageBox.Show("There are some error please try again");
            }
        }
   
    }
}
