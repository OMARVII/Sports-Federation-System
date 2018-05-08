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
    /// Interaction logic for Edit_Optionss.xaml
    /// </summary>
    public partial class Edit_Optionss : Window
    {
        public Edit_Optionss()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (co.Text == "")
            {
                MessageBox.Show("Please Choose An Option");
            }
            else
            {
                if (co.Text == "Employee")
                {
                    if (employeelogin.empid == true)
                    {
                        MessageBox.Show("You are not alowed to edit or delete employee");
                    }
                    else
                    {
                        Enter_ID_Employee nn = new Enter_ID_Employee();
                        nn.Show();
                        this.Close();
                    }
                }
                else if (co.Text == "Player")
                {
                    Enter_ID nn = new Enter_ID();
                    nn.Show();
                    this.Close();
                }

            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions aa = new adminoptions();
            aa.Show();
            this.Close();
        }

        private void choose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions aa = new adminoptions();
            aa.Show();
            this.Close();
        }
    }
}
