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
    /// Interaction logic for EmployeesDepartmentDataG.xaml
    /// </summary>
    public partial class EmployeesDepartmentDataG : Window
    {
        public EmployeesDepartmentDataG()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmployeesDepartmentQuery eq = new EmployeesDepartmentQuery();
                eq.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> filter_name = new List<string>();
            List<string> filter_salary = new List<string>();
            List<string> filter_mob = new List<string>();
            for (int i = 0; i < Containers.Employee_list.Count(); i++)
            {
                if (Containers.Employee_list[i].GetDepartment() == EmployeesDepartmentQuery.dep)
                {
                    filter_name.Add(Containers.Employee_list[i].getName());
                    filter_salary.Add(Containers.Employee_list[i].getSalary().ToString());
                    filter_mob.Add(Containers.Employee_list[i].getmobile());
                }
            }
            listBox.ItemsSource = filter_name;
            listBox1.ItemsSource = filter_salary;
            listBox2.ItemsSource = filter_mob;    
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
