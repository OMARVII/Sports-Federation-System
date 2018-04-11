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
    /// Interaction logic for Edit_Avaliable.xaml
    /// </summary>
    public partial class Edit_Avaliable : Window
    {
        public Edit_Avaliable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           bool avail = false;
            if (yes.IsChecked == true)
                avail = true;
            if ((yes.IsChecked == true) && (no.IsChecked == true))
                MessageBox.Show("Please fill the required information !");

            else
            {
                for (int i = 0; i < Containers.Employee_list.Count; i++)
                {
                    if (Containers.Employee_list[i].getId().ToString() == Enter_ID_Employee.employeeeid)
                    {
                        Containers.Employee_list[i].setStatus(avail);
                    }

                }
                
                MessageBox.Show("Done Changes");
            }





        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Edit_Employee oo = new Edit_Employee();
            oo.Show();
        }
    }
}
