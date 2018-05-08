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
    /// Interaction logic for SalaryQuery.xaml
    /// </summary>
    public partial class SalaryQuery : Window
    {
        public static float value = 0;
        public static string query = "";
        public SalaryQuery()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (SalaryComparasionValue.Text == "" || comboBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Data !");
            }
            else
            {
                value = float.Parse(SalaryComparasionValue.Text);
                query = comboBox.Text;
                SalaryQueryDataGrid sd = new SalaryQueryDataGrid();
                sd.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform mq = new mainqueryform();
            mq.Show();
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void SalaryComparasionValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SalaryComparasionValue.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                SalaryComparasionValue.Text = SalaryComparasionValue.Text.Remove(SalaryComparasionValue.Text.Length - 1);
            }
        }

        private void SalaryComparasionValue_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(SalaryComparasionValue.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                SalaryComparasionValue.Text = SalaryComparasionValue.Text.Remove(SalaryComparasionValue.Text.Length - 1);
            }
        }
    }
}

