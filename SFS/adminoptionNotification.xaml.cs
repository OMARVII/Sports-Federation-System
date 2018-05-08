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
    /// Interaction logic for adminoptionNotification.xaml
    /// </summary>
    public partial class adminoptionNotification : Window
    {
        public static bool disp = false;
        public static bool search = false;

        public adminoptionNotification()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Optionss ed = new Edit_Optionss();
            ed.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            statistics ed = new statistics();
            ed.Show();
            this.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Loginas.bu = "no";
            Loginas lgn = new Loginas();
            lgn.Show();
            this.Close();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform m = new mainqueryform();
            m.Show();
            this.Close();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            displayOptions dp = new displayOptions();
            dp.Show();
            this.Close();
        }

        private void button5_Click_1(object sender, RoutedEventArgs e)
        {
            searchoptions dp = new searchoptions();
            dp.Show();
            this.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Options a = new Add_Options();
            a.Show();
            this.Close();


        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            Loginas.bu = "no";
            adminlogin.admin = false;
            MainWindow sh = new MainWindow();
            sh.Show();
            this.Close();
        }
        private void notification_Click(object sender, RoutedEventArgs e)
        {
            if(Edit_Department.dep==true)
            {
                MessageBox.Show("Welcom to your new department :)");
            }
            if(Edit_DepartmentSalaryBonus.sal==true)
            {
                MessageBox.Show("Check your new salary !");
            }
            if(employeelogin.Notification)
            MessageBox.Show("Please send your medical report !");
            adminoptions ao = new adminoptions();
            ao.Show();
            this.Close();
        }
    }
}
