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
    /// Interaction logic for Edit_Department.xaml
    /// </summary>
    public partial class Edit_Department : Window
    {
        public static bool dep = false;
        public Edit_Department()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee ee = new Edit_Employee();
            ee.Show();
            this.Close();

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            

            if (comboBox.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else
            {

                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        if (Containers.Employee_list[i].GetDepartment() == comboBox.Text)
                        {
                            dep = true;
                             break;
                            
                        }
                    }
                }


                if (dep == false) 
                {
                    MessageBox.Show("Wrong Old Department");
                }
            
                else
                {
                    for (int i = 0; i < Containers.Employee_list.Count; i++)
                    {
                        if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                        {
                            Containers.Employee_list[i].setDepartment(comboBox1.Text);
                            Containers.Employee_list[i].setdepnot("YES");
                            dep = true;
                           
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
                        MessageBox.Show("Changes Done");
                    
                }
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
}
