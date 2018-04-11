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
    /// Interaction logic for Edit_Employee.xaml
    /// </summary>
    public partial class Edit_Employee : Window
    {
        public Edit_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (choose.Text == "Mobile_Number")
            {
                Edit_MobileNumberEmployee ee = new Edit_MobileNumberEmployee();
                ee.Show();
            }
          
            else if (choose.Text == "Salary")
            {
                Edit_DepartmentSalaryBonus z = new Edit_DepartmentSalaryBonus();
                z.Show();
            }
            else if (choose.Text == "Bonus")
            {
                Edit_DepartmentSalaryBonus z = new Edit_DepartmentSalaryBonus();
                z.Show();
            }
            else if (choose.Text == "Department")
            {
                Edit_DepartmentSalaryBonus z = new Edit_DepartmentSalaryBonus();
                z.Show();
            }
            else if (choose.Text == "Avaliable")
            {
                Edit_Avaliable g = new Edit_Avaliable();
                g.Show();
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Enter_ID_Employee eie = new Enter_ID_Employee();
            eie.Show();
        }
    }
}
