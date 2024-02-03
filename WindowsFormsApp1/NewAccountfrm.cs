using Moneymattersbank.Data;
using Moneymattersbank.Enum;
using Moneymattersbank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace Moneymattersbank
{
    public partial class NewAccountfrm : Form
    {
        public NewAccountfrm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            AccountDetailModel model = new AccountDetailModel();
            double deposit = 0;
            if (string.IsNullOrEmpty(txtDeposit.Text))
            {
                MessageBox.Show("Enter Deposit Amount");
                return;
            }
            if (string.IsNullOrEmpty(txtDeposit.Text))
            {
                MessageBox.Show("Enter Deposit Amount");
                return;
            }
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Enter Name");
                return;
            }
            if (string.IsNullOrEmpty(txticname.Text))
            {
                MessageBox.Show("Enter IC Number");
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Enter Phone");
                return;
            }
            if (string.IsNullOrEmpty(txtDistrict.Text))
            {
                MessageBox.Show("Enter District");
                return;
            }
            if (string.IsNullOrEmpty(txtState.Text))
            {
                MessageBox.Show("Enter State");
                return;
            }
            if (cmbGender.SelectedItem==null)
            {
                MessageBox.Show("Select Gender");
                return;
            }
            deposit = Convert.ToDouble(txtDeposit.Text);
            string accountNumber = ""; 
            model.AccountType =Convert.ToInt32(cmbAccountType.SelectedValue);
            model.Address = txtAddress.Text;
            model.Gender = cmbGender.SelectedItem.ToString();
            model.IcNumber = txticname.Text;
            model.Name = txtName.Text;
            model.PhoneNumber = txtPhone.Text;
            model.District = txtDistrict.Text;
            model.State = txtState.Text;
            model.BranchCode= Convert.ToInt32(cmbBranchCode.SelectedValue);
            if (model.AccountType==1 && deposit<50)
            {
                MessageBox.Show("Deposit must be more than RM 50");
                return;
            }
            else if (model.AccountType == 2 && deposit < 500)
            {
                MessageBox.Show("Deposit must be more than RM 500");
                return;
            }
            else if (model.AccountType == 3 && deposit < 1000)
            {
                MessageBox.Show("Deposit must be more than RM 1000");
                return;
            }
            Repository repository = new Repository();
            long lastcounter = repository.GetLastCounter();
            if (lastcounter<0)
            {
                MessageBox.Show("Sorry, Having an error plese try again");
                return;
            }
            string tempCounter = $"{lastcounter+1:0000000}";
            accountNumber = cmbAccountType.SelectedValue.ToString() + cmbBranchCode.SelectedValue.ToString() + tempCounter;
           
var intList = accountNumber.Select(digit => int.Parse(digit.ToString()));
            List<int> lstwith3 = new List<int>();
            double totalofx = 0;
            foreach (var item in intList)
            {
                totalofx= totalofx+(Math.Pow(item + 3, item + 3));
            }
            BigInteger newtotalofx = BigInteger.Pow(new BigInteger(totalofx),Convert.ToInt32(totalofx));
            string lastthree=   newtotalofx.ToString().Substring(newtotalofx.ToString().Length - 3, 3);
            model.AccountNumber = accountNumber + lastthree;
            model.CounterNumber = lastcounter + 1;
            bool result = repository.CreateAccountDetail(model);
            if (result)
            {
                CreateTransactionModel transactionModel = new CreateTransactionModel();
                transactionModel.StaffName = "Account Opening";
                transactionModel.AccountNumber = Convert.ToInt64(model.AccountNumber);
                transactionModel.Amount = Convert.ToDecimal(deposit);
                transactionModel.CollectionDate = DateTime.Now;
                transactionModel.TransactionType = (int)TransactionType.Deposite;
                repository.CreateTransaction(transactionModel);
                MessageBox.Show("Account has been created."+Environment.NewLine +" "+model.AccountNumber);
                this.Close();
            }
            else
            {
                MessageBox.Show("There are some errors");
            }
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void LoadAccountType()
        {
            Repository repository = new Repository();
            cmbAccountType.DataSource = repository.GetAccountTypes();
            cmbAccountType.ValueMember = "Id";
            cmbAccountType.DisplayMember = "Value";
        }
        private void LoadBranchCode()
        {
            Repository repository = new Repository();
            cmbBranchCode.DataSource = repository.GetBranchCode();
            cmbBranchCode.ValueMember = "Id";
            cmbBranchCode.DisplayMember = "Value";
        }
        private void NewAccountfrm_Load(object sender, System.EventArgs e)
        {
             
           
            LoadAccountType();
            LoadBranchCode();
        }
    }
}
