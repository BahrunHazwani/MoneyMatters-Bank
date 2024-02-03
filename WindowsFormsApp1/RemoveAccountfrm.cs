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
    public partial class RemoveAccountfrm : Form
    {
        public RemoveAccountfrm()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Repository repository = new Repository();
            if (string.IsNullOrEmpty(txtAccountNumber.Text))
            {
                MessageBox.Show("Please enter Account Number");
                return;
            }
            bool result = repository.RemoveAccountDetail(Convert.ToInt64(txtAccountNumber.Text));
            if (result)
            {
                MessageBox.Show("Account has been removed");
            }
            else
            {
                MessageBox.Show("There are some errors, please try again");
            }
        }

    }
}
