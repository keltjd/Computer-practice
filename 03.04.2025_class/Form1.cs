using System.Windows.Forms;
using System;

namespace _03._04._2025_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Button_Create_empl_Click(object sender, EventArgs e)
        {

            if (textBox_name.Text != "" && textBox_selary.Text != "" && Calendar_of_emp.SelectionStart != default(DateTime))
            {

                Employee emp = new Employee(textBox_name.Text, Convert.ToInt32(textBox_selary.Text), Calendar_of_emp.SelectionStart);
                listBox_empls.Items.Add(emp);
            }

            else if (Calendar_of_emp.SelectionStart == default(DateTime))
            {

                Employee emp = new Employee(textBox_name.Text, Convert.ToInt32(textBox_selary.Text));
                listBox_empls.Items.Add(emp);
            }
            else if (textBox_selary.Text == "")
            {

                Employee emp = new Employee(textBox_name.Text, Calendar_of_emp.SelectionStart);
                listBox_empls.Items.Add(emp);


            }
        }

        private void Calendar_of_emp_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void chenge_selary_Click(object sender, EventArgs e)
        {

            Employee emp = (Employee)listBox_empls.SelectedItem;
            if (listBox_empls.SelectedItem is Employee empls)
            {
                if (int.TryParse(textBox_change_selary.Text, out int new_selary))
                {
                    empls.GetSelary(new_selary);
                    int selectedIndex = listBox_empls.SelectedIndex;
                    listBox_empls.Items[selectedIndex] = listBox_empls.Items[selectedIndex];
                }
            }




        }

        private void listBox_empls_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numbs_woring_time_Click(object sender, EventArgs e)
        {
            Employee emp = (Employee)listBox_empls.SelectedItem;
            lable_working_time.Text = Convert.ToString(emp.GetWorkingTime());
        }
    }
}