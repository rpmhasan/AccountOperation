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
    public partial class AccountOperationUI : Form
    {
        public AccountOperationUI()
        {
            InitializeComponent();
        }
        Account myAccount = new Account();
       
        private void addButton_Click(object sender, EventArgs e)
        {
           
            myAccount.accName = customerNameTextBox.Text;
            myAccount.accnumbr = accNumbrTextBox.Text;
           
            MessageBox.Show("Account Created Successfully");


        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            double amount = myAccount.totalAmount;

            amount = (amount + Convert.ToDouble(amountTextBox.Text));
            myAccount.totalAmount = amount;

            MessageBox.Show(Convert.ToString(amount));
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (myAccount.totalAmount>=Convert.ToDouble(amountTextBox.Text))
            {
                double amount = myAccount.totalAmount;
                amount = (amount - Convert.ToDouble(amountTextBox.Text));
                myAccount.totalAmount = amount;
                MessageBox.Show(Convert.ToString(amount));
            }
            else
            {
                MessageBox.Show("Not enough memory!");
            }
           
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is " + myAccount.accName + " " + "Amount is " + myAccount.totalAmount);
        }
    }
}
