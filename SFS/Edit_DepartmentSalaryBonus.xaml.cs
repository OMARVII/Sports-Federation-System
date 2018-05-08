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
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    /// <summary>
    /// Interaction logic for Edit_DepartmentSalaryBonus.xaml
    /// </summary>
    public partial class Edit_DepartmentSalaryBonus : Window
    {
        public static bool sal = false;
        public Edit_DepartmentSalaryBonus()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           
            if (salary.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setSalary(float.Parse(salary.Text));
                        Containers.Employee_list[i].setsalarynot("YES");
                    }

                }

                if (File.Exists("Employees.xml"))
                {
                    File.Delete("Employees.xml");
                }

                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    Containers.write_Employee(Containers.Employee_list[i]);

                }
                if (Enter_ID_Employee.coaach == true)
                {
                    for (int i = 0; i < Containers.Coach_list.Count; i++)
                    {
                        if (Containers.Coach_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                        {
                            Containers.Coach_list[i].setSalary(float.Parse(salary.Text));
                            
                        }

                    }
                    if (File.Exists("Coaches.xml"))
                    {
                        File.Delete("Coaches.xml");
                    }

                    for (int i = 0; i < Containers.Coach_list.Count; i++)
                    {
                        Containers.write_coach(Containers.Coach_list[i]);

                    }
                }
                MessageBox.Show("Changes Done");
            }
        }




        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
           // this.Hide();
            Edit_Employee ee = new Edit_Employee();
            ee.Show();
            this.Close();


        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
