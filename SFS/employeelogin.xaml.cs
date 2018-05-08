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
    /// Interaction logic for employeelogin.xaml
    /// </summary>
    public partial class employeelogin : Window
    {
        static public bool empid=false;
        static public bool hrid=false;
        static public bool Notification = false;
        static public string loginid = "";
        static public string loginpass = "";
        static public bool depnoti = false;
        static public bool salnoti = false;
        public employeelogin()
        {
            InitializeComponent();
            empid = false;
            hrid = false;
            Notification = false;
            loginid = "";
            loginpass = "";
            depnoti = false;
            salnoti = false;
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            bool valid = false;
            loginid = login.Text;
            loginpass = passwordBox.Password;
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == login.Text)
                {
                    if (Containers.Employee_list[i].GetDepartment() == "Coach")
                    {
                        empid = true;
                    }
                }
            }
            bool x = false,y=false;

            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == login.Text && Containers.Employee_list[i].Getpassword() == passwordBox.Password)
                {
                    if (Containers.Employee_list[i].GetDepartment() == "Accounting")
                    {
                        if (Loginas.bu == "yes")
                        {
                            x = true;
                            break;
                        }
                    }
                } 
                
            }
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].GetDepartment() == "HR")
                {
                    if (Containers.Employee_list[i].getId() == login.Text && Containers.Employee_list[i].Getpassword() == passwordBox.Password)
                    {
                        if (Loginas.au == "yes")
                        {
                            y = true;
                            break;
                        }
                    }
                }
            }
            if (x == true||y==true)
            {
                MessageBox.Show("Wrong ID or Password");
            }
            else
            {
                
               
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId() == login.Text && Containers.Employee_list[i].Getpassword() == passwordBox.Password)
                    {
                        Containers.Employee_list[i].setStatus("YES");
                        if (Containers.Employee_list[i].getMedicalReport() == "NO")
                        {
                            Notification = true;

                        }

                        if (Containers.Employee_list[i].getdepnot() == "YES")
                        {
                            depnoti = true;
                            Containers.Employee_list[i].setdepnot("NO");
                        }
                        if (Containers.Employee_list[i].getsalarynot() == "YES")
                        {
                            salnoti = true;
                            Containers.Employee_list[i].setsalarynot("NO");
                        }
                        if (Containers.Employee_list[i].GetDepartment() == "Coach")
                        {
                            break;
                        }
                            MessageBox.Show("Login Successfuly.");
                            if (Containers.Employee_list[i].GetDepartment() == "HR")
                            {
                            if (login.Text == passwordBox.Password)
                            {
                                    Edit_EmployeePassword eee = new Edit_EmployeePassword();
                                    eee.Show(); 
                                
                            }
                            else
                            {
                                if (Notification == true|| depnoti == true || salnoti==true)
                                {
                                    adminoptionNotification oo = new adminoptionNotification();
                                    hrid = true;
                                    oo.Show();
                                }
                                else
                                {
                                    adminoptions oo = new adminoptions();
                                    hrid = true;
                                    oo.Show();
                                }
                            }
                                this.Close();
                            }
                            else if (Containers.Employee_list[i].GetDepartment() == "Accounting")
                            {
                            if (login.Text == passwordBox.Password)
                            {
                                Edit_EmployeePassword eee = new Edit_EmployeePassword();
                                eee.Show();
                            }
                            else
                            {
                                if (Notification == true|| depnoti == true || salnoti == true)
                                {
                                    AccountingoptionNotification af = new AccountingoptionNotification();
                                    af.Show();
                                }
                                else
                                {
                                    AccountingOptionForm af = new AccountingOptionForm();
                                    af.Show();
                                }
                                

                            }
                                this.Close();
                            }

                            valid = true;
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
                if (!valid)
                    MessageBox.Show("Wrong ID or Password!");
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Loginas mw = new Loginas();
            mw.Show();
            this.Close();
        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
    }

