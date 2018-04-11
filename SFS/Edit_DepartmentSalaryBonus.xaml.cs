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
    /// Interaction logic for Edit_DepartmentSalaryBonus.xaml
    /// </summary>
    public partial class Edit_DepartmentSalaryBonus : Window
    {
        public Edit_DepartmentSalaryBonus()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (Department.Text == "" || salary.Text == "")
                MessageBox.Show("Please fill the required information !");
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setDepartment(Department.Text);
                        Containers.Employee_list[i].setDepartment(salary.Text);
                    }

                }
                MessageBox.Show("Done Changes");
            }



            }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Edit_Employee ee = new Edit_Employee();
            ee.Show();

        }
    }
}
