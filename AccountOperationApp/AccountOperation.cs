using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountOperationApp
{
    public partial class AccountOperation : Form
    {
        public AccountOperation()
        {
            InitializeComponent();
        }
        Account aAccount = new Account();
        private void creatAccountButton_Click(object sender, EventArgs e)
        {
            aAccount.accountId = accountNumberTextBox.Text;
            aAccount.name = customerNameTextBox.Text;
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = convert.ToDouble(amountOfMoneyTextBox.Text);
            aAccount.balanceAmount + = amount;
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount = convert.ToDouble(amountOfMoneyTextBox.Text);
            if(amount > aAccount.balanceAmount){
                MessageBox.Show("You Can't withdraw greater than your balance,\nTry again");
            }
            else{
                 aAccount.balanceAmount - = amount;
            }
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(aAccount.name+",your account number : "+aAccount.accountId+" and")
        }
    }
}
