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
    /// Interaction logic for Edit_EmployeeMedicalForm.xaml
    /// </summary>
    public partial class Edit_EmployeeMedicalForm : Window
    {
        public Edit_EmployeeMedicalForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string med = "NO";
            if (yes.IsChecked == true)
                med = "YES";
            if ((yes.IsChecked == false) && (no.IsChecked == false))
                MessageBox.Show("Please fill the required information !");

            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setMedicalReport(med);

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
                            Containers.Coach_list[i].setMedicalReport(med);

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
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee eee = new Edit_Employee();
            eee.Show();
            this.Close();
        }

        private void radioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }
    }
}
