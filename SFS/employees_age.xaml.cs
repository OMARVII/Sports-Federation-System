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
    /// Interaction logic for employees_age.xaml
    /// </summary>
    public partial class employees_age : Window
    {
        public employees_age()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            List<Employee> l = Containers.Employee_list;
            List<Employee> old = new List<Employee>();
            for (int i = 0; i < l.Count; i++)
            {
                if (l[i].ageCalculator() >= 60)
                {
                    old.Add(l[i]);
                }

            }
            List<int> tage = new List<int>();
            List<string> tname = new List<string>();
            List<string> tdep = new List<string>();


            for (int i = 0; i < old.Count; i++)
            {
                tage.Add(old[i].ageCalculator());
                tname.Add(old[i].getName());
                tdep.Add(old[i].GetDepartment());

            }

            if (old.Count() == 0)
            {
                MessageBox.Show("No Employees Above Age ");
            }
            else
            { 

            listBox.ItemsSource = tname;
            listBox1.ItemsSource = tage;
            listBox2.ItemsSource = tdep;
            }

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            mainqueryform q = new mainqueryform();
            q.Show();
            this.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }
    }
    }

