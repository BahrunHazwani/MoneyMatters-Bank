using Moneymattersbank.Data;
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
    public partial class TransactionDetailfrm : Form
    {
        public TransactionDetailfrm()
        {
            InitializeComponent();
        }

        private void TransactionDetailfrm_Load(object sender, EventArgs e)
        {
            lbldDeposit.Text = "0";
            lbldWithdraw.Text = "0";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Please enter account number");
                return;
            }
            Repository repository = new Repository();
            var result= repository.GetTransaction(Convert.ToInt64(txtAccountNumber.Text));
            dgrdTransaction.DataSource = result;
           lbldDeposit.Text= result.Where(x => x.TransactionType == "Deposit").Sum(x=>Convert.ToDecimal(x.Amount.Replace("RM ",""))).ToString();
            lbldWithdraw.Text = result.Where(x => x.TransactionType == "Withdraw").Sum(x => Convert.ToDecimal(x.Amount.Replace("RM ", ""))).ToString();
        }

    }
}
