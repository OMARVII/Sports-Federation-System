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
    /// Interaction logic for Search_Employee.xaml
    /// </summary>
    public partial class Search_Employee : Window
    {
        public Search_Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            List<Employee> find_Employee = new List<Employee>();
            if (textBox.Text == "")
            {
                MessageBox.Show("Please fill the required information");
            }
            for (int i = 0; i < Containers.Employee_list.Count; i++)
            {
                if (Containers.Employee_list[i].getId() == textBox.Text)
                {
                    find_Employee.Add(Containers.Employee_list[i]);
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
