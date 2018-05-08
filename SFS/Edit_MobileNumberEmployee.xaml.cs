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
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee ee = new Edit_Employee();
            ee.Show();
            this.Close();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            
            if (textBox1.Text == "" || mobile.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if (mobile.Text.Length != 11)
            {
                MessageBox.Show("Please Enter Valid Mobile Number!");
            }
            else
            {
                bool mobilee = false;
                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        if (Containers.Employee_list[i].getmobile() == textBox1.Text)
                            mobilee = true;
                    }
                }
                bool mobiles = false;
                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getmobile() == mobile.Text)
                    {
                        mobiles = true;
                    }
                }
                for (int i = 0; i < Containers.Player_list.Count(); i++)
                {
                    if (Containers.Player_list[i].getmobile() == mobile.Text)
                    {
                        mobiles = true;
                    }
                }
                if (mobiles == true)
                {
                    MessageBox.Show("Please Re-enter Mobile Number !");
                }

               else if (mobilee == false)
                {
                    MessageBox.Show("Wrong Mobile Number");
                }
                else
                {
                    for (int i = 0; i < Containers.Employee_list.Count; i++)
                    {
                        if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                        {
                            Containers.Employee_list[i].setmobile(mobile.Text);
                            
                            break;
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
                                Containers.Coach_list[i].setmobile(mobile.Text);

                                break;
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
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void mobile_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(mobile.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                mobile.Text = mobile.Text.Remove(mobile.Text.Length - 1);
            }
        }
    }
}
