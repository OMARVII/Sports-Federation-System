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
    /// Interaction logic for Edit_MobileNumberEmployee.xaml
    /// </summary>
    public partial class Edit_MobileNumberEmployee : Window
    {
        public Edit_MobileNumberEmployee()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text == "" || mobile.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if (textBox1.Text == mobile.Text)
            {
                MessageBox.Show("Please enter a diffrent Mobile Number!");
                textBox1.Clear();
                mobile.Clear();
            }
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setmobile(mobile.Text);
                    }

                }
                MessageBox.Show("Done Changes");
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee ee = new Edit_Employee();
            ee.Show();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
             

        }
    }
}
