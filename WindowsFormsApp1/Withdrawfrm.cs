using Moneymattersbank.Data;
using Moneymattersbank.Enum;
using Moneymattersbank.Models;
using System;
using System.Windows.Forms;

namespace Moneymattersbank
{
    public partial class Withdrawfrm : Form
    {
        public Withdrawfrm()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            CreateTransactionModel transactionModel = new CreateTransactionModel();
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Please enter account number");
                return;
            }
            else if (string.IsNullOrEmpty(txtAmount.Text))
            {
                MessageBox.Show("Please enter amount");
                return;
            }
            else if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("Please staff name");
                return;
            }
            transactionModel.AccountNumber = Convert.ToInt64(txtAccountNumber.Text);
            int turn = repository.GetNoOfWithdraw(transactionModel.AccountNumber);
            transactionModel.StaffName = txtStaffName.Text;
            
            double balance = repository.GetAccountBalance(transactionModel.AccountNumber);
            double totalamount = Convert.ToDouble(txtAmount.Text);
            if (turn>=3)
            {
                totalamount = totalamount + 1.5;
            }
            if ((balance - totalamount) < 20)
            {
                MessageBox.Show("You can't withdraw amount because amount will left than 20");
                return;
            } 
             
            transactionModel.Amount = Convert.ToDecimal(totalamount);
            transactionModel.CollectionDate = dtCollectionDate.Value;
            transactionModel.TransactionType = (int)TransactionType.WithDraw;
            bool result = repository.CreateTransaction(transactionModel);
            if (result)
            {
                if (Convert.ToDecimal(txtAmount.Text) > 500 && Convert.ToDecimal(txtAmount.Text) <= 5000)
                {
                    MessageBox.Show("Supervisor will approve this transaction");
                }
                else
                {
                    MessageBox.Show("Amount has been withdraw");
                }
                
            }
            else
            {
                MessageBox.Show("There are some error please try again");
            }
        }

    }
}
