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
    /// Interaction logic for Edit_Delete.xaml
    /// </summary>
    public partial class Edit_Delete : Window
    {
        public Edit_Delete()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (choose.Text == "Player")
            {
                Enter_ID ei = new Enter_ID();
                ei.Show();
            }
           else if (choose.Text == "Employee")
            {
                Enter_ID_Employee ei = new Enter_ID_Employee();
                ei.Show();
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Options o = new Options();
            o.Show();
        }
    }
}
