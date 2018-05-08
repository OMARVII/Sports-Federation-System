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
    /// Interaction logic for getExpenseMonth.xaml
    /// </summary>
    public partial class getExpenseMonth : Window
    {
        public getExpenseMonth()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm op = new AccountingOptionForm();
            op.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            bool available = false;
            List<string> expense_des = new List<string>();
            List<int> expense_value = new List<int>();
            for(int i=0;i<Expense.expense_list.Count();i++)
            {
                if(Expense.expense_list[i].get_expense_month()==expense_month.Text)
                {
                    available = true;
                    expense_value.Add(Expense.expense_list[i].get_value());
                    expense_des.Add(Expense.expense_list[i].get_expense_takenfor());
                }
            }
            if (available == false)
            {
                MessageBox.Show("No expenses in this month !");
            }
            else
            {
                listBox.ItemsSource = expense_des;
                listBox1.ItemsSource = expense_value;
            }
        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            AccountingOptionForm aa = new AccountingOptionForm();
            aa.Show();
            this.Close();
        }
    }
}
