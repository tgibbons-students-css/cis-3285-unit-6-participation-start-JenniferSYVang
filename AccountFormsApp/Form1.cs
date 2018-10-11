using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Services;

namespace AccountFormsApp
{
    public partial class Form1 : Form
    {
        IAccountServices accService = new AccountService();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddAcct_Click(object sender, EventArgs e)
        {
            string accName = txtBox_AcctName.Text;
            lstBox_CurrentAccts.Items.Add(accName);

            accService.CreateAccount(accName, AccountType.Silver);
        }

        private void txtBox_AcctName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstBox_CurrentAccts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string acctName = lstBox_CurrentAccts.SelectedItem.ToString();
            Decimal balance = accService.GetAccountBalance(acctName);

            // adds balance to txtBox_Balance 
            txtBox_Balance.Text = balance.ToString();
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            string acctName = lstBox_CurrentAccts.SelectedItem.ToString();
            Decimal depositAmt = Decimal.Parse(txtBox_Deposit.Text.ToString());

            accService.Deposit(acctName, depositAmt);

            txtBox_Balance.Text = accService.GetAccountBalance(acctName).ToString();
        }

        private void btn_Withdrawal_Click(object sender, EventArgs e)
        {
            string acctName = lstBox_CurrentAccts.SelectedItem.ToString();
            Decimal withdrawlAmt = Decimal.Parse(txtBox_Withdrawal.Text.ToString());

            accService.Withdrawal(acctName, withdrawlAmt);

            txtBox_Balance.Text = accService.GetAccountBalance(acctName).ToString();
        }
    }
}
