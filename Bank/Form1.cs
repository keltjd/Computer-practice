using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void replinish_bill_Click(object sender, EventArgs e)
        {
            BankAccount bill = (BankAccount)listBox_bank_accs.SelectedItem;
            bill.Add_on_bill(Convert.ToInt32(textBox_replinish_bill.Text));
            listBox_bank_accs.Items[listBox_bank_accs.SelectedIndex] = listBox_bank_accs.Items[listBox_bank_accs.SelectedIndex];
            textBox_replinish_bill.Text = "";
        }

        private void create_bill_Click(object sender, EventArgs e)
        {
            BankAccount new_bill = new BankAccount();
            _count_bills += 1;
            listBox_bank_accs.Items.Add(new_bill);
        }

        private void remove_from_bill_Click(object sender, EventArgs e)
        {
            BankAccount bill = (BankAccount)listBox_bank_accs.SelectedItem;
            bill.Remove_from_bill(Convert.ToInt32(textBox_remove_from_bill.Text));
            listBox_bank_accs.Items[listBox_bank_accs.SelectedIndex] = listBox_bank_accs.Items[listBox_bank_accs.SelectedIndex];
            textBox_remove_from_bill.Text = "";
        }


        private void count_of_bills_Click(object sender, EventArgs e)
        { 
            label_count_of_bills.Text = Convert.ToString(_count_bills);
        }
        private int _count_bills = 0;

        private void sum_of_maney_Click(object sender, EventArgs e)
        {
            decimal sum = 0;
            for(int index_bills = 0; index_bills < _count_bills; index_bills++)
            {
                BankAccount bill = (BankAccount)listBox_bank_accs.Items[index_bills];
                sum += bill.GetMoneys();
            }
            label_sum_money.Text = Convert.ToString(sum);
        }
    }
}
