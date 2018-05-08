using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SFS
{
    /// <summary>
    /// Interaction logic for Add_Expense.xaml
    /// </summary>
    public partial class Add_Expense : Window
    {
        public Add_Expense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm ac = new AccountingOptionForm();
            ac.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "" || expense_month.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else
            {
                Expense ex = new Expense(int.Parse(textBox.Text), expense_month.Text, textBox1.Text);
                ex.write_expense();
                MessageBox.Show("Expense Successfully Added !");
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm aa = new AccountingOptionForm();
            aa.Show();
            this.Close();
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);
            }
        }
    }
}
