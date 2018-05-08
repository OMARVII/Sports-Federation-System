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
    /// Interaction logic for Edit_EmployeePassword.xaml
    /// </summary>
    public partial class Edit_EmployeePassword : Window
    {
        static public bool ggg = false;
        public Edit_EmployeePassword()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Loginas.bu == "yes")
            {
                if (employeelogin.Notification == true|| employeelogin.depnoti == true || employeelogin.salnoti == true)
                {
                    ggg = true;
                    adminoptionNotification s = new adminoptionNotification();
                    s.Show();
                    this.Close();
                }
                else
                {
                    ggg = true;
                    adminoptions s = new adminoptions();
                    s.Show();
                    this.Close();
                }
            }
            else
            {
                if (employeelogin.Notification == true|| employeelogin.depnoti == true || employeelogin.salnoti == true)
                {
                    AccountingoptionNotification aa = new AccountingoptionNotification();
                    aa.Show();
                    this.Close();
                }
                else
                {
                    AccountingOptionForm aa = new AccountingOptionForm();
                    aa.Show();
                    this.Close();
                }

            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            bool found = false;
            if (textBox.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
          else if (password.Text.Length < 6)
            {
                MessageBox.Show("Password Is Too Short !");

            }
            else if(textBox.Text== password.Text)
            {
                MessageBox.Show("Enter Diffrent Password ");
            }
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == employeelogin.loginid)
                    {
                        if (Containers.Employee_list[i].Getpassword() == textBox.Text)
                        {
                            found = true;
                            Containers.Employee_list[i].setpassword(password.Text);
                        }
                    }

                }
                
                if (found == false)
                {
                    MessageBox.Show("Wrong Password ");
                }
                else
                {
                    if (File.Exists("Employees.xml"))
                    {
                        File.Delete("Employees.xml");
                    }

                    for (int i = 0; i < Containers.Employee_list.Count; i++)
                    {
                        Containers.write_Employee(Containers.Employee_list[i]);

                    }
                    MessageBox.Show("Changes Done");
                    if (Loginas.bu == "yes")
                    {
                        if (employeelogin.Notification == true || employeelogin.depnoti == true||employeelogin.salnoti==true)
                        {
                            ggg = true;
                            adminoptionNotification s = new adminoptionNotification();
                            s.Show();
                            this.Close();
                        }
                        else { 
                        ggg = true;
                        adminoptions s = new adminoptions();
                        s.Show();
                        this.Close();
                    }
                    }
                    else
                    {
                        if (employeelogin.Notification == true || employeelogin.depnoti == true || employeelogin.salnoti == true)
                        {
                            AccountingoptionNotification aa = new AccountingoptionNotification();
                            aa.Show();
                            this.Close();
                        }
                        else
                        {
                            AccountingOptionForm aa = new AccountingOptionForm();
                            aa.Show();
                            this.Close();
                        }
                        
                    }
                }

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
