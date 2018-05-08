using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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

namespace SFS
{
    /// <summary>
    /// Interaction logic for Enter_ID_Employee.xaml
    /// </summary>
    public partial class Enter_ID_Employee : Window
    {
        public static string employeeeid;
        public static bool coaach=false;
        public Enter_ID_Employee()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (id.Text == "")
            {
                MessageBox.Show("Please Enter ID");
            }
            else
            {
                employeeeid = id.Text;
                bool noo = false;
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId() == id.Text)
                    {
                        if (Containers.Employee_list[i].GetDepartment() == "HR" && employeelogin.hrid == true || (Containers.Employee_list[i].GetDepartment() == "HR" && Edit_EmployeePassword.ggg == true))
                        {
                            MessageBox.Show("You are not allowed to edit or delete HR Employee");
                            noo = true;
                            break;
                        }
                        else if (Containers.Employee_list[i].GetDepartment() == "Coach")
                            coaach = true;
                    }
                }
                if (noo == false)
                {

                    bool find = false;
                    for (int i = 0; i < Containers.Employee_list.Count; i++)
                    {
                        if (Containers.Employee_list[i].getId() == id.Text)
                        {
                            Containers.Employee_list.Remove(Containers.Employee_list[i]);
                            find = true;
                        }
                    }
                    if (find == false)
                    {
                        MessageBox.Show("Wrong ID");
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
                        MessageBox.Show("Employee Successfuly Deleted");
                        if (coaach == true)
                        {
                            for (int i = 0; i < Containers.Coach_list.Count; i++)
                            {
                                if (Containers.Coach_list[i].getId() == id.Text)
                                {
                                    Containers.Coach_list.Remove(Containers.Coach_list[i]);


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
                            MessageBox.Show("Coach Successfuly Deleted");
                        }
                    }

                }
            }
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
           Edit_Optionss ed = new Edit_Optionss();
            ed.Show();
            this.Close();

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            bool noo = false;
            bool find = false;
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == id.Text)
                {
                       if (Containers.Employee_list[i].GetDepartment() == "Coach")
                        coaach = true;
                    find = true;
                }
            }
            if (find == false)
            {
                MessageBox.Show("Wrong ID");
            }
            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId() == id.Text)
                    {
                        if ((Containers.Employee_list[i].GetDepartment() == "HR" && employeelogin.hrid == true)|| (Containers.Employee_list[i].GetDepartment() == "HR" && Edit_EmployeePassword.ggg == true))
                        {
                            MessageBox.Show("You are not allowed to edit or delete HR Employee");
                            noo = true;
                            break;
                        }
                    }
                }
                if (noo == false)
                {
                    employeeeid = id.Text;
                    Edit_Employee eee = new SFS.Edit_Employee();
                    eee.Show();
                    this.Close();
                }
            }
        }

        private void id_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void button4_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();

        }
    }
}
