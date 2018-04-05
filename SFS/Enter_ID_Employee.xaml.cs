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
    /// Interaction logic for Enter_ID_Employee.xaml
    /// </summary>
    public partial class Enter_ID_Employee : Window
    {
        public Enter_ID_Employee()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            /* for(int i=0;i<Employees.count;i++)
            {
                if(Employees[i].ID==id.Text)
                {
                    Employees.remove(players[i]);
                }
            }*/
            MessageBox.Show("Successfuly Deleted");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Edit_Delete ed = new Edit_Delete();
            ed.Show();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee eee = new SFS.Edit_Employee();
            eee.Show();
        }
    }
}
