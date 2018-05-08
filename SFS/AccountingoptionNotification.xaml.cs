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
    /// Interaction logic for AccountingoptionNotification.xaml
    /// </summary>
    public partial class AccountingoptionNotification : Window
    {
        public AccountingoptionNotification()
        {
            InitializeComponent();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Loginas.au = "no";
            Loginas lg = new Loginas();
            lg.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            getExpenseMonth em = new getExpenseMonth();
            em.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Expense adde = new Add_Expense();
            adde.Show();
            this.Close();

        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            yearlyincome_statement yi = new yearlyincome_statement();
            yi.Show();
            this.Close();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {

            Loginas.au = "no";
            Loginas lgn = new Loginas();
            lgn.Show();
            this.Close();
        }
        private void notification_Click(object sender, RoutedEventArgs e)
        {
            if (employeelogin.depnoti == true)
            {
                MessageBox.Show("Welcom to your new department :)");
            }
            if (employeelogin.salnoti == true)
            {
                MessageBox.Show("Check your new salary !");
            }
            if (employeelogin.Notification==true)
            {
                MessageBox.Show("Please send your medical report !");
            }
               
            AccountingOptionForm ao = new AccountingOptionForm();
            ao.Show();
            this.Close();
        }
    }
}
