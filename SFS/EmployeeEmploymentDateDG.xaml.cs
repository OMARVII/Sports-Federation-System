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
    /// Interaction logic for EmployeeEmploymentDateDG.xaml
    /// </summary>
    public partial class EmployeeEmploymentDateDG : Window
    {
        public EmployeeEmploymentDateDG()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            EmploymentdurationQuery md = new EmploymentdurationQuery();
            md.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<string> filtered = new List<string>();
            List<string> filtered_dep = new List<string>();
            List<float> filtered_salary = new List<float>();
            for (int i = 0; i < Containers.Employee_list.Count(); i++)
            {
               
                
                if (Containers.Employee_list[i].getWorking_Year().ToString() == EmploymentdurationQuery.ans)
                {
                    filtered.Add(Containers.Employee_list[i].getName());
                    filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                    filtered_salary.Add(Containers.Employee_list[i].getSalary());
                }
            }
            if (filtered.Count() == 0)
            {
                MessageBox.Show("No Employees With Such Working Years");
            }
            else
            {
                listBox.ItemsSource = filtered;
                listBox1.ItemsSource = filtered_dep;
                listBox2.ItemsSource = filtered_salary;
            }
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
