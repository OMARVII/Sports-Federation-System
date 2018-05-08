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
    /// Interaction logic for SalaryQueryDataGrid.xaml
    /// </summary>
    public partial class SalaryQueryDataGrid : Window
    {
        public SalaryQueryDataGrid()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            SalaryQuery sq = new SalaryQuery();
            sq.Show();
            this.Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           // List<Employee> ch = new List<Employee>();
            List<string> filtered_Name = new List<string>();
            List<string> filtered_dep = new List<string>();
            List<float> filtered_Salary = new List<float>();
           //  MessageBox.Show(SalaryQuery.query);
          //  MessageBox.Show(SalaryQuery.value.ToString());
            for (int i = 0; i < Containers.Employee_list.Count(); i++)
            {
               // MessageBox.Show(Containers.Employee_list[i].getSalary().ToString());
                
                if (SalaryQuery.query == "Less Than or Equal")
                {
                    if (Containers.Employee_list[i].getSalary() <= SalaryQuery.value) 
                    {
                        filtered_Name.Add(Containers.Employee_list[i].getName());
                        filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                        filtered_Salary.Add(Containers.Employee_list[i].getSalary());
                    }
                }
                else if (SalaryQuery.query == "Greater Than or equal")
                {
                    if (Containers.Employee_list[i].getSalary() >= SalaryQuery.value)
                    {
                        filtered_Name.Add(Containers.Employee_list[i].getName());
                        filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                        filtered_Salary.Add(Containers.Employee_list[i].getSalary());
                    }
                }
                else if (SalaryQuery.query == "Greater than")
                { 
                    if (Containers.Employee_list[i].getSalary() > SalaryQuery.value)
                    {
                        filtered_Name.Add(Containers.Employee_list[i].getName());
                        filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                        filtered_Salary.Add(Containers.Employee_list[i].getSalary());
                    }
                }
                else if (SalaryQuery.query == "Less than")
                {
                    if (Containers.Employee_list[i].getSalary() < SalaryQuery.value)
                    {
                        filtered_Name.Add(Containers.Employee_list[i].getName());
                        filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                        filtered_Salary.Add(Containers.Employee_list[i].getSalary());
                    }
                }
                else if (SalaryQuery.query == "Equal")
                {
                    if (Containers.Employee_list[i].getSalary() == SalaryQuery.value)
                    {
                        filtered_Name.Add(Containers.Employee_list[i].getName());
                        filtered_dep.Add(Containers.Employee_list[i].GetDepartment());
                        filtered_Salary.Add(Containers.Employee_list[i].getSalary());
                    }
                }
               
            }
            if (filtered_Name.Count() == 0)
            {
                MessageBox.Show("No Employees Available In This Query ");
            }
            else
            {
                listBox.ItemsSource = filtered_Name;
                listBox1.ItemsSource = filtered_dep;
                listBox2.ItemsSource = filtered_Salary;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions ap = new adminoptions();
            ap.Show();
                
            this.Close();
        }
    }
}
